using System;
using System.Collections;
using System.Drawing;
using TP2.Modele;

namespace TP2.Vue
{
    public abstract class IterateurMarche
    {

        protected Bitmap StoppedDown;
        protected Bitmap StoppedRight;
        protected Bitmap StoppedLeft;
        protected Bitmap StoppedUp;

        protected IEnumerator EnumDown;
        protected IEnumerator EnumRight;
        protected IEnumerator EnumLeft;
        protected IEnumerator EnumUp;

        private Direction LastDirection = Direction.Down;
        private IEnumerator CurrentEnumerator;

        public Bitmap ProchaineImage(Direction direction)
        {
            CurrentEnumerator = GetSet(direction);

            if (direction == LastDirection)
            {
                return GetImage();
            }
            else
            {

                LastDirection = direction;

                return GetImage();
            }
        }

        public Bitmap StoppedImage(Direction regard)
        {
            EnumLeft.Reset();
            EnumRight.Reset();
            switch (regard)
            {
                case Direction.Down:
                    return StoppedDown;
                case Direction.Up:
                    return StoppedUp;
                case Direction.Left:
                    return StoppedLeft;
                case Direction.Right:
                    return StoppedRight;
            }
            throw new ArgumentOutOfRangeException("Obtained a Direction not in enum");
        }

        private Bitmap GetImage()
        {
            if (!CurrentEnumerator.MoveNext())
            {
                CurrentEnumerator.Reset();
                CurrentEnumerator.MoveNext();
            }
            return (Bitmap)CurrentEnumerator.Current;
        }

        private IEnumerator GetSet(Direction direction)
        {
            switch (direction)
            {
                case Direction.Down:
                    return EnumDown;
                case Direction.Up:
                    return EnumUp;
                case Direction.Left:
                    return EnumLeft;
                case Direction.Right:
                    return EnumRight;
            }
            throw new ArgumentOutOfRangeException("Direction not in enum");
        }
    }
}
