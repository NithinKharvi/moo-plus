namespace Yalamo.Extensibility
{
    partial class IPAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPAbout));
            this.Okbt = new System.Windows.Forms.Button();
            this.PluginWebsite = new System.Windows.Forms.LinkLabel();
            this.PluginDescription = new System.Windows.Forms.TextBox();
            this.PluginVersion = new System.Windows.Forms.Label();
            this.PluginAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Okbt
            // 
            this.Okbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Okbt.Location = new System.Drawing.Point(300, 164);
            this.Okbt.Name = "Okbt";
            this.Okbt.Size = new System.Drawing.Size(60, 23);
            this.Okbt.TabIndex = 2;
            this.Okbt.Text = "OK";
            this.Okbt.UseVisualStyleBackColor = true;
            // 
            // PluginWebsite
            // 
            this.PluginWebsite.AutoSize = true;
            this.PluginWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PluginWebsite.Location = new System.Drawing.Point(9, 60);
            this.PluginWebsite.Name = "PluginWebsite";
            this.PluginWebsite.Size = new System.Drawing.Size(114, 15);
            this.PluginWebsite.TabIndex = 3;
            this.PluginWebsite.TabStop = true;
            this.PluginWebsite.Text = "http://evansofts.com";
            this.PluginWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PluginDescription
            // 
            this.PluginDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PluginDescription.Location = new System.Drawing.Point(12, 96);
            this.PluginDescription.Multiline = true;
            this.PluginDescription.Name = "PluginDescription";
            this.PluginDescription.ReadOnly = true;
            this.PluginDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PluginDescription.Size = new System.Drawing.Size(282, 91);
            this.PluginDescription.TabIndex = 4;
            this.PluginDescription.Text = "sample description";
            // 
            // PluginVersion
            // 
            this.PluginVersion.AutoSize = true;
            this.PluginVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PluginVersion.Location = new System.Drawing.Point(12, 9);
            this.PluginVersion.Name = "PluginVersion";
            this.PluginVersion.Size = new System.Drawing.Size(74, 15);
            this.PluginVersion.TabIndex = 5;
            this.PluginVersion.Text = "Version : 1.9";
            this.PluginVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PluginAuthor
            // 
            this.PluginAuthor.AutoSize = true;
            this.PluginAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PluginAuthor.Location = new System.Drawing.Point(12, 33);
            this.PluginAuthor.Name = "PluginAuthor";
            this.PluginAuthor.Size = new System.Drawing.Size(152, 15);
            this.PluginAuthor.TabIndex = 6;
            this.PluginAuthor.Text = "Author : Evance Soumaoro";
            this.PluginAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IPAbout
            // 
            this.AcceptButton = this.Okbt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 195);
            this.Controls.Add(this.PluginAuthor);
            this.Controls.Add(this.Okbt);
            this.Controls.Add(this.PluginVersion);
            this.Controls.Add(this.PluginDescription);
            this.Controls.Add(this.PluginWebsite);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IPAbout";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPAbout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Okbt;
        private System.Windows.Forms.LinkLabel PluginWebsite;
        private System.Windows.Forms.TextBox PluginDescription;
        private System.Windows.Forms.Label PluginVersion;
        private System.Windows.Forms.Label PluginAuthor;
    }
}