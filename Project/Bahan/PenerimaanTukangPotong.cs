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
    public partial class PenerimaanTukangPotong : MetroFramework.Forms.MetroForm
    {
        public PenerimaanTukangPotong()
        {
            InitializeComponent();
        }

        private void btnExitPenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddPenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            AddPenerimaanTukangPotong addPenerimaanTukangPotong = new AddPenerimaanTukangPotong();
            addPenerimaanTukangPotong.Show();
        }

        private void PenerimaanTukangPotong_Load(object sender, EventArgs e)
        {

        }

        private void btnSavePenerimaanTukangPotong_Click(object sender, EventArgs e)
        {

        }
    }
}
