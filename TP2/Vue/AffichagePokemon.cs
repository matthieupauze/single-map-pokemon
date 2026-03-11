using System;
using System.Windows.Forms;
using TP2.Commun;
using TP2.Modele;

namespace TP2.Vue
{
    public partial class AffichagePokemon : UserControl
    {

        BasePokemon ShownPokemon;

        public AffichagePokemon()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Selectable, false);
            SetUpFont();
        }

        private void SetUpFont()
        {
            foreach (Control control in Controls)
            {
                control.Font = CustomFont.Standard;
            }
            lblName.Font = CustomFont.Small;
            lblFamily.Font = CustomFont.Smallest;
            lblWeight.Font = CustomFont.Small;
        }

        /// <summary>
        /// Shows the pokemon
        /// </summary>
        /// <param name="bPokemon">The BasePokemon you want to show</param>
        public void SetPokemon(BasePokemon bPokemon)
        {
            ShownPokemon = bPokemon;

            picPokemon.Image = PokemonPictures.ResizeImage(bPokemon.Picture, picPokemon.Size);
            picFoot.Image = PokemonPictures.ResizeImage(PokemonPictures.GetFootprint(bPokemon.PokedexNumber), picFoot.Size);
            lblName.Text = bPokemon.Name.ToUpper();
            lblPokedexNo.Text = "No. " + bPokemon.PokedexNumber;
            lblFamily.Text = bPokemon.PokemonFamily.ToUpper();
            lblHeight.Text = "HT " + bPokemon.Height;
            lblWeight.Text = "WT " + bPokemon.Weight;
            lblDescription.Text = bPokemon.Description;

            if (!bPokemon.hasBeenCaptured)
            {
                Enabled = false;
            }
            else
            {
                Enabled = true;
            }

            Invalidate();
        }
    }
}
