using System;
using System.Windows.Forms;
using TP2.Modele;

namespace TP2.Commun
{
    public static class KeyExtensions
    {
        /// <summary>
        /// Determine si la clé est une flèche directionel
        /// </summary>
        /// <param name="k">The Key</param>
        /// <returns>If it's an arrow key</returns>
        public static bool IsArrowKey(this Keys k)
        {
            return k == Keys.Left || k == Keys.Right
                || k == Keys.Up || k == Keys.Down;
        }

        /// <summary>
        /// Returns the Arrow Key as a Modele.Direction
        /// </summary>
        /// <param name="k">An arrow key</param>
        /// <returns></returns>
        public static Direction GetDirection(this Keys k)
        {
            switch (k)
            {
                case Keys.Left:
                    return Direction.Left;
                case Keys.Up:
                    return Direction.Up;
                case Keys.Right:
                    return Direction.Right;
                case Keys.Down:
                    return Direction.Down;
            }
            throw new ArgumentNullException("Its not an arrow key");
        }
    }
}
