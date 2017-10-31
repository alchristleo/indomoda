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
    public partial class SPKCmt : Form
    {
        public SPKCmt()
        {
            InitializeComponent();
        }

        private void btnExitSPKCmt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddSPKCmt_Click(object sender, EventArgs e)
        {
            AddSpkCmt addspkCmt = new AddSpkCmt();
            addspkCmt.Show();
        }
    }
}
