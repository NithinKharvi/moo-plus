using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Moo.Controls.Test
{
    public partial class Form1 : Yalamo.Gui.YPage
    {
        public Form1()
        {
            InitializeComponent();
           
        }

       

        

        private void brunchBrowser1_ItemSelected(string itemTag)
        {
            MessageBox.Show(itemTag);
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolStripManager.Renderer = new Yalamo.Gui.Office2007Renderer();
            projectBrowser1.BuildNodes(@"c:\\fakep\",
                "sample.mpr", 
                "sample");
            
            brunchBrowser1.Refresh();

            fileBrowser1.BuildNodes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            projectBrowser1.Refresh();
            fileBrowser1.Refresh();
        }

        private void projectBrowser1_ItemSelected(string itemTag)
        {
            MessageBox.Show(itemTag);
        }

        private void fileBrowser1_ItemSelected(string itemTag)
        {
            MessageBox.Show(itemTag);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileFounder1.SearchTerm =searchterm.Text;
            fileFounder1.SearchFile();
        }

        private void fileFounder1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(brunchBrowser1.BrunchFile);
            brunchBrowser1.Refresh();
           object o=(object) brunchBrowser1.BrunchDataStructure;
            DataSet S = brunchBrowser1.BrunchDataStructure;
        }

        
        
    }
}
