using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TP2.Commun;
using TP2.Modele;

namespace TP2.Vue
{
    public partial class PkmFriendly : UserControl, IObservateur<Pokemon>
    {
        private Point defaultLocation;
        private Pokemon ThisPokemon;

        public PkmFriendly()
        {
            InitializeComponent();
            SetFont();
            defaultLocation = picPokemon.Location;
        }

        private void SetFont()
        {
            foreach (Control control in Controls)
            {
                control.Font = CustomFont.Standard;
            }
        }

        public void SetPokemon(Pokemon ally)
        {
            if (ThisPokemon != null)
            {
                ThisPokemon.RemoveObserver(this);
            }
            this.ThisPokemon = ally;
            ThisPokemon.AddObserver(this);
            SetDefaults();
            MettreAJour();
        }
        private void SetDefaults()
        {
            lblName.Text = ThisPokemon.Name;
            lblHp.Text = ThisPokemon.CurrentHp + "/" + ThisPokemon.MaxHp;
            barHp.Maximum = ThisPokemon.MaxHp;
            barHp.Value = ThisPokemon.CurrentHp;
            lblLevel.Text = "Level: " + ThisPokemon.Level;
            lblGender.Text = ThisPokemon.IsMale ? "M" : "F";
            Bitmap frontPicture = PokemonPictures.GetBackPicture(ThisPokemon.PokedexNumber);
            picPokemon.Image = PokemonPictures.ResizeImage(frontPicture, picPokemon.Size);
            Invalidate();
        }

        public void MettreAJour()
        {
            while (barHp.Value > ThisPokemon.CurrentHp)
            {
                barHp.Value--;
                lblHp.Text = barHp.Value + "/" + ThisPokemon.MaxHp;
                Waiting.WaitMilliseconds(50);
                Refresh();
            }
        }

        public void MettreAJour(Pokemon Action, object sender)
        {
            SetPokemon(Action);
        }

        public void Kill()
        {
            while (picPokemon.Location.Y < Bottom)
            {
                //Slides the pokemon off screen
                picPokemon.Location = new Point(picPokemon.Location.X, picPokemon.Location.Y + 3);
                Waiting.WaitMilliseconds(2);
                Refresh();
            }
            picPokemon.Image = FillWhite(picPokemon.Image.Size);
            picPokemon.Location = defaultLocation;
            Refresh();
        }

        private Bitmap FillWhite(Size s)
        {
            int width = s.Width;
            int height = s.Height;

            Bitmap bmp = new Bitmap(width, height);
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle ImageSize = new Rectangle(0, 0, width, height);
                graph.FillRectangle(Brushes.White, ImageSize);
            }
            return bmp;
        }

    }
}
