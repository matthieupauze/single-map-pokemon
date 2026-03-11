using System;
using System.Collections.Generic;

namespace TP2.Modele
{
    public class Pokedex
    {

        List<BasePokemon> AllPokemon;

        public Pokedex(List<BasePokemon> pokemon)
        {
            AllPokemon = pokemon;
        }

        public BasePokemon GetPokemon(int pokedexNumber)
        {
            return AllPokemon[pokedexNumber-1];
        }

        public List<BasePokemon>.Enumerator GetEnumerator()
        {
            return AllPokemon.GetEnumerator();
        }

        public string GetPokemonName(int pokedexNumber)
        {
            return GetPokemon(pokedexNumber).Name;
        }

        public void CatchPokemon(int pokedexNumber)
        {
            AllPokemon[pokedexNumber - 1].hasBeenCaptured = true;
        }
    }
}
