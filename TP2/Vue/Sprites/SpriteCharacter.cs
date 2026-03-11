using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2.Commun;
using TP2.Modele;

namespace TP2.Vue
{
    public partial class SpriteCharacter : UserControl, IObservateur<Direction>
    {
        protected Character Character;
        protected IterateurMarche ImagesMarche;
        protected Direction Regard;
        public Bitmap Sprite { get; set; }

        public SpriteCharacter()
        {
            InitializeComponent();
        }

        public SpriteCharacter(Character person) : this()
        {
            Character = person;
            person.AddObserver(this);
        }

        public void MettreAJour()
        {
            Sprite = ImagesMarche.StoppedImage(Regard);
        }

        public void MettreAJour(Direction Action, object sender)
        {
            Sprite = ImagesMarche.ProchaineImage(Action);
            Regard = Action;
        }

        private void SpriteCharacter_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Sprite, 0, 0);
        }

        public Point GetLocation()
        {
            return Character.GetPosition();
        }

        public Character GetCharacter()
        {
            return Character;
        }

    }
}
