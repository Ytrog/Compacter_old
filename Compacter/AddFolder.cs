using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compacter
{
    public partial class AddFolder : Form
    {
        public AddFolder()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                txtSelectedFolder.Text = folderBrowserDialog1.SelectedPath;
            }

        }

        private void radioCompress_CheckedChanged(object sender, EventArgs e)
        {
            handleRadioEvent();
        }

        private void handleRadioEvent()
        {
            if (radioCompress.Checked || radioUncompress.Checked)
            {
                listBoxMethods.Enabled = true;
            }
            else
            {
                listBoxMethods.Enabled = false;
            }
        }

        private void radioUncompress_CheckedChanged(object sender, EventArgs e)
        {
            handleRadioEvent();
        }

        private void radioList_CheckedChanged(object sender, EventArgs e)
        {
            handleRadioEvent();
        }

        private void txtSelectedFolder_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = !string.IsNullOrWhiteSpace(txtSelectedFolder.Text);
        }
    }
}
