using System;
using System.Collections;
using System.Collections.Generic;
using TP2.Modele;

namespace TP2.Commun
{
    public static class FileUtils
    {

        private static string Pokemon_File = Properties.Resources.All_Pokemon;
        private static string Flavour_File = Properties.Resources.Pokemon_Flavor_Text;
        private static string Pokemon_Species = Properties.Resources.Pokemon_Species;
        private static string Pokemon_Height_Weight = Properties.Resources.height_weight;
        private static string Pokemon_Map = Properties.Resources.map;
        private static Random Rng = new Random();

        public static Tuile[,] LoadMap()
        {
            Tuile[,] Tuiles = new Tuile[100, 100];
            int x = 0;
            int y = 0;
            foreach (string line in Pokemon_Map.Split(new string[] { "\r\n" }, StringSplitOptions.None))
            {
                foreach (char c in line)
                {
                    Tuiles[x, y] = new Tuile(c);
                    x++;
                }
                x = 0;
                y++;
            }
            return Tuiles;
        }

        public static List<BasePokemon> LoadAllPokemon()
        {
            List<BasePokemon> AllPokemon = new List<BasePokemon>();

            CreateBasicPokemon(AllPokemon);
            
            AddDescriptions(AllPokemon);

            AddHeightWeight(AllPokemon);

            return AllPokemon;
        }

        private static void AddHeightWeight(List<BasePokemon> allPokemon)
        {
            IEnumerator pokemonEnum = allPokemon.GetEnumerator();

            foreach (string line in Pokemon_Height_Weight.Split(new string[] { "\n" }, StringSplitOptions.None))
            {
                string[] height_weight = line.Split(',');
                pokemonEnum.MoveNext();
                BasePokemon pokemon = (BasePokemon) pokemonEnum.Current;
                pokemon.Height = Double.Parse(height_weight[1]) / 10 + "m";
                pokemon.Weight = Double.Parse(height_weight[2]) / 10 + "kg";
            }
        }

        private static IEnumerator GetSpeciesEnumerator()
        {
            List<string> listOfSpecies = new List<string>();
            foreach(string line in Pokemon_Species.Split(new string[] { "\n" }, StringSplitOptions.None))
            {
                string[] idGenus = line.Split(',');
                listOfSpecies.Add(idGenus[1]);
            }
            return listOfSpecies.GetEnumerator();
        }

        private static void CreateBasicPokemon(List<BasePokemon> AllPokemon)
        {
            IEnumerator PokemonSpecies = GetSpeciesEnumerator();

            foreach (string line in Pokemon_File.Split(new string[] { "\r\n" }, StringSplitOptions.None))
            {
                string[] pokemonArgs = line.Split(',');

                BasePokemon newPokemon = GiveDefaultValues(pokemonArgs);

                PokemonSpecies.MoveNext();
                newPokemon.PokemonFamily = "The " + PokemonSpecies.Current + " Pokemon";

                AllPokemon.Add(newPokemon);
            }
        }

        private static BasePokemon GiveDefaultValues(string[] pokemonArgs)
        {
            
            BasePokemon newPokemon = new BasePokemon();

            newPokemon.PokedexNumber = Int32.Parse(pokemonArgs[0]);
            newPokemon.Name = pokemonArgs[1];
            newPokemon.BaseHp = Int32.Parse(pokemonArgs[2]);
            newPokemon.BaseAttack = Int32.Parse(pokemonArgs[3]);
            newPokemon.BaseDefense = Int32.Parse(pokemonArgs[4]);
            newPokemon.BaseSpecialAttack = Int32.Parse(pokemonArgs[5]);
            newPokemon.BaseSpecialDefense = Int32.Parse(pokemonArgs[6]);
            newPokemon.BaseSpeed = Int32.Parse(pokemonArgs[7]);
            newPokemon.BaseXpYield = Int32.Parse(pokemonArgs[8]);
            newPokemon.CatchRate = Int32.Parse(pokemonArgs[9]);
            newPokemon.Height = Rng.Next(12) + " m";
            newPokemon.Weight = Math.Round(Rng.NextDouble() * 100, 1) + " kg";
            newPokemon.Picture = PokemonPictures.GetFrontPicture(newPokemon.PokedexNumber);
            newPokemon.hasBeenCaptured = false;

            return newPokemon;
        }

        private static void AddDescriptions(List<BasePokemon> AllPokemon)
        {
            using (IEnumerator<BasePokemon> PokemonEnum = AllPokemon.GetEnumerator())
            {
                foreach (string line in Flavour_File.Split(new string[] { "\n" }, StringSplitOptions.None))
                {
                    PokemonEnum.MoveNext();
                    PokemonEnum.Current.Description = line;
                }
            }
        }

    }
}
