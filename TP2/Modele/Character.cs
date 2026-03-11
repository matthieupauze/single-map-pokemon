using System;
using System.Collections.Generic;
using System.Drawing;
using TP2.Commun;

namespace TP2.Modele
{
    public abstract class Character : Commun.IObservable<Direction>
    {
        private static int IdCounter = 0;

        protected Point Location;
        protected MoveSpeed Speed;
        protected List<Pokemon> Party;
        protected GameModel TheGame;
        private int Id;
        private List<IObservateur<Direction>> Observateurs;

        public Character(GameModel ThisGame)
        {
            Observateurs = new List<IObservateur<Direction>>();
            Party = new List<Pokemon>();
            TheGame = ThisGame;
            Id = IdCounter;
            IdCounter++;
            Speed = MoveSpeed.Normal;
            Location = new Point(0, 0);
        }

        public Point GetPosition()
        {
            return Location;
        }
        public void SetPosition(Point location)
        {
            Location = location;
        }
        public MoveSpeed GetMoveSpeed()
        {
            return Speed;
        }
        public void SetMoveSpeed(MoveSpeed speed)
        {
            Speed = speed;
        }

        public void Move(Direction direction)
        {
            bool notified = false;
            if (LocationIsValid(GetPosition(), direction))
            {

                Tuile t = TheGame.GetTileAt(Location);
                t.SetPerson(null);

                switch (direction)
                {
                    case Direction.Down:
                        Location.Y += 1;
                        break;
                    case Direction.Left:
                        Location.X -= 1;
                        break;
                    case Direction.Right:
                        Location.X += 1;
                        break;
                    case Direction.Up:
                        Location.Y -= 1;
                        break;
                }
                Tuile newTuile = TheGame.GetTileAt(Location);

                Notify(direction, this);
                notified = true;

                if (newTuile.IsGrass())
                {
                    WalkOnGrass();
                }
                else if (newTuile.IsPokeCenter())
                {
                    ActivateHeal();
                }
                else if (newTuile.IsPokemart())
                {
                    ShowPokedex();
                }
                else if (newTuile.IsMagical())
                {
                    TheGame.MusicToMyEars.StartBestMusic();
                }
            }
            if (!notified)
            {
                Notify(direction, this);
            }
        }

        private bool LocationIsValid(Point point, Direction direction)
        {
            switch (direction)
            {
                case Direction.Down:
                    point.Y += 1;
                    break;
                case Direction.Left:
                    point.X -= 1;
                    break;
                case Direction.Right:
                    point.X += 1;
                    break;
                case Direction.Up:
                    point.Y -= 1;
                    break;
            }
            if (!InBounds(point) || !TileIsValid(point))
            {
                return false;
            }
            return true;
        }

        private bool TileIsValid(Point point)
        {
            return !TheGame.GetTileAt(point).WillCollide;
        }

        private bool InBounds(Point point)
        {
            if (point.Y > 99 || point.Y < 0 || point.X > 99 || point.X < 0)
            {
                return false;
            }
            return true;
        }

        protected virtual void WalkOnGrass() { }
        protected virtual void ShowPokedex() { }
        protected virtual void ActivateHeal() { }

        public List<Pokemon> GetParty()
        {
            return Party;
        }

        public void AddToParty(Pokemon partyMember)
        {
            if (Party.Count < 6)
            {
                Party.Add(partyMember);
            }
            else
            {
                throw new Exception("Party is already full");
            }
        }

        public Pokemon GetPokemon(int index)
        {
            if (index - 1 < Party.Count)
            {
                return Party[index - 1];
            }
            throw new Exception("Tried accessing pokemon number " + index +
                " in a party of " + Party.Count + " pokemon");
        }

        public void AddObserver(IObservateur<Direction> Observer)
        {
            Observateurs.Add(Observer);
        }

        public void RemoveObserver(IObservateur<Direction> Observer)
        {
            Observateurs.Remove(Observer);
        }

        public void Notify()
        {
            foreach (IObservateur<Direction> ob in Observateurs)
            {
                ob.MettreAJour();
            }
        }

        public void Notify(Direction Action, object sender)
        {
            foreach (IObservateur<Direction> ob in Observateurs)
            {
                ob.MettreAJour(Action, sender);
            }
        }

    }
}
