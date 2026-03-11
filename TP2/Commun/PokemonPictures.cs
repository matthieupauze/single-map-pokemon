using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace TP2.Commun
{
    public static class PokemonPictures
    {
        public const int FACE_HEIGHT = 56, FACE_WIDTH = 56,
            BACK_HEIGHT = 48, BACK_WIDTH = 48,
            FOOT_HEIGHT = 16, FOOT_WIDTH = 16;

        private static Bitmap POKEMON_FRONT = Properties.Resources.Pokemon;
        private static Bitmap POKEMON_BACK = Properties.Resources.Pokemon_Back;
        private static Bitmap FOOTPRINTS = Properties.Resources.footprints;

        public static Bitmap GetFrontPicture(int pokedexNumber)
        {
            pokedexNumber--; // Needs to be 0 based
            int x = (pokedexNumber % 20) * FACE_WIDTH;
            double y1 = pokedexNumber / 20;
            int y = (int) Math.Floor(y1) * FACE_HEIGHT;

            Point pt = new Point(x,y);
            Size size = new Size(FACE_WIDTH, FACE_HEIGHT);
            Rectangle crop = new Rectangle(pt, size);

            Bitmap bmp = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(POKEMON_FRONT, new Rectangle(0,0,bmp.Width,bmp.Height), crop, GraphicsUnit.Pixel);
            }
            return bmp;
        }

        public static Bitmap GetBackPicture(int pokedexNumber)
        {
            pokedexNumber--; // Needs to be 0 based
            int x = (pokedexNumber % 20) * BACK_WIDTH;
            double y1 = pokedexNumber / 20;
            int y = (int)Math.Floor(y1) * BACK_HEIGHT;

            Point pt = new Point(x, y);
            Size size = new Size(BACK_WIDTH, BACK_HEIGHT);
            Rectangle crop = new Rectangle(pt, size);

            Bitmap bmp = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(POKEMON_BACK, new Rectangle(0, 0, bmp.Width, bmp.Height), crop, GraphicsUnit.Pixel);
            }
            return bmp;
        }

        public static Bitmap GetFootprint(int pokedexNumber)
        {
            int foot_columns = 31;

            pokedexNumber--; // Needs to be 0 based
            int x = (pokedexNumber % foot_columns) * FOOT_WIDTH;
            double y1 = pokedexNumber / foot_columns;
            int y = (int)Math.Floor(y1) * FOOT_HEIGHT;

            Point pt = new Point(x, y);
            Size size = new Size(FOOT_WIDTH, FOOT_HEIGHT);
            Rectangle crop = new Rectangle(pt, size);

            Bitmap bmp = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(FOOTPRINTS, new Rectangle(0, 0, bmp.Width, bmp.Height), crop, GraphicsUnit.Pixel);
            }
            return bmp;

        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            Rectangle destRect = new Rectangle(0, 0, width, height);
            Bitmap destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (ImageAttributes wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public static Bitmap ResizeImage(Image image, Size size)
        {
            return ResizeImage(image, size.Width, size.Height);
        }

    }
}
