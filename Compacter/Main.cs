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
        }

        private void tsbAddFolder_Click(object sender, EventArgs e)
        {
            AddFolder addFolder = new AddFolder();
            addFolder.ShowDialog(this);
        }
    }
}
