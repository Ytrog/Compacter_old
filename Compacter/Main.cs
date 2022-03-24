﻿using System;
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

        private List<CompactOptions> commands = new List<CompactOptions>();

        private void tsbAddFolder_Click(object sender, EventArgs e)
        {
            AddFolder addFolder = new AddFolder();
            if (addFolder.ShowDialog(this) == DialogResult.OK)
            {
                commands.Add(addFolder.Result);
            }
        }
    }
}
