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
    public partial class ErrorReport : Form
    {
        public ErrorReport()
        {
            InitializeComponent();
        }

        public void ShowExceptions(IEnumerable<Exception> exceptions)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Exception e in exceptions)
            {
                sb.Append($"Error:\n{e.Message}");
            }

            tbExceptions.Text = sb.ToString();

            ShowDialog();
        }
    }
}
