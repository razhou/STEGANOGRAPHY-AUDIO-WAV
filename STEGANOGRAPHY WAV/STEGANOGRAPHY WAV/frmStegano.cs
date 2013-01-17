using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STEGANOGRAPHY_WAV
{
    public partial class frmStegano : Form
    {
        public frmStegano()
        {
            InitializeComponent();
        }



        private void AmbilFile(FileDialog dialog, TextBox control, bool useFilter)
        {
            if (useFilter) { dialog.Filter = "Wave Audio (*.wav)|*.wav"; }
            if (dialog.ShowDialog(this) == DialogResult.OK)

                control.Text = dialog.FileName;

        }



        

        private void btnFileWav_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            AmbilFile(dlg, txtFileWav, true);
        }

        private void btnKunci_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            AmbilFile(dlg, txtKunci, false);
        }

        private void btnHslSmbny_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            AmbilFile(dlg, txtHslSmbny, true);

        }

        private void btnSmbnyiFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            AmbilFile(dlg, txtSmbnyiFile, false);
            rdoSmbnyiFile.Checked = true;
        }

        private void btnEnkrip_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            AmbilFile(dlg, txtEnkrip, true);
        }

        private void btnKunci1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            AmbilFile(dlg, txtKunci1, false);
        }

        private void btnHslTmpl_Click_1(object sender, EventArgs e)
        {
             SaveFileDialog dlg = new SaveFileDialog();
            AmbilFile(dlg, txtHslTmpl, false);
            rdoHslTmpl.Checked = true;

        }


    }
}
