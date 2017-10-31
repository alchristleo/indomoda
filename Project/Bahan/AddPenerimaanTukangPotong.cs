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
    public partial class AddPenerimaanTukangPotong : MetroFramework.Forms.MetroForm
    {
        public AddPenerimaanTukangPotong()
        {
            InitializeComponent();
        }

        private void btnExitAddPenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnToWarnaTukangPotong_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAddPenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNoSeriTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "No. Seri can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoSeriTukangPotong.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtModelTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Model can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModelTukangPotong.Focus();
                return;
            }
            else if (cboWarna.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select warna!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboWarna.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtMerkTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Merk can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMerkTukangPotong.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtUkuranTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Ukuran can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUkuranTukangPotong.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtQtyTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Quantity can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtyTukangPotong.Focus();
                return;
            }
        }
    }
}
