using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TP2.Commun;
using TP2.Modele;

namespace TP2.Vue
{
    public partial class FrmPrincipale : Form, IObservateur<ModelEvents>
    {

        GameModel ThisGame;
        VisualPokedex PokedexVisible;
        Battle CurrentBattle;
        DimmingForm Dimmer;
        PokemonMusic MusicToMyEars;
        bool gameOver = false;

        public FrmPrincipale()
        {
            InitializeComponent();
            ThisGame = mapJeu.GetGame();
            PokedexVisible = new VisualPokedex(ThisGame.GetPokedex());
            CurrentBattle = new Battle();
            MusicToMyEars = ThisGame.MusicToMyEars;
            MusicToMyEars.StartDefaultMusic();
            CreateDefaults();
            SetupDimmer();
        }

        private void SetupDimmer()
        {
            Dimmer = new DimmingForm();
            Dimmer.Show(this);
            Dimmer.Opacity = 0;
            Dimmer.Location = GetInnerInnerLocation();
        }

        private void CreateDefaults()
        {
            CurrentBattle.Location = new Point(0, 24);
            PokedexVisible.Location = new Point(0, 24);
            Controls.Add(CurrentBattle);
            Controls.Add(PokedexVisible);
            CurrentBattle.Hide();
            PokedexVisible.Hide();
            CurrentBattle.Enabled = false;
            PokedexVisible.Enabled = false;
            ThisGame.AddObserver(this);
            CurrentBattle.AddObserver(this);
            PokedexVisible.AddObserver(this);
        }

        public void MettreAJour()
        {
        }

        public void MettreAJour(ModelEvents Action, object sender)
        {
            switch (Action)
            {
                case ModelEvents.BattleStart:
                    StartBattle();
                    break;
                case ModelEvents.BattleCaptured:
                    CapturePokemon();
                    StopBattle();
                    CheckGameOver();
                    break;
                case ModelEvents.BattleEnd:
                    StopBattle();
                    break;
                case ModelEvents.ShowPokedex:
                    ShowPokedex();
                    break;
                case ModelEvents.HidePokedex:
                    HidePokedex();
                    break;
                case ModelEvents.PokeCenter:
                    mapJeu.AfficherPokemonGuerri();
                    break;
            }

        }

        private void CapturePokemon()
        {
            List<Pokemon> party = ThisGame.GetPlayer().GetParty();
            Pokemon newPokemon = CurrentBattle.GetEnemyPokemon();
            party.Add(newPokemon);
            int nbPokemons = party.Count;
            CurrentBattle.WriteMessage("Vous avez capturés " + (party.Count-1) + " Pokémons");
        }

        private void HidePokedex()
        {
            Dim();
            PokedexVisible.Hide();
            PokedexVisible.Enabled = false;
            mapJeu.Enabled = true;
            mapJeu.Show();
            mapJeu.Focus();
            MusicToMyEars.StartDefaultMusic();
            Brighten();
        }

        private void ShowPokedex()
        {
            Dim();
            mapJeu.StopWalking();
            mapJeu.Enabled = false;
            mapJeu.Hide();
            PokedexVisible.Enabled = true;
            PokedexVisible.Show();
            PokedexVisible.Focus();
            MusicToMyEars.StartShopMusic();
            Brighten();
        }

        private void StopBattle()
        {
            Dim();
            CurrentBattle.Hide();
            CurrentBattle.Enabled = false;
            mapJeu.Enabled = true;
            mapJeu.Show();
            mapJeu.Focus();
            MusicToMyEars.StartDefaultMusic();
            Brighten();
        }

        private void CheckGameOver()
        {
            List<Pokemon> party = ThisGame.GetPlayer().GetParty();
            int nbPokemons = party.Count;
            if (nbPokemons == 6 && !gameOver)
            {
                DialogResult continuer = MessageBox.Show(this,
                    "Vous les avez toutes capturés (5 d'entre eux)\n"+
                    "Voulez-vous continuer de jouer?",
                    "Félicitations",
                    MessageBoxButtons.YesNo);
                gameOver = true;
                if (continuer == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void StartBattle()
        {
            mapJeu.StopWalking();
            mapJeu.Enabled = false;
            MusicToMyEars.StartBattleMusic();
            PlayBattleAnimation();
            Dimmer.Opacity = 1;
            mapJeu.Hide();
            CurrentBattle.SetPokemon(ThisGame.Battlers);
            CurrentBattle.Enabled = true;
            Brighten();
            CurrentBattle.Show();
        }

        private void PlayBattleAnimation()
        {
            using (Graphics g = mapJeu.CreateGraphics())
            using (Brush red = new SolidBrush(Color.FromArgb(64, 255, 0, 0)))
            using (Brush yellow = new SolidBrush(Color.FromArgb(64, 255, 255, 0)))
            using (Brush blue = new SolidBrush(Color.FromArgb(64, 0, 0, 255)))
            {
                for (int i = 0; i < 5; i++)
                {
                    g.FillRectangle(red, g.ClipBounds);
                    Waiting.WaitMilliseconds(100);
                    g.FillRectangle(yellow, g.ClipBounds);
                    Waiting.WaitMilliseconds(100);
                    g.FillRectangle(blue, g.ClipBounds);
                    Waiting.WaitMilliseconds(100);
                }
            }

        }

        private void FrmPrincipale_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.D1:
                    MusicToMyEars.StartDefaultMusic();
                    break;
                case Keys.D2:
                    MusicToMyEars.StartBattleMusic();
                    break;
                case Keys.D3:
                    MusicToMyEars.StartShopMusic();
                    break;
                case Keys.D4:
                    MusicToMyEars.StopMusic();
                    break;
                case Keys.Oemplus | Keys.Shift:
                case Keys.Add:
                    MusicToMyEars.VolumeUp();
                    break;
                case Keys.OemMinus:
                case Keys.Subtract:
                    MusicToMyEars.VolumeDown();
                    break;
            }
        }

        private void Brighten()
        {
            while (Dimmer.Opacity > 0.1)
            {
                Dimmer.Opacity -= 0.1;
                Dimmer.Refresh();
                Waiting.WaitMilliseconds(30);
            }
            Dimmer.Opacity = 0;
        }

        private void Dim()
        {
            while (Dimmer.Opacity < 0.9)
            {
                Dimmer.Opacity += 0.1;
                Waiting.WaitMilliseconds(30);
            }
            Dimmer.Opacity = 1;
        }

        private void FrmPrincipale_Move(object sender, EventArgs e)
        {
            Dimmer.Location = GetInnerInnerLocation();
        }

        private Point GetInnerInnerLocation()
        {
            Point newLocation = Location;
            newLocation.Y += 30;
            newLocation.X += 8;
            return newLocation;
        }

        private void recommencerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                this,
                "Pékéman, un jeu fait par Matthieu Pauzé\n"+
                "Musique choisi par Andrew Parker\n"+
                "Capturer les toutes!",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                this,
                "Utiliser les flèches clavier pour se déplacer.\n"+
                "Le pokécentre va guérrir tous tes pokémons.\n" +
                "Le pokémart ouvre le pokédex pour afficher tout les pokémons,\n"+
                "ceux qui sont grisés ne sont pas attrapés.\n" +
                "Utiliser les touches 1-4 pour modifier la musique et +- pour le volume\n"+
                "Visiter le temple pour entendre la musique secrète...",
                "Aide");
        }
    }
}