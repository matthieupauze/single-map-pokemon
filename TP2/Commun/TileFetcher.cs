using System.Collections.Generic;
using System.Drawing;

namespace TP2.Commun
{
    public static class TileFetcher
    {
        private static readonly int WIDTH = 32, HEIGHT = 32;
        private static Bitmap FICHIER_TUILES = Properties.Resources.Tileset;

        private static Bitmap TREE_BOTTOM = LoadTile(new Position(0, 6));
        private static Bitmap TREE_TOP = LoadTile(new Position(0, 5));
        private static Bitmap TREE_1 = LoadTile(new Position(3, 3));
        private static Bitmap TREE_2 = LoadTile(new Position(3, 4));
        private static Bitmap PATH = LoadTile(new Position(0, 0));
        private static Bitmap WATER = LoadTile(new Position(0, 9));
        private static Bitmap FLOWER_1 = LoadTile(new Position(0, 3));
        private static Bitmap FLOWER_2 = LoadTile(new Position(0, 4));
        private static Bitmap GRASS = LoadTile(new Position(0, 1));
        private static Bitmap TALL_GRASS_1 = LoadTile(new Position(0, 2));
        private static Bitmap LINE_GRASS = LoadTile(new Position(10, 0));
        private static Bitmap TALL_GRASS_2 = LoadTile(new Position(11, 0));
        private static Bitmap BUSH = LoadTile(new Position(12, 0));
        private static Bitmap HOUSE_LEFT = LoadTile(new Position(4, 3));
        private static Bitmap HOUSE_CENTER = LoadTile(new Position(5, 3));
        private static Bitmap HOUSE_RIGHT = LoadTile(new Position(7, 3));
        private static Bitmap SIGN_MART = LoadTile(new Position(5, 1));
        private static Bitmap SIGN_SMALL = LoadTile(new Position(9, 1));
        private static Bitmap SIGN_POKE = LoadTile(new Position(1, 4));
        private static Bitmap PORTE = LoadTile(new Position(6, 3));
        private static Bitmap ROOF_LEFT = LoadTile(new Position(5, 0));
        private static Bitmap ROOF_CENTER = LoadTile(new Position(6, 0));
        private static Bitmap ROOF_RIGHT = LoadTile(new Position(7, 0));
        private static Bitmap WIRLPOOL = LoadTile(new Position(0, 8));
        private static Bitmap TR_WATER = LoadTile(new Position(7, 9));
        private static Bitmap R_WATER = LoadTile(new Position(7, 10));
        private static Bitmap BR_WATER = LoadTile(new Position(7, 11));
        private static Bitmap T_WATER = LoadTile(new Position(6, 9));
        private static Bitmap TL_WATER = LoadTile(new Position(5, 9));
        private static Bitmap L_WATER = LoadTile(new Position(5, 10));
        private static Bitmap TL_ROOF = LoadTile(new Position(4, 4));
        private static Bitmap T_ROOF = LoadTile(new Position(5, 4));
        private static Bitmap TR_ROOF = LoadTile(new Position(6, 4));
        private static Bitmap ML_ROOF = LoadTile(new Position(4, 5));
        private static Bitmap M_ROOF = LoadTile(new Position(5, 5));
        private static Bitmap MR_ROOF = LoadTile(new Position(6, 5));
        private static Bitmap BL_ROOF = LoadTile(new Position(4, 6));
        private static Bitmap B_ROOF = LoadTile(new Position(5, 6));
        private static Bitmap BR_ROOF = LoadTile(new Position(6, 6));
        private static Bitmap L_D_DOOR = LoadTile(new Position(4, 7));
        private static Bitmap M_D_DOOR = LoadTile(new Position(5, 7));
        private static Bitmap R_D_DOOR = LoadTile(new Position(6, 7));
        private static Bitmap OUT_OF_BOUNDS = TREE_1;

