namespace STEGANOGRAPHY_WAV
{
    partial class frmStegano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStegano));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileWav = new System.Windows.Forms.TextBox();
            this.btnFileWav = new System.Windows.Forms.Button();
            this.tabCtl = new System.Windows.Forms.TabControl();
            this.tabSmbny = new System.Windows.Forms.TabPage();
            this.btnSmbny = new System.Windows.Forms.Button();
            this.txtPesan = new System.Windows.Forms.TextBox();
            this.rdoPesan = new System.Windows.Forms.RadioButton();
            this.btnSmbnyiFile = new System.Windows.Forms.Button();
            this.txtSmbnyiFile = new System.Windows.Forms.TextBox();
            this.rdoSmbnyiFile = new System.Windows.Forms.RadioButton();
            this.btnHslSmbny = new System.Windows.Forms.Button();
            this.txtHslSmbny = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKunci = new System.Windows.Forms.Button();
            this.txtKunci = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabTmplPsn = new System.Windows.Forms.TabPage();
            this.btnTmpl = new System.Windows.Forms.Button();
            this.btnKunci1 = new System.Windows.Forms.Button();
            this.txtKunci1 = new System.Windows.Forms.TextBox();
            this.labelkunci = new System.Windows.Forms.Label();
            this.btnEnkrip = new System.Windows.Forms.Button();
            this.txtEnkrip = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTmplPsn = new System.Windows.Forms.TextBox();
            this.rdoTmplPsn = new System.Windows.Forms.RadioButton();
            this.btnHslTmpl = new System.Windows.Forms.Button();
            this.txtHslTmpl = new System.Windows.Forms.TextBox();
            this.rdoHslTmpl = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabCtl.SuspendLayout();
            this.tabSmbny.SuspendLayout();
            this.tabTmplPsn.SuspendLayout();
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
            // 
            // txtFileWav
            // 
            this.txtFileWav.Location = new System.Drawing.Point(69, 26);
            this.txtFileWav.Name = "txtFileWav";
            this.txtFileWav.Size = new System.Drawing.Size(220, 20);
            this.txtFileWav.TabIndex = 1;
            // 
            // btnFileWav
            // 
            this.btnFileWav.Location = new System.Drawing.Point(295, 24);
            this.btnFileWav.Name = "btnFileWav";
            this.btnFileWav.Size = new System.Drawing.Size(75, 23);
            this.btnFileWav.TabIndex = 2;
            this.btnFileWav.Text = "Browse";
            this.btnFileWav.UseVisualStyleBackColor = true;
            this.btnFileWav.Click += new System.EventHandler(this.btnFileWav_Click);
            // 
            // tabCtl
            // 
            this.tabCtl.Controls.Add(this.tabSmbny);
            this.tabCtl.Controls.Add(this.tabTmplPsn);
            this.tabCtl.Controls.Add(this.tabPage1);
            this.tabCtl.Location = new System.Drawing.Point(31, 12);
            this.tabCtl.Name = "tabCtl";
            this.tabCtl.SelectedIndex = 0;
            this.tabCtl.Size = new System.Drawing.Size(444, 549);
            this.tabCtl.TabIndex = 3;
            // 
            // tabSmbny
            // 
            this.tabSmbny.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabSmbny.Controls.Add(this.btnSmbny);
            this.tabSmbny.Controls.Add(this.txtPesan);
            this.tabSmbny.Controls.Add(this.rdoPesan);
            this.tabSmbny.Controls.Add(this.btnSmbnyiFile);
            this.tabSmbny.Controls.Add(this.txtSmbnyiFile);
            this.tabSmbny.Controls.Add(this.rdoSmbnyiFile);
            this.tabSmbny.Controls.Add(this.btnHslSmbny);
            this.tabSmbny.Controls.Add(this.txtHslSmbny);
            this.tabSmbny.Controls.Add(this.label3);
            this.tabSmbny.Controls.Add(this.btnKunci);
            this.tabSmbny.Controls.Add(this.txtKunci);
            this.tabSmbny.Controls.Add(this.txtFileWav);
            this.tabSmbny.Controls.Add(this.label2);
            this.tabSmbny.Controls.Add(this.label1);
            this.tabSmbny.Controls.Add(this.btnFileWav);
            this.tabSmbny.Location = new System.Drawing.Point(4, 22);
            this.tabSmbny.Name = "tabSmbny";
            this.tabSmbny.Padding = new System.Windows.Forms.Padding(3);
            this.tabSmbny.Size = new System.Drawing.Size(436, 523);
            this.tabSmbny.TabIndex = 0;
            this.tabSmbny.Text = "Sembunyikan Pesan";
            // 
            // btnSmbny
            // 
            this.btnSmbny.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSmbny.Location = new System.Drawing.Point(149, 456);
            this.btnSmbny.Name = "btnSmbny";
            this.btnSmbny.Size = new System.Drawing.Size(95, 23);
            this.btnSmbny.TabIndex = 16;
            this.btnSmbny.Text = "Sembunyikan";
            this.btnSmbny.UseVisualStyleBackColor = true;
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
            this.btnSmbnyiFile.Click += new System.EventHandler(this.btnSmbnyiFile_Click_1);
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
            this.btnHslSmbny.Click += new System.EventHandler(this.btnHslSmbny_Click);
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
            // btnKunci
            // 
            this.btnKunci.Location = new System.Drawing.Point(295, 64);
            this.btnKunci.Name = "btnKunci";
            this.btnKunci.Size = new System.Drawing.Size(75, 23);
            this.btnKunci.TabIndex = 6;
            this.btnKunci.Text = "Browse";
            this.btnKunci.UseVisualStyleBackColor = true;
            this.btnKunci.Click += new System.EventHandler(this.btnKunci_Click);
            // 
            // txtKunci
            // 
            this.txtKunci.Location = new System.Drawing.Point(69, 62);
            this.txtKunci.Name = "txtKunci";
            this.txtKunci.Size = new System.Drawing.Size(220, 20);
            this.txtKunci.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kunci";
            // 
            // tabTmplPsn
            // 
            this.tabTmplPsn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabTmplPsn.Controls.Add(this.btnTmpl);
            this.tabTmplPsn.Controls.Add(this.btnKunci1);
            this.tabTmplPsn.Controls.Add(this.txtKunci1);
            this.tabTmplPsn.Controls.Add(this.labelkunci);
            this.tabTmplPsn.Controls.Add(this.btnEnkrip);
            this.tabTmplPsn.Controls.Add(this.txtEnkrip);
            this.tabTmplPsn.Controls.Add(this.label9);
            this.tabTmplPsn.Controls.Add(this.txtTmplPsn);
            this.tabTmplPsn.Controls.Add(this.rdoTmplPsn);
            this.tabTmplPsn.Controls.Add(this.btnHslTmpl);
            this.tabTmplPsn.Controls.Add(this.txtHslTmpl);
            this.tabTmplPsn.Controls.Add(this.rdoHslTmpl);
            this.tabTmplPsn.Location = new System.Drawing.Point(4, 22);
            this.tabTmplPsn.Name = "tabTmplPsn";
            this.tabTmplPsn.Padding = new System.Windows.Forms.Padding(3);
            this.tabTmplPsn.Size = new System.Drawing.Size(436, 523);
            this.tabTmplPsn.TabIndex = 1;
            this.tabTmplPsn.Text = "Tampilkan Pesan";
            // 
            // btnTmpl
            // 
            this.btnTmpl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTmpl.Location = new System.Drawing.Point(197, 453);
            this.btnTmpl.Name = "btnTmpl";
            this.btnTmpl.Size = new System.Drawing.Size(75, 23);
            this.btnTmpl.TabIndex = 23;
            this.btnTmpl.Text = "Tampilkan";
            this.btnTmpl.UseVisualStyleBackColor = true;
            // 
            // btnKunci1
            // 
            this.btnKunci1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKunci1.Location = new System.Drawing.Point(352, 54);
            this.btnKunci1.Name = "btnKunci1";
            this.btnKunci1.Size = new System.Drawing.Size(75, 23);
            this.btnKunci1.TabIndex = 22;
            this.btnKunci1.Text = "Browse";
            this.btnKunci1.UseVisualStyleBackColor = true;
            this.btnKunci1.Click += new System.EventHandler(this.btnKunci1_Click_1);
            // 
            // txtKunci1
            // 
            this.txtKunci1.Location = new System.Drawing.Point(140, 54);
            this.txtKunci1.Name = "txtKunci1";
            this.txtKunci1.Size = new System.Drawing.Size(204, 20);
            this.txtKunci1.TabIndex = 21;
            // 
            // labelkunci
            // 
            this.labelkunci.AutoSize = true;
            this.labelkunci.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelkunci.Location = new System.Drawing.Point(16, 61);
            this.labelkunci.Name = "labelkunci";
            this.labelkunci.Size = new System.Drawing.Size(34, 13);
            this.labelkunci.TabIndex = 20;
            this.labelkunci.Text = "Kunci";
            // 
            // btnEnkrip
            // 
            this.btnEnkrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEnkrip.Location = new System.Drawing.Point(351, 12);
            this.btnEnkrip.Name = "btnEnkrip";
            this.btnEnkrip.Size = new System.Drawing.Size(75, 23);
            this.btnEnkrip.TabIndex = 19;
            this.btnEnkrip.Text = "Browse";
            this.btnEnkrip.UseVisualStyleBackColor = true;
            this.btnEnkrip.Click += new System.EventHandler(this.btnEnkrip_Click);
            // 
            // txtEnkrip
            // 
            this.txtEnkrip.Location = new System.Drawing.Point(140, 14);
            this.txtEnkrip.Name = "txtEnkrip";
            this.txtEnkrip.Size = new System.Drawing.Size(204, 20);
            this.txtEnkrip.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(13, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "File wav enkrip:";
            // 
            // txtTmplPsn
            // 
            this.txtTmplPsn.Location = new System.Drawing.Point(140, 248);
            this.txtTmplPsn.Multiline = true;
            this.txtTmplPsn.Name = "txtTmplPsn";
            this.txtTmplPsn.Size = new System.Drawing.Size(286, 129);
            this.txtTmplPsn.TabIndex = 16;
            // 
            // rdoTmplPsn
            // 
            this.rdoTmplPsn.AutoSize = true;
            this.rdoTmplPsn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoTmplPsn.Location = new System.Drawing.Point(9, 239);
            this.rdoTmplPsn.Name = "rdoTmplPsn";
            this.rdoTmplPsn.Size = new System.Drawing.Size(107, 17);
            this.rdoTmplPsn.TabIndex = 15;
            this.rdoTmplPsn.Text = "Tampilkan Pesan";
            this.rdoTmplPsn.UseVisualStyleBackColor = true;
            // 
            // btnHslTmpl
            // 
            this.btnHslTmpl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHslTmpl.Location = new System.Drawing.Point(351, 184);
            this.btnHslTmpl.Name = "btnHslTmpl";
            this.btnHslTmpl.Size = new System.Drawing.Size(75, 23);
            this.btnHslTmpl.TabIndex = 14;
            this.btnHslTmpl.Text = "Browse";
            this.btnHslTmpl.UseVisualStyleBackColor = true;
            this.btnHslTmpl.Click += new System.EventHandler(this.btnHslTmpl_Click_1);
            // 
            // txtHslTmpl
            // 
            this.txtHslTmpl.Location = new System.Drawing.Point(142, 187);
            this.txtHslTmpl.Name = "txtHslTmpl";
            this.txtHslTmpl.Size = new System.Drawing.Size(175, 20);
            this.txtHslTmpl.TabIndex = 13;
            // 
            // rdoHslTmpl
            // 
            this.rdoHslTmpl.AutoSize = true;
            this.rdoHslTmpl.Checked = true;
            this.rdoHslTmpl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoHslTmpl.Location = new System.Drawing.Point(11, 188);
            this.rdoHslTmpl.Name = "rdoHslTmpl";
            this.rdoHslTmpl.Size = new System.Drawing.Size(89, 17);
            this.rdoHslTmpl.TabIndex = 12;
            this.rdoHslTmpl.TabStop = true;
            this.rdoHslTmpl.Text = "Simpan Hasil ";
            this.rdoHslTmpl.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(436, 523);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Tentang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(294, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 52);
            this.label7.TabIndex = 9;
            this.label7.Text = "Firdaus Musyafi\r\nRahmat Syahputra Siahaan\r\nCandi Nursadi\r\nRaju Riyanda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(35, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 52);
            this.label6.TabIndex = 8;
            this.label6.Text = "10109366\r\n10109386\r\n10109397\r\n10109399";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(297, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(37, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "NIM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(19, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Steganography Audio File Wav (Penyembunyian Pesan File Wav)";
            // 
            // frmStegano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(506, 573);
            this.Controls.Add(this.tabCtl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStegano";
            this.Text = "Steganography WAV";
            this.tabCtl.ResumeLayout(false);
            this.tabSmbny.ResumeLayout(false);
            this.tabSmbny.PerformLayout();
            this.tabTmplPsn.ResumeLayout(false);
            this.tabTmplPsn.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileWav;
        private System.Windows.Forms.Button btnFileWav;
        private System.Windows.Forms.TabControl tabCtl;
        private System.Windows.Forms.TabPage tabSmbny;
        private System.Windows.Forms.TabPage tabTmplPsn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKunci;
        private System.Windows.Forms.Button btnKunci;
        private System.Windows.Forms.TextBox txtPesan;
        private System.Windows.Forms.RadioButton rdoPesan;
        private System.Windows.Forms.Button btnSmbnyiFile;
        private System.Windows.Forms.TextBox txtSmbnyiFile;
        private System.Windows.Forms.RadioButton rdoSmbnyiFile;
        private System.Windows.Forms.Button btnHslSmbny;
        private System.Windows.Forms.TextBox txtHslSmbny;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSmbny;
        private System.Windows.Forms.Button btnTmpl;
        private System.Windows.Forms.Button btnKunci1;
        private System.Windows.Forms.TextBox txtKunci1;
        private System.Windows.Forms.Label labelkunci;
        private System.Windows.Forms.Button btnEnkrip;
        private System.Windows.Forms.TextBox txtEnkrip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTmplPsn;
        private System.Windows.Forms.RadioButton rdoTmplPsn;
        private System.Windows.Forms.Button btnHslTmpl;
        private System.Windows.Forms.TextBox txtHslTmpl;
        private System.Windows.Forms.RadioButton rdoHslTmpl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}

