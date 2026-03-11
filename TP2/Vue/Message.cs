using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using TP2.Commun;
using System.Runtime.Remoting.Contexts;

namespace TP2.Vue
{
    
    public partial class Message : Panel
    {
        public Message()
        {
            InitializeComponent();
        }

        private void Message_Paint(object sender, PaintEventArgs e)
        {
            PaintBox(sender, e);
        }

        private void PaintBox(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            g.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle innerRectangle1 = new Rectangle(7,7,Size.Width-15,Size.Height-15);
            Rectangle innerRectangle2 = new Rectangle(10,10,Size.Width-21,Size.Height-21);
            GraphicsPath path1 = RoundedRectangle.Create(innerRectangle1, 20);
            GraphicsPath path2 = RoundedRectangle.Create(innerRectangle2, 20);
            g.DrawPath(Pens.Black, path1);
            g.DrawPath(Pens.Black, path2);
        }
    }
}