        public static Bitmap BitmapFromChar(CharBitmap c)
        {
            switch (c)
            {
                case CharBitmap.TREE_BOTTOM:
                    return TREE_BOTTOM;
                case CharBitmap.TREE_TOP:
                    return TREE_TOP;
                case CharBitmap.TREE_1:
                    return TREE_1;
                case CharBitmap.TREE_2:
                    return TREE_2;
                case CharBitmap.PATH:
                    return PATH;
                case CharBitmap.WATER:
                    return WATER;
                case CharBitmap.FLOWER_1:
                    return FLOWER_1;
                case CharBitmap.FLOWER_2:
                    return FLOWER_2;
                case CharBitmap.GRASS:
                    return GRASS;
                case CharBitmap.TALL_GRASS_1:
                    return TALL_GRASS_1;
                case CharBitmap.LINE_GRASS:
                    return LINE_GRASS;
                case CharBitmap.TALL_GRASS_2:
                    return TALL_GRASS_2;
                case CharBitmap.BUSH:
                    return BUSH;
                case CharBitmap.HOUSE_LEFT:
                    return HOUSE_LEFT;
                case CharBitmap.HOUSE_CENTER:
                    return HOUSE_CENTER;
                case CharBitmap.HOUSE_RIGHT:
                    return HOUSE_RIGHT;
                case CharBitmap.SIGN_MART:
                    return SIGN_MART;
                case CharBitmap.SIGN_SMALL:
                    return SIGN_SMALL;
                case CharBitmap.SIGN_POKE:
                    return SIGN_POKE;
                case CharBitmap.PORTE_CENTER:
                case CharBitmap.PORTE_MART:
                case CharBitmap.PORTE_INUTILE:
                    return PORTE;
                case CharBitmap.ROOF_LEFT:
                    return ROOF_LEFT;
                case CharBitmap.ROOF_CENTER:
                    return ROOF_CENTER;
                case CharBitmap.ROOF_RIGHT:
                    return ROOF_RIGHT;
                case CharBitmap.TR_WATER:
                    return TR_WATER;
                case CharBitmap.R_WATER:
                    return R_WATER;
                case CharBitmap.T_WATER:
                    return T_WATER;
                case CharBitmap.TL_WATER:
                    return TL_WATER;
                case CharBitmap.L_WATER:
                    return L_WATER;
                case CharBitmap.BR_WATER:
                    return BR_WATER;
                case CharBitmap.WIRLPOOL:
                    return WIRLPOOL;
                case CharBitmap.TL_ROOF:
                    return TL_ROOF;
                case CharBitmap.T_ROOF:
                    return T_ROOF;
                case CharBitmap.TR_ROOF:
                    return TR_ROOF;
                case CharBitmap.ML_ROOF:
                    return ML_ROOF;
                case CharBitmap.M_ROOF:
                    return M_ROOF;
                case CharBitmap.MR_ROOF:
                    return MR_ROOF;
                case CharBitmap.BL_ROOF:
                    return BL_ROOF;
                case CharBitmap.B_ROOF:
                    return B_ROOF;
                case CharBitmap.BR_ROOF:
                    return BR_ROOF;
                case CharBitmap.L_D_DOOR:
                    return L_D_DOOR;
                case CharBitmap.M_D_DOOR:
                    return M_D_DOOR;
                case CharBitmap.R_D_DOOR:
                    return R_D_DOOR;
                default:
                    return OUT_OF_BOUNDS;
            }
        }

        public static bool WillCollide(CharBitmap c)
        {
            switch (c)
            {
                case CharBitmap.PATH:
                case CharBitmap.FLOWER_1:
                case CharBitmap.FLOWER_2:
                case CharBitmap.GRASS:
                case CharBitmap.TALL_GRASS_1:
                case CharBitmap.LINE_GRASS:
                case CharBitmap.TALL_GRASS_2:
                case CharBitmap.PORTE_MART:
                case CharBitmap.PORTE_CENTER:
                case CharBitmap.PORTE_INUTILE:
                case CharBitmap.M_D_DOOR:
                    return false;
                default:
                    return true;
            }

        }

        public enum CharBitmap
        {
            OUT_OF_BOUNDS = 'a',
            TREE_BOTTOM = 'b',
            TREE_TOP = 'c',
            TREE_1 = 'd',
            TREE_2 = 'e',
            PATH = 'f',
            WATER = 'g',
            FLOWER_1 = 'h',
            FLOWER_2 = 'i',
            GRASS = 'j',
            TALL_GRASS_1 = 'k',
            LINE_GRASS = 'l',
            TALL_GRASS_2 = 'm',
            BUSH = 'n',
            HOUSE_LEFT = 'o',
            HOUSE_CENTER = 'p',
            HOUSE_RIGHT = 'q',
            SIGN_MART = 'r',
            SIGN_SMALL = 's',
            SIGN_POKE = 't',
            PORTE_CENTER = 'u',
            PORTE_MART = 'U',
            ROOF_LEFT = 'v',
            ROOF_CENTER = 'w',
            ROOF_RIGHT = 'x',
            WIRLPOOL = 'y',
            TR_WATER = 'z',
            R_WATER = 'A',
            T_WATER = 'B',
            TL_WATER = 'C',
            L_WATER = 'D',
            BR_WATER = 'E',
            PORTE_INUTILE = 'F',
            TL_ROOF = 'G',
            T_ROOF = 'H',
            TR_ROOF = 'I',
            ML_ROOF = 'J',
            M_ROOF = 'K',
            MR_ROOF = 'L',
            BL_ROOF = 'M',
            B_ROOF = 'N',
            BR_ROOF = 'O',
            L_D_DOOR = 'P',
            M_D_DOOR = 'Q',
            R_D_DOOR = 'R'
        }

        private static Bitmap LoadTile(Position tilesetPosition)
        {
            Rectangle crop = new Rectangle(tilesetPosition.X * (WIDTH + 2)+2, tilesetPosition.Y * (HEIGHT + 2)+2, WIDTH, HEIGHT);

            var bmp = new Bitmap(crop.Width, crop.Height);
            using (var gr = Graphics.FromImage(bmp))
            {
                gr.DrawImage(FICHIER_TUILES, new Rectangle(0, 0, bmp.Width, bmp.Height), crop, GraphicsUnit.Pixel);
            }
            return bmp;
        }

        private class Position
        {
            public int X;
            public int Y;
            public Position(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

    }
}
