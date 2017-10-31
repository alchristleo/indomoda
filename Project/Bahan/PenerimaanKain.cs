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
    public partial class PenerimaanKain : MetroFramework.Forms.MetroForm
    {
        public PenerimaanKain()
        {
            InitializeComponent();
        }

        private void btnExitPenerimaanKain_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (metroCheckBox1.check)
        //}
    }
}
