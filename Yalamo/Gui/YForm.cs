using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yalamo.Gui
{
    

    public class YForm : Form
    {
        #region Windows Api
        
        public struct StructBorder
        {
            public int Left;
            public int Right;
            public int Top;
            public int Bottom;
        };

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public extern static int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref StructBorder strtborder);

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public extern static int DwmIsCompositionEnabled(ref int en);

        #endregion

        public static Color TransparencyColor=Color.FromArgb(255, 221, 220, 220);

        private Border border;
        private Point lastClick;

        protected Panel PbxLeft;
        protected Panel PbxTop;
        protected Panel PbxRight;
        protected Panel PbxBottom;


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Border Border
        {
            get { return this.border; }
            set
            {
                if (value != null)
                {
                    this.border = value;  
                }
            }
        }

        public YForm()
        {
            this.TransparencyKey = YForm.TransparencyColor; 
            this.Border = new Border();
            this.Border.BorderChanged += new BorderChangedHandler(SetupBorders);
            
            this.PbxLeft = new Panel();
            this.PbxLeft.BackColor = YForm.TransparencyColor;
            this.PbxLeft.Dock = DockStyle.Left;
            this.PbxLeft.Location = new Point(0, 0);
            this.PbxLeft.Height = this.Height;
            this.PbxLeft.MouseDown += new MouseEventHandler(YForm_MouseDown);
            this.PbxLeft.MouseMove += new MouseEventHandler(YForm_MouseMove);
            this.Controls.Add(PbxLeft);

            this.PbxTop = new Panel();
            this.PbxTop.BackColor = YForm.TransparencyColor;
            this.PbxTop.Dock = DockStyle.Top;
            this.PbxTop.Location = new Point(0, 0);
            this.PbxTop.Width = this.Width;
            this.PbxTop.MouseDown += new MouseEventHandler(YForm_MouseDown);
            this.PbxTop.MouseMove += new MouseEventHandler(YForm_MouseMove);
            this.Controls.Add(PbxTop);

            this.PbxRight = new Panel();
            this.PbxRight.BackColor = YForm.TransparencyColor;
            this.PbxRight.Dock = DockStyle.Right;
            this.PbxRight.Location = new Point(this.Width - this.border.Right - 16, 0);
            this.PbxRight.Height = this.Height;
            this.PbxRight.MouseDown += new MouseEventHandler(YForm_MouseDown);
            this.PbxRight.MouseMove += new MouseEventHandler(YForm_MouseMove);
            this.Controls.Add(PbxRight);

            this.PbxBottom = new Panel();
            this.PbxBottom.BackColor = YForm.TransparencyColor;
            this.PbxBottom.Dock = DockStyle.Bottom;
            this.PbxBottom.Location = new Point(0, this.Height - this.border.Bottom - 36);
            this.PbxBottom.Width = this.Width;
            this.PbxBottom.MouseDown += new MouseEventHandler(YForm_MouseDown);
            this.PbxBottom.MouseMove += new MouseEventHandler(YForm_MouseMove);
            this.Controls.Add(PbxBottom);

            this.Load += new EventHandler(YForm_Init);
        }

        private void SetupBorders()
        {
            if (System.Environment.OSVersion.Version.Major >= 6)  //make sure you are not on a legacy OS 
            {
                int IsXFrameEble = 0;
                StructBorder strtborder = new StructBorder();

                //check if the desktop composition is enabled
                DwmIsCompositionEnabled(ref IsXFrameEble);
                if (IsXFrameEble > 0)
                {
                    //left conner
                    if (this.border.Left > 0)
                    {
                        this.PbxLeft.Visible = true;
                        this.PbxLeft.Width = this.border.Left;
                        strtborder.Left = this.border.Left;
                    }
                    else {
                        this.PbxLeft.Visible = false;
                        this.PbxLeft.Height = 0;
                        strtborder.Left = 0;
                    }
                    //top corner
                    if (this.border.Top > 0)
                    {
                        this.PbxTop.Visible = true;
                        this.PbxTop.Height = this.border.Top;
                        strtborder.Top = this.border.Top;
                    }
                    else
                    {
                        this.PbxTop.Visible = false;
                        this.PbxTop.Height = 0;
                        strtborder.Top = 0;
                    }
                    
                    //right corner
                    if (this.border.Right > 0)
                    {
                        this.PbxRight.Visible = true;
                        this.PbxRight.Width = this.border.Right;
                        strtborder.Right = this.border.Right;
                    }
                    else
                    {
                        this.PbxRight.Visible = false;
                        this.PbxRight.Height = 0;
                        strtborder.Right = 0;
                    }
                    //bottom corner
                    if (this.border.Bottom > 0)
                    {
                        this.PbxBottom.Visible = true;
                        this.PbxBottom.Height = this.border.Bottom;       
                        strtborder.Bottom = this.border.Bottom;
                    }
                    else
                    {
                        this.PbxBottom.Visible = false;
                        this.PbxBottom.Height = 0;
                        strtborder.Bottom = 0;
                    }
                    
                    DwmExtendFrameIntoClientArea(this.Handle, ref strtborder);
                }
            }
        }

        //form initialisation
        void YForm_Init(object sender, EventArgs e)
        {
            this.SetupBorders();

        }
        //form draging implementation
        private void YForm_MouseDown(object sender, MouseEventArgs e)
        {
            //need to keep the value to use when the user starts moving
            this.lastClick = new Point(e.X, e.Y);
        }
        private void YForm_MouseMove(object sender, MouseEventArgs e)
        {
            //check is mouse button is held
            if (e.Button == MouseButtons.Left)
            {
                //Move the Form with the same difference the mouse cursor moved;
                this.Left += e.X - this.lastClick.X;
                this.Top += e.Y - this.lastClick.Y;
            }
        }

    }
}
