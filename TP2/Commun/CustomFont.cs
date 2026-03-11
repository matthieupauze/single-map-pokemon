using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace TP2.Commun
{
    public class CustomFont
    {
        private static PrivateFontCollection TextFont;
        public static Font Standard;
        public static Font Small;
        public static Font Smallest;

        static CustomFont()
        {
            TextFont = new PrivateFontCollection();

            byte[] fontData = Properties.Resources.Pokemon_GB;

            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);

            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

            TextFont.AddMemoryFont(fontPtr, fontData.Length);

            Marshal.FreeCoTaskMem(fontPtr);

            Standard = new Font(CustomFont.TextFont.Families[0], 11);
            Small = new Font(CustomFont.TextFont.Families[0], 9);
            Smallest = new Font(CustomFont.TextFont.Families[0], 8);
        }
    }
}
