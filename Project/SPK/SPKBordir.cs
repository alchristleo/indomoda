using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class SPKBordir : Form
    {
        public SPKBordir()
        {
            InitializeComponent();
        }

        private void btnExitSPKBordir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddSPKBordir_Click(object sender, EventArgs e)
        {
            AddSpkBordir addspkBordir = new AddSpkBordir();
            addspkBordir.Show();
        }
    }
}
