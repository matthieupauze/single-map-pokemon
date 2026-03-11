using System;
using System.Collections.Generic;
using System.Threading;
using TP2.Commun;

namespace TP2.Modele
{
    public class Pokemon : BasePokemon, Commun.IObservable<Pokemon>
    {

        public int MaxHp
        {
            get
            {
                return floor((2 * BaseHp) * Level / 100 + Level + 10);
            }
        }
        private int currentHp;
        public int CurrentHp
        {
            get
            {
                return currentHp;
            }
            set
            {
                if (value < 0)
                {
                    currentHp = 0;
                }
                else
                {
                    currentHp = value;
                }
            }
        }

        public int Attack
        {
            get
            {
                return floor((2 * BaseAttack) * Level / 100 + 5);
            }
        }
        public int Defense
        {
            get
            {
                return floor((2 * BaseDefense) * Level / 100 + 5);
            }
        }
        public int SpecialAttack
        {
            get
            {
                return floor((2 * BaseSpecialAttack) * Level / 100 + 5);
            }
        }
        public int SpecialDefense
        {
            get
            {
                return floor((2 * BaseSpecialDefense) * Level / 100 + 5);
            }
        }
        public int Speed
        {
            get
            {
                return floor((2 * BaseSpeed) * Level / 100 + 5);
            }
        }
        public int Level { get; private set; }
        //public int XPValue { get; private set; } // N'est pas utilisé
        public bool IsMale { get; private set; }
        public Attack[] Moves;

        private static Random Rng = new Random();
        private List<IObservateur<Pokemon>> Observateurs;

        public Pokemon(BasePokemon basicPokemon, int level) : base(basicPokemon)
        {
            Observateurs = new List<IObservateur<Pokemon>>();
            Level = level;
            CurrentHp = MaxHp;
            int i = Rng.Next(2);
            if (i == 1)
            {
                IsMale = true;
            }
            else
            {
                IsMale = false;
            }
            Moves = AttacksDB.GetDefaultAttacks();
        }

        public void TakeDamage(int damage)
        {
            CurrentHp -= damage;
            Notify();
        }

        public int AttackPokemon(Pokemon enemy, Attack chosenAttack)
        {
            int crit = 1;
            int atkPower = 1;
            int defensePower = 1;
            int random = Rng.Next(217, 256);

            if (Rng.Next(100) < 15) // 15% chance of crit
            {
                crit = 2;
            }

            if (chosenAttack.Type == AttackType.Physical)
            {
                atkPower = Attack;
                defensePower = enemy.Defense;
            }
            else
            {
                atkPower = SpecialAttack;
                defensePower = enemy.SpecialDefense;
            }

            double damageDealt = ((((Level * 0.4 * crit) + 2) * atkPower * chosenAttack.BasePower / 50 / defensePower) + 2) * random / 255;
            int finalisedDamage = (int)Math.Floor(damageDealt);

            enemy.TakeDamage(finalisedDamage);

            enemy.Notify();

            return finalisedDamage;
        }

        private int floor(double d)
        {
            return (int)Math.Floor(d);
        }

        public bool TryCapturePokemon()
        {
            double chances = 0;
            int A = CurrentHp * 2;
            int B = MaxHp * 3;
            int C = CatchRate;
            if (B > 255)
            {
                A = floor(floor(A / 2) / 2);
                B = floor(floor(B / 2) / 2);
            }
            chances = floor((B - A) * C / B);
            if (chances > 255)
            {
                return true;
            }
            else if (Rng.Next(256) > chances)
            {
                return true;
            }
            return false;
        }



        public void AddObserver(Commun.IObservateur<Pokemon> Observer)
        {
            Observateurs.Add(Observer);
        }

        public void RemoveObserver(Commun.IObservateur<Pokemon> Observer)
        {
            Observateurs.Remove(Observer);
        }

        public void Notify()
        {
            foreach (var ob in Observateurs)
            {
                ob.MettreAJour();
            }
        }

        public void Notify(Pokemon Action, object sender)
        {
            foreach (var ob in Observateurs)
            {
                ob.MettreAJour(Action, sender);
            }
        }
    }
}
