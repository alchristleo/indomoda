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
    public partial class AddPenerimaanKain : MetroFramework.Forms.MetroForm
    {
        public AddPenerimaanKain()
        {
            InitializeComponent();
        }

        private void btnExitAddPenerimaanKain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveAddPenerimaanKain_Click(object sender, EventArgs e)
        {
            if (cboMaterialCode.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select the Bahan Code!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaterialCode.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtMaterialName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Bahan name can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaterialName.Focus();
                return;
            }
            else if (cboColorCode.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select the Warna Code!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboColorCode.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtColorName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Warna name can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtColorName.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtAddRoll.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Roll can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddRoll.Focus();
                return;
            }
        }
    }
}
