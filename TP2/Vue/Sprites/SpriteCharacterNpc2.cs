using TP2.Commun;
using TP2.Modele;

namespace TP2.Vue
{
    public partial class SpriteCharacterNpc2 : SpriteCharacter
    {
        public SpriteCharacterNpc2()
        {
            InitializeComponent();
        }

        public SpriteCharacterNpc2(Character person) : base(person)
        {
            ImagesMarche = new IterateurMarcheNpc2();
            Sprite = ImagesMarche.StoppedImage(Direction.Down);
        }

    }
}
