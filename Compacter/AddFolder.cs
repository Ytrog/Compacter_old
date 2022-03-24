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

        public string Path {
            get { return txtSelectedFolder.Text; }
            private set { txtSelectedFolder.Text = value; }
        }

        public CompactOptions Result{ get; private set; }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                Path = folderBrowserDialog1.SelectedPath;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var action = GetAction();
            Result = new CompactOptions(action, action == CompactAction.List? CompactMethod.NONE : GetMethod(), Path);
        }

        private CompactAction GetAction()
        {
            if (radioCompress.Checked)
            {
                return CompactAction.Compress;
            }

            if (radioUncompress.Checked)
            {
                return CompactAction.Uncompress;
            }

            return CompactAction.List;
        }

        private CompactMethod GetMethod()
        {
            string item = (string) listBoxMethods.SelectedItem;

            switch (item)
            {
                case "NTFS":
                    return CompactMethod.NTFS;
                case "EXE:XPRESS4K":
                    return CompactMethod.XPRESS4K;
                case "EXE:XPRESS8K":
                    return CompactMethod.XPRESS8K;
                case "EXE:XPRESS16K":
                    return CompactMethod.XPRESS16K;
                case "EXE:LZX":
                    return CompactMethod.LZX;
                default:
                    return CompactMethod.NONE;
            }
        }
    }
}
