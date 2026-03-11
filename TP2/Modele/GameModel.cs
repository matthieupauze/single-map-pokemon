using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using TP2.Commun;
using TP2.Vue;

namespace TP2.Modele
{
    public class GameModel : Commun.IObservable<ModelEvents>
    {

        Pokedex ThePokedex;
        List<IObservateur<ModelEvents>> Observers;
        List<Character> Characters;
        Tuile[,] Map;
        Random Rng;
        public PokemonMusic MusicToMyEars { get; private set; }
        public PokemonPair Battlers { get; private set; }

        public GameModel()
        {
            Observers = new List<IObservateur<ModelEvents>>();
            CreateTuiles();
            LoadAllPokemon();
            LoadCharacters();
            MusicToMyEars = new PokemonMusic();
            Rng = new Random();
        }

        private void LoadCharacters()
        {
            Characters = new List<Character>();
            Characters.Add(new CharacterPlayer(this));
            for(int i = 1; i < 3; i++)
            {
                Characters.Add(new CharacterAI(this));
                Characters[i].SetPosition(new Point(i+47,49));
            }

            Pokemon newMember = new Pokemon(ThePokedex.GetPokemon(25), 8);
            ThePokedex.CatchPokemon(25);
            List<Attack> atks = AttacksDB.ALL_ATTACKS;
            newMember.Moves = new Attack[]{atks[0], atks[8], atks[97], atks[84]};
            GetPlayer().AddToParty(newMember);

        }

        private void LoadAllPokemon()
        {
            ThePokedex = new Pokedex(FileUtils.LoadAllPokemon());
        }

        private void CreateTuiles()
        {
            Map = FileUtils.LoadMap();
        }

        public CharacterPlayer GetPlayer()
        {
            return (CharacterPlayer)Characters[0];
        }

        public CharacterAI GetNpc(int id)
        {
            return (CharacterAI)Characters[id];
        }

        public Tuile[,] GetTiles()
        {
            return Map;
        }

        public Tuile GetTileAt(Point pt)
        {
            return Map[pt.X, pt.Y];
        }

        public Pokedex GetPokedex()
        {
            return ThePokedex;
        }

        public void StartBattle()
        {
            int pokedexNumber = Rng.Next(1, 252);
            Pokemon enemy = new Pokemon(ThePokedex.GetPokemon(pokedexNumber), 3);
            Battlers = new PokemonPair(GetPlayer().GetPokemon(1), enemy);
            Notify(ModelEvents.BattleStart, this);
        }

        public void AddObserver(IObservateur<ModelEvents> Observer)
        {
            Observers.Add(Observer);
        }

        public void RemoveObserver(IObservateur<ModelEvents> Observer)
        {
            Observers.Remove(Observer);
        }

        public void Notify()
        {
            foreach(IObservateur<ModelEvents> ob in Observers)
            {
                ob.MettreAJour();
            }
        }

        public void Notify(ModelEvents Action, object sender)
        {
            foreach (IObservateur<ModelEvents> ob in Observers)
            {
                ob.MettreAJour(Action, sender);
            }
        }

    }
}
