namespace STEGANOGRAPHY_WAV
{
    partial class Form1
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
            this.lblFileWav = new System.Windows.Forms.Label();
            this.txtFileWav = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFileWav
            // 
            this.lblFileWav.AutoSize = true;
            this.lblFileWav.Location = new System.Drawing.Point(13, 13);
            this.lblFileWav.Name = "lblFileWav";
            this.lblFileWav.Size = new System.Drawing.Size(46, 13);
            this.lblFileWav.TabIndex = 0;
            this.lblFileWav.Text = "FileWav";
            this.lblFileWav.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFileWav
            // 
            this.txtFileWav.Location = new System.Drawing.Point(154, 43);
            this.txtFileWav.Name = "txtFileWav";
            this.txtFileWav.Size = new System.Drawing.Size(100, 20);
            this.txtFileWav.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtFileWav);
            this.Controls.Add(this.lblFileWav);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileWav;
        private System.Windows.Forms.TextBox txtFileWav;
    }
}

