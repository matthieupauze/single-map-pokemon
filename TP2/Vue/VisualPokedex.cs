using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TP2.Commun;
using TP2.Modele;

namespace TP2.Vue
{
    public partial class VisualPokedex : UserControl, Commun.IObservable<ModelEvents>
    {

        List<IObservateur<ModelEvents>> Observateurs;
        Pokedex CurrentPokedex;

        public VisualPokedex()
        {
            InitializeComponent();
            Observateurs = new List<IObservateur<ModelEvents>>();
        }

        public VisualPokedex(Pokedex newPokedex) : this()
        {
            SetPokedex(newPokedex);
            listPokemon.Font = CustomFont.Standard;
            btnFermer.Font = CustomFont.Standard;
        }

        private void PopulateList()
        {
            foreach (BasePokemon pok in CurrentPokedex)
            {
                listPokemon.Items.Add(pok);
            }
        }

        public void SetPokedex(Pokedex newPokedex)
        {
            CurrentPokedex = newPokedex;
            PopulateList();
            listPokemon.SelectedIndex = 0;
        }

        private void listPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pokedexNumber = ((BasePokemon)listPokemon.SelectedItem).PokedexNumber;
            affichagePokemon1.SetPokemon(CurrentPokedex.GetPokemon(pokedexNumber));
        }

        private void listPokemon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left)
            {
                e.Handled = true;
                ScrollUp();
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                e.Handled = true;
                ScrollDown();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnFermer_Click(this, new EventArgs());
            }
        }

        private void ScrollDown()
        {
            if (listPokemon.SelectedIndex == listPokemon.Items.Count - 1)
            {
                listPokemon.SelectedIndex = 0;
            }
            else
            {
                listPokemon.SelectedIndex++;
            }
        }

        private void ScrollUp()
        {
            if (listPokemon.SelectedIndex == 0)
            {
                listPokemon.SelectedIndex = listPokemon.Items.Count - 1;
            }
            else
            {
                listPokemon.SelectedIndex--;
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Notify(ModelEvents.HidePokedex,this);
        }

        private void listPokemon_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush myBrush = Brushes.Black;

            e.DrawBackground();

            e.Graphics.DrawString(listPokemon.Items[e.Index].ToString(), 
                e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);

            e.DrawFocusRectangle();
        }

        public new void Show()
        {
            base.Show();
            listPokemon.SelectedIndex = 0;
        }
        
        public void CatchPokemon(int pokedexNumber)
        {
            CurrentPokedex.CatchPokemon(pokedexNumber);
        }

        public void AddObserver(IObservateur<ModelEvents> Observer)
        {
            Observateurs.Add(Observer);
        }

        public void RemoveObserver(IObservateur<ModelEvents> Observer)
        {
            Observateurs.Remove(Observer);
        }

        public void Notify()
        {
            foreach(var ob in Observateurs)
            {
                ob.MettreAJour();
            }
        }

        public void Notify(ModelEvents Action, object sender)
        {
            foreach (var ob in Observateurs)
            {
                ob.MettreAJour(Action,sender);
            }
        }
    }
}
