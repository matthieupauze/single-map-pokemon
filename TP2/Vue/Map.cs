using System;
using System.Drawing;
using System.Windows.Forms;
using TP2.Modele;
using TP2.Commun;
using System.Collections.Generic;

namespace TP2.Vue
{
    public partial class Map : UserControl, IObservateur<Direction>
    {

        CharacterPlayer UserPlayer;
        List<SpriteCharacter> DrawableCharacters;
        Direction HeldDown;
        Keys PreviousKey;
        GameModel Model;
        Tuile[,] Tuiles;
        bool writing;

        public Map()
        {
            InitializeComponent();
            Model = new GameModel();

            UserPlayer = Model.GetPlayer();
            DrawableCharacters = new List<SpriteCharacter>();

            DrawableCharacters.Add(new SpriteCharacterPlayer(UserPlayer));
            DrawableCharacters.Add(new SpriteCharacterNpc1(Model.GetNpc(1)));
            DrawableCharacters.Add(new SpriteCharacterNpc2(Model.GetNpc(2)));
            foreach (SpriteCharacter sp in DrawableCharacters)
            {
                sp.GetCharacter().AddObserver(this);
            }
            lblMessage.Font = CustomFont.Standard;
            tmrWalk.Interval = (int)UserPlayer.GetMoveSpeed();
            Tuiles = Model.GetTiles();
            MettreAJour();
        }

        private void Map_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point CurrentLocation = UserPlayer.GetPosition();
            int HALF_WIDTH = 10;
            int x = 0;
            int y = 0;

            for (int i = CurrentLocation.X - HALF_WIDTH; i <= CurrentLocation.X + HALF_WIDTH; i++)
            {
                for (int j = CurrentLocation.Y - HALF_WIDTH; j <= CurrentLocation.Y + HALF_WIDTH; j++)
                {
                    if (i >= 0 && i < 100 && j >= 0 && j < 100)
                    {
                        Tuiles[i, j].Draw(g, x, y);
                    }
                    else
                    {
                        g.DrawImage(TileFetcher.BitmapFromChar(TileFetcher.CharBitmap.OUT_OF_BOUNDS), x, y);
                    }
                    y += 32;
                }
                y = 0;
                x += 32;
            }
        }

        private void KeyDown_Moving(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.IsArrowKey())
            {
                HeldDown = e.KeyCode.GetDirection();
                tmrWalk.Start();
                PreviousKey = e.KeyCode;
            }
        }

        private void Allowing_Arrow_Keys(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode.IsArrowKey())
            {
                e.IsInputKey = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UserPlayer.Move(HeldDown);
            Invalidate();
        }

        private void Map_KeyUp(object sender, KeyEventArgs e)
        {
            if (PreviousKey == e.KeyCode)
            {
                tmrWalk.Stop();
                UserPlayer.Notify();
                Refresh();
            }
        }

        public void StopWalking()
        {
            Map_KeyUp(this, new KeyEventArgs(PreviousKey));
        }

        public GameModel GetGame()
        {
            return Model;
        }

        public void MettreAJour()
        {
            foreach (SpriteCharacter sp in DrawableCharacters)
            {
                Point pt = sp.GetLocation();
                Tuiles[pt.X, pt.Y].SetPerson(sp);
            }
            Invalidate();
        }

        public void MettreAJour(Direction Action, object sender)
        {
            MettreAJour();
        }

        public void AfficherPokemonGuerri()
        {
            if (!writing) {
                writing = true;
                msgGuerrison.Enabled = true;
                msgGuerrison.Show();
                WriteMessage("Tout tes pokémons sont maintenant guerri!");
                msgGuerrison.Hide();
                msgGuerrison.Enabled = false;
                writing = false;
            }
        }

        private void WriteMessage(string message)
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

    }
}
