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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            System.Diagnostics.Debug.Assert(commands != null, "commands is null");
            bindingSource1.DataSource = commands;
            dgvCommands.DataSource = bindingSource1;
        }

        private BindingList<CompactOptions> commands = new BindingList<CompactOptions>();
        private bool running;

        private void tsbAddFolder_Click(object sender, EventArgs e)
        {
            AddFolder addFolder = new AddFolder();
            if (addFolder.ShowDialog(this) == DialogResult.OK)
            {
                commands.Add(addFolder.Result);
                bindingSource1.ResetBindings(false);
            }
        }

        private async void tsbExecute_Click(object sender, EventArgs e)
        {
            tsProgress.Style = ProgressBarStyle.Marquee;
            SetButtonsEnabled(false);
            running = true;

            await CommandRunner.Run(commands);

            SetButtonsEnabled(true);
            running = false;
            tsProgress.Style = ProgressBarStyle.Continuous;
        }

        private void SetButtonsEnabled(bool enabled)
        {
            tsbAddFolder.Enabled = enabled;
            tsbAddFolder.Enabled = enabled;
        }

        private void ctxDeleteButton_Click(object sender, EventArgs e)
        {
            if (dgvCommands.AllowUserToDeleteRows)
            {
                var rows = dgvCommands.SelectedRows;

                foreach (DataGridViewRow r in rows)
                {
                    dgvCommands.Rows.Remove(r);
                }
            }
        }

        private void dgvCommands_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CheckRowState();
        }

        private void CheckRowState()
        {
            tsbExecute.Enabled = !running && dgvCommands.Rows.Count > 0;
        }

        private void dgvCommands_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CheckRowState();
        }
    }
}
