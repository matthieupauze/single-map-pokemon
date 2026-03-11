using System;
using System.Collections.Generic;
using System.Threading;
using TP2.Commun;

namespace TP2.Modele
{
    public class CharacterAI : Character
    {

        private static Random Rng = new Random();
        private int Interval = 2500;

        public CharacterAI(GameModel TheGame) : base(TheGame)
        {
            Speed = MoveSpeed.Slow;
            Thread t = new Thread(new ThreadStart(MoveRandomly));
            t.IsBackground = true;
            t.Start();
        }

        private void MoveRandomly()
        {
            while(true)
            {
                Thread.Sleep(Interval);
                Direction dir = (Direction)Rng.Next(4);
                Move(dir);
            }
        }

        
    }
}
