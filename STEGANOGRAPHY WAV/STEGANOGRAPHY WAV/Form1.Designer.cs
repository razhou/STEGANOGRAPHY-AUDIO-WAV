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
            this.label1 = new System.Windows.Forms.Label();
            this.browsefield = new System.Windows.Forms.TextBox();
            this.browsebutton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPesan = new System.Windows.Forms.TextBox();
            this.rdoPesan = new System.Windows.Forms.RadioButton();
            this.btnSmbnyiFile = new System.Windows.Forms.Button();
            this.txtSmbnyiFile = new System.Windows.Forms.TextBox();
            this.rdoSmbnyiFile = new System.Windows.Forms.RadioButton();
            this.btnHslSmbny = new System.Windows.Forms.Button();
            this.txtHslSmbny = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File WAV";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // browsefield
            // 
            this.browsefield.Location = new System.Drawing.Point(69, 26);
            this.browsefield.Name = "browsefield";
            this.browsefield.Size = new System.Drawing.Size(220, 20);
            this.browsefield.TabIndex = 1;
            this.browsefield.TextChanged += new System.EventHandler(this.browsefield_TextChanged);
            // 
            // browsebutton
            // 
            this.browsebutton.Location = new System.Drawing.Point(295, 24);
            this.browsebutton.Name = "browsebutton";
            this.browsebutton.Size = new System.Drawing.Size(75, 23);
            this.browsebutton.TabIndex = 2;
            this.browsebutton.Text = "Browse";
            this.browsebutton.UseVisualStyleBackColor = true;
            this.browsebutton.Click += new System.EventHandler(this.browsebutton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(31, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(444, 549);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtPesan);
            this.tabPage1.Controls.Add(this.rdoPesan);
            this.tabPage1.Controls.Add(this.btnSmbnyiFile);
            this.tabPage1.Controls.Add(this.txtSmbnyiFile);
            this.tabPage1.Controls.Add(this.rdoSmbnyiFile);
            this.tabPage1.Controls.Add(this.btnHslSmbny);
            this.tabPage1.Controls.Add(this.txtHslSmbny);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.browsefield);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.browsebutton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(436, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sembunyikan Pesan";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sembunyikan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(436, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tampilkan Pesan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kunci";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPesan
            // 
            this.txtPesan.Location = new System.Drawing.Point(110, 294);
            this.txtPesan.Multiline = true;
            this.txtPesan.Name = "txtPesan";
            this.txtPesan.Size = new System.Drawing.Size(265, 133);
            this.txtPesan.TabIndex = 15;
            // 
            // rdoPesan
            // 
            this.rdoPesan.AutoSize = true;
            this.rdoPesan.Checked = true;
            this.rdoPesan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoPesan.Location = new System.Drawing.Point(13, 283);
            this.rdoPesan.Name = "rdoPesan";
            this.rdoPesan.Size = new System.Drawing.Size(55, 17);
            this.rdoPesan.TabIndex = 14;
            this.rdoPesan.TabStop = true;
            this.rdoPesan.Text = "Pesan";
            this.rdoPesan.UseVisualStyleBackColor = true;
            // 
            // btnSmbnyiFile
            // 
            this.btnSmbnyiFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSmbnyiFile.Location = new System.Drawing.Point(348, 229);
            this.btnSmbnyiFile.Name = "btnSmbnyiFile";
            this.btnSmbnyiFile.Size = new System.Drawing.Size(75, 23);
            this.btnSmbnyiFile.TabIndex = 13;
            this.btnSmbnyiFile.Text = "Browse";
            this.btnSmbnyiFile.UseVisualStyleBackColor = true;
            // 
            // txtSmbnyiFile
            // 
            this.txtSmbnyiFile.Location = new System.Drawing.Point(135, 229);
            this.txtSmbnyiFile.Name = "txtSmbnyiFile";
            this.txtSmbnyiFile.Size = new System.Drawing.Size(195, 20);
            this.txtSmbnyiFile.TabIndex = 12;
            // 
            // rdoSmbnyiFile
            // 
            this.rdoSmbnyiFile.AutoSize = true;
            this.rdoSmbnyiFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoSmbnyiFile.Location = new System.Drawing.Point(12, 229);
            this.rdoSmbnyiFile.Name = "rdoSmbnyiFile";
            this.rdoSmbnyiFile.Size = new System.Drawing.Size(108, 17);
            this.rdoSmbnyiFile.TabIndex = 11;
            this.rdoSmbnyiFile.Text = "Sembunyikan File";
            this.rdoSmbnyiFile.UseVisualStyleBackColor = true;
            // 
            // btnHslSmbny
            // 
            this.btnHslSmbny.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHslSmbny.Location = new System.Drawing.Point(346, 177);
            this.btnHslSmbny.Name = "btnHslSmbny";
            this.btnHslSmbny.Size = new System.Drawing.Size(75, 23);
            this.btnHslSmbny.TabIndex = 10;
            this.btnHslSmbny.Text = "Borwse";
            this.btnHslSmbny.UseVisualStyleBackColor = true;
            // 
            // txtHslSmbny
            // 
            this.txtHslSmbny.Location = new System.Drawing.Point(129, 178);
            this.txtHslSmbny.Name = "txtHslSmbny";
            this.txtHslSmbny.Size = new System.Drawing.Size(201, 20);
            this.txtHslSmbny.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(15, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Simpan Hasil ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 573);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Steganography WAV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox browsefield;
        private System.Windows.Forms.Button browsebutton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPesan;
        private System.Windows.Forms.RadioButton rdoPesan;
        private System.Windows.Forms.Button btnSmbnyiFile;
        private System.Windows.Forms.TextBox txtSmbnyiFile;
        private System.Windows.Forms.RadioButton rdoSmbnyiFile;
        private System.Windows.Forms.Button btnHslSmbny;
        private System.Windows.Forms.TextBox txtHslSmbny;
        private System.Windows.Forms.Label label3;
    }
}

