using System;
using System.Drawing;

namespace TP2.Modele
{
    public class CharacterPlayer : Character
    {

        private const double encounterRate = 5.33;
        Random Rng;

        public CharacterPlayer(GameModel TheGame) : base(TheGame)
        {
            Location = new Point(50, 50);
            Speed = MoveSpeed.Normal;
            Rng = new Random();
        }

        protected override void WalkOnGrass()
        {
            double rolledChance = Rng.NextDouble() * 100;

            if (encounterRate > rolledChance)
            {
                TheGame.StartBattle();
            }
        }

        protected override void ShowPokedex()
        {
            TheGame.Notify(ModelEvents.ShowPokedex, this);
        }
        protected override void ActivateHeal()
        {
            foreach (Pokemon pkm in Party)
            {
                pkm.CurrentHp = pkm.MaxHp;
            }
            TheGame.Notify(ModelEvents.PokeCenter, this);
        }

    }
}
