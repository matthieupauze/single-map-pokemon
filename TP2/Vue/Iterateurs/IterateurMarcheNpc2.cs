using System.Drawing;

namespace TP2.Vue
{
    public class IterateurMarcheNpc2 : IterateurMarche
    {

        public IterateurMarcheNpc2()
        {
            StoppedDown = Properties.Resources.perso2_bas;
            StoppedRight = Properties.Resources.perso2_droit;
            StoppedLeft = Properties.Resources.perso2_gauche;
            StoppedUp = Properties.Resources.perso2_haut;

            EnumDown = new Bitmap[] { StoppedDown }.GetEnumerator();
            EnumLeft = new Bitmap[] { StoppedLeft }.GetEnumerator();
            EnumUp = new Bitmap[] { StoppedUp }.GetEnumerator();
            EnumRight = new Bitmap[] { StoppedRight }.GetEnumerator();
        }


    }
}
