using System.Drawing;
using System.Windows.Forms;
using TP2.Modele;
using TP2.Commun;
using System;

namespace TP2.Vue
{
    public partial class SpriteCharacterPlayer : SpriteCharacter
    {
        
        public SpriteCharacterPlayer()
        {
            InitializeComponent();
        }

        public SpriteCharacterPlayer(CharacterPlayer Player) : base(Player)
        {
            ImagesMarche = new IterateurMarcheJoueur();
            Sprite = ImagesMarche.StoppedImage(Direction.Down);
        }
        
    }
}
