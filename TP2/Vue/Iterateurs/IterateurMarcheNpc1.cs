using System.Drawing;

namespace TP2.Vue
{
    public class IterateurMarcheNpc1 : IterateurMarche
    {

        public IterateurMarcheNpc1()
        {
            StoppedDown = Properties.Resources.perso1_bas;
            StoppedRight = Properties.Resources.perso1_droit;
            StoppedLeft = Properties.Resources.perso1_gauche;
            StoppedUp = Properties.Resources.perso1_haut;

            EnumDown = new Bitmap[] { StoppedDown }.GetEnumerator();
            EnumLeft = new Bitmap[] { StoppedLeft }.GetEnumerator();
            EnumUp = new Bitmap[] { StoppedUp }.GetEnumerator();
            EnumRight = new Bitmap[] { StoppedRight }.GetEnumerator();
        }
    }
}
