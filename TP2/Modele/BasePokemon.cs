using System.Drawing;

namespace TP2.Modele
{
    public class BasePokemon
    {

        public string Name { get; set; }
        public string PokemonFamily { get; set; }
        public string Description { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public Bitmap Picture { get; set; }
        public bool hasBeenCaptured { get; set; }
        public int PokedexNumber { get; set; }
        public int BaseHp { get; set; }
        public int BaseAttack { get; set; }
        public int BaseDefense { get; set; }
        public int BaseSpecialAttack { get; set; }
        public int BaseSpecialDefense { get; set; }
        public int BaseSpeed { get; set; }
        public int BaseXpYield { get; set; }
        public int CatchRate { get; set; }

        public BasePokemon() { }

        public BasePokemon(BasePokemon basicPokemon)
        {
            Name = basicPokemon.Name;
            PokemonFamily = basicPokemon.PokemonFamily;
            Description = basicPokemon.Description;
            Height = basicPokemon.Height;
            Weight = basicPokemon.Weight;
            Picture = basicPokemon.Picture;
            hasBeenCaptured = basicPokemon.hasBeenCaptured;
            PokedexNumber = basicPokemon.PokedexNumber;
            BaseHp = basicPokemon.BaseHp;
            BaseAttack = basicPokemon.BaseAttack;
            BaseDefense = basicPokemon.BaseDefense;
            BaseSpecialAttack = basicPokemon.BaseSpecialAttack;
            BaseSpecialDefense = basicPokemon.BaseSpecialDefense;
            BaseSpeed = basicPokemon.BaseSpeed;
            BaseXpYield = basicPokemon.BaseXpYield;
            CatchRate = basicPokemon.CatchRate;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
