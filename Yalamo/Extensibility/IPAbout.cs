using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Yalamo.Gui;

namespace Yalamo.Extensibility
{
    internal partial class IPAbout :Form
    {
        public IPAbout()
        {
            InitializeComponent();
            this.Okbt.Click += new EventHandler(Okbt_Click);
            this.PluginWebsite.Click += new EventHandler(PluginWebsite_Click);
        }

        void Okbt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void PluginWebsite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(PluginWebsite.Text);
        }
        
        public static void ShowAboutPlugin(string name, string author, string description, string website, string version) 
        {
            IPAbout winabout = new IPAbout();
            winabout.Text = "About: " + name;
            winabout.PluginVersion.Text = "Version:" + version;
            winabout.PluginAuthor.Text ="Author:"+ author;
            winabout.PluginWebsite.Text = website;
            winabout.PluginDescription.Text = description;
            winabout.ShowDialog();
        }

        

  

    }
}
