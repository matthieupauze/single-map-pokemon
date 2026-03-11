using System;
using System.Drawing;
using TP2.Commun;
using TP2.Vue;

namespace TP2.Modele
{
    public class Tuile
    {
        private char CharBG;
        public SpriteCharacter Occupier { get; private set; } //IDrawable
        public Bitmap BackGround
        {
            get
            {
                return TileFetcher.BitmapFromChar((TileFetcher.CharBitmap)CharBG);
            }
        }

        public bool WillCollide
        {
            get
            {
                return TileFetcher.WillCollide((TileFetcher.CharBitmap)CharBG) || Occupier != null;
            }
        }

        public Tuile(char pic)
        {
            Occupier = null;
            CharBG = pic;
        }

        public void SetPerson(SpriteCharacter newOccupant)
        {
            Occupier = newOccupant;
        }

        public void Draw(Graphics g, int x, int y)
        {
            g.DrawImage(BackGround, x, y);
            if (Occupier != null)
            {
                g.DrawImage(Occupier.Sprite, x ,y);
            }
        }

        public bool IsGrass()
        {
            if ((TileFetcher.CharBitmap) CharBG == TileFetcher.CharBitmap.TALL_GRASS_1)
            {
                return true;
            }
            return false;
        }

        public bool IsPokemart()
        {
            if ((TileFetcher.CharBitmap)CharBG == TileFetcher.CharBitmap.PORTE_MART)
            {
                return true;
            }
            return false;
        }

        public bool IsPokeCenter()
        {
            if ((TileFetcher.CharBitmap)CharBG == TileFetcher.CharBitmap.PORTE_CENTER)
            {
                return true;
            }
            return false;
        }

        public bool IsMagical()
        {
            if ((TileFetcher.CharBitmap) CharBG == TileFetcher.CharBitmap.M_D_DOOR)
            {
                return true;
            }
            return false;
        }
    }
}
