using System.Drawing;

namespace TP2.Vue
{
    public class IterateurMarcheJoueur : IterateurMarche
    {
        
        public IterateurMarcheJoueur()
        {
            EnumDown = new Bitmap[] { Properties.Resources.bas2, Properties.Resources.bas3 }.GetEnumerator();
            EnumLeft = new Bitmap[] { Properties.Resources.gauche2, Properties.Resources.gauche1 }.GetEnumerator();
            EnumUp = new Bitmap[] { Properties.Resources.haut2, Properties.Resources.haut3 }.GetEnumerator();
            EnumRight = new Bitmap[] { Properties.Resources.droite2, Properties.Resources.droite1 }.GetEnumerator();

            StoppedDown = Properties.Resources.bas1;
            StoppedRight = Properties.Resources.droite1;
            StoppedLeft = Properties.Resources.gauche1;
            StoppedUp = Properties.Resources.haut1;
    }

        
    }
}
