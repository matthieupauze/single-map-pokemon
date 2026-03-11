using TP2.Modele;

namespace TP2.Vue
{
    public partial class SpriteCharacterNpc1 : SpriteCharacter
    {
        public SpriteCharacterNpc1()
        {
            InitializeComponent();
        }

        public SpriteCharacterNpc1(Character person) : base(person)
        {
            ImagesMarche = new IterateurMarcheNpc1();
            Sprite = ImagesMarche.StoppedImage(Direction.Down);
        }

    }
}
