namespace Moo.Controls.Test
{
    partial class Form2
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.PbxBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbxLeft
            // 
            this.PbxLeft.Location = new System.Drawing.Point(0, 50);
            this.PbxLeft.Size = new System.Drawing.Size(50, 0);
            // 
            // PbxTop
            // 
            this.PbxTop.Size = new System.Drawing.Size(284, 0);
            // 
            // PbxRight
            // 
            this.PbxRight.Location = new System.Drawing.Point(279, 0);
            this.PbxRight.Size = new System.Drawing.Size(5, 0);
            // 
            // PbxBottom
            // 
            this.PbxBottom.Controls.Add(this.progressBar1);
            this.PbxBottom.Controls.Add(this.button1);
            this.PbxBottom.Location = new System.Drawing.Point(0, 212);
            this.PbxBottom.Size = new System.Drawing.Size(284, 50);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 15);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 10);
            this.progressBar1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Border.Bottom = 50;
            this.Border.Left = 0;
            this.Border.Right = 0;
            this.Border.Top = 0;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "Form2";
            this.Text = "Form2";
            this.PbxBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;

    }
}