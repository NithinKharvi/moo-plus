using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yalamo.Gui
{
    public class YPage : Form
    {
        public YPage() 
        {
            this.BackColor = Color.White;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.Resize += new EventHandler(YPage_Resize);
        }

        void YPage_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;


            g.FillRectangle(Brushes.White, this.ClientRectangle);

            int h = 70;
            Rectangle rec = new Rectangle(new Point(0, this.Height - h-16), new Size(this.Width, h));
            g.FillRectangle(new SolidBrush(Color.FromArgb(100, 224, 224, 224)), rec);

            g.DrawLine(new Pen(Color.FromArgb(100, 255, 255, 255),1.8f), new Point(0, this.Height - h - 16), new Point(this.Width, this.Height - h - 16));
           
            g.DrawLine(new Pen(Color.FromArgb(100, 192, 192, 192), 1), new Point(0, this.Height - h -17), new Point(this.Width, this.Height - h -17));

            
        }

    }
}
