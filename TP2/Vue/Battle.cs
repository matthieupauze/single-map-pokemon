using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TP2.Commun;
using TP2.Modele;

namespace TP2.Vue
{
    public partial class Battle : UserControl, Commun.IObservable<ModelEvents>
    {

        Pokemon Ally;
        Pokemon Enemy;

        List<IObservateur<ModelEvents>> BattleObservers;
        int escapeAttempts = 0;
        Control[] ctrlsAttaques;

        public Battle()
        {
            InitializeComponent();
            BattleObservers = new List<IObservateur<ModelEvents>>();
            ctrlsAttaques = new Control[] { btnAttaque1, btnAttaque2, btnAttaque3, btnAttaque4 };
            SetFonts();
        }

        private void SetFonts()
        {
            foreach (Control c in msgAttacks.Controls)
            {
                c.Font = CustomFont.Small;
            }
            lblMessage.Font = CustomFont.Standard;
        }

        public void SetPokemon(Pokemon ally, Pokemon enemy)
        {
            pkmFriendly1.SetPokemon(ally);
            pkmEnemy1.SetPokemon(enemy);
            Ally = ally;
            Enemy = enemy;
            setAttackButtons();
            ShowAttacks();
        }

        public void SetPokemon(PokemonPair battlers)
        {
            SetPokemon(battlers.ally, battlers.enemy);
        }

        private void setAttackButtons()
        {
            for (int i = 0; i < 4; i++)
            {
                ctrlsAttaques[i].Text = Ally.Moves[i].Name.Capitalize();
            }
        }

        private void UseAttack(object sender)
        {
            HideAttacks();

            Attack mv = Ally.Moves[Array.IndexOf(ctrlsAttaques, sender)];
            int damageDealt = Ally.AttackPokemon(Enemy, mv);

            stateDamageDealt(damageDealt, mv, Enemy);
            if (Enemy.CurrentHp == 0)
            {
                pkmEnemy1.Kill();
                EndVictory();
                return;
            }

            CounterAttack();
            if (Ally.CurrentHp == 0)
            {
                pkmFriendly1.Kill();
                EndLoss();
                return;
            }
            ShowAttacks();
        }

        private void EndLoss()
        {
            WriteMessage("Vous avez été vaincu...");
            Notify(ModelEvents.BattleEnd, this);
            Ally.CurrentHp = 1;
        }

        private void EndVictory()
        {
            WriteMessage("Vous êtes victorieux!");
            Notify(ModelEvents.BattleEnd, this);
        }

        public Pokemon GetEnemyPokemon()
        {
            return Enemy;
        }

        private void stateDamageDealt(int damageDealt, Attack move, Pokemon target)
        {
            string message = move.Name + " a fait " + damageDealt + " points de dégats à " + target.Name;
            WriteMessage(message);
        }

        private void CounterAttack()
        {
            Random Rng = new Random();
            Attack mv = Enemy.Moves[Rng.Next(Enemy.Moves.Length)];
            int damageDealt = Enemy.AttackPokemon(Ally, mv);
            stateDamageDealt(damageDealt, mv, Ally);
        }

        private void tenterFuir()
        {
            escapeAttempts++;
            double escapeChance = (Ally.Speed * 32) / (Enemy.Speed / 4 % 256) + 30 * escapeAttempts;

            HideAttacks();

            if (escapeChance > 255)
            {
                WriteMessage("Tu as réussi a fuire saint et sauf...");
                Notify(ModelEvents.BattleEnd, this);
            }
            else
            {
                Random rng = new Random();
                if (rng.Next(256) < escapeChance)
                {
                    WriteMessage("Tu as réussi a fuire saint et sauf...");
                    Notify(ModelEvents.BattleEnd, this);
                }
                else
                {
                    WriteMessage("Tu n'as pas réussi à fuir!");
                    CounterAttack();
                    if (Ally.CurrentHp == 0)
                    {
                        EndLoss();
                        return;
                    }
                }
            }

            ShowAttacks();
        }

        private void btnFuir_Click(object sender, MouseEventArgs e)
        {
            tenterFuir();
        }

        private void Attack_Event(object sender, MouseEventArgs e)
        {
            UseAttack(sender);
        }

        private void rdCapturer_MouseClick(object sender, MouseEventArgs e)
        {
            tenterCapture();
        }

        private void rdAttack1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                UseAttack(sender);
            }
        }

        /// <summary>
        /// Assure toi de cacher et d'afficher les attaques si c'est important
        /// </summary>
        /// <param name="message">À afficher</param>
        public void WriteMessage(string message)
        {
            foreach (char c in message)
            {
                lblMessage.Text += c;
                lblMessage.Refresh();
                Waiting.WaitMilliseconds(50);
            }
            Waiting.WaitMilliseconds(1300);
            lblMessage.ResetText();
        }

        private void rdFuire_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                tenterFuir();
            }
        }

        private void rdCapturer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                tenterCapture();
            }
        }

        private void tenterCapture()
        {
            HideAttacks();
            if (Enemy.TryCapturePokemon())
            {
                WriteMessage("Vous avez réussi a capturer " + Enemy.Name + " !");
                Notify(ModelEvents.BattleCaptured, this);
            }
            else
            {
                WriteMessage("Vous n'avez pas réussi a capturer " + Enemy.Name + "...");
                CounterAttack();
                if (Ally.CurrentHp == 0)
                {
                    EndLoss();
                    return;
                }
            }
            ShowAttacks();
        }

        public void HideAttacks()
        {
            msgAttacks.Enabled = false;
            msgAttacks.Hide();
            msgInfosBattle.Refresh();
        }

        public void ShowAttacks()
        {
            msgAttacks.Enabled = true;
            msgAttacks.Show();
            msgAttacks.Refresh();
        }

        public void AddObserver(IObservateur<ModelEvents> Observer)
        {
            BattleObservers.Add(Observer);
        }

        public void RemoveObserver(IObservateur<ModelEvents> Observer)
        {
            BattleObservers.Add(Observer);
        }

        public void Notify()
        {
            foreach (var ob in BattleObservers)
            {
                ob.MettreAJour();
            }
        }

        public void Notify(ModelEvents Action, object sender)
        {
            foreach (var ob in BattleObservers)
            {
                ob.MettreAJour(Action, sender);
            }
        }

    }
}
