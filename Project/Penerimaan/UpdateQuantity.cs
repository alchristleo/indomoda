using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project.Penerimaan
{
    public partial class UpdateQuantity : MetroFramework.Forms.MetroForm
    {
        public UpdateQuantity()
        {
            InitializeComponent();
        }

        private void UpdateQuantity_Load(object sender, EventArgs e)
        {

        }

        private void btnExitUpdate_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (txtBarangHilang.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must fill barang hilang quantity first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBarangHilang.Focus();
            }
            else if (txtBarangBS.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must fill barang BS quantity first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBarangBS.Focus();
            }
            else
            {

            }
        }
    }
}
