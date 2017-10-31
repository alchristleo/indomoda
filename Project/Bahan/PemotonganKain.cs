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
    public partial class PemotonganKain : MetroFramework.Forms.MetroForm
    {
        public PemotonganKain()
        {
            InitializeComponent();
        }

        private void btnExitPemotonganKain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSavePemotonganKain_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNoPemotonganKain.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "No. Pemotongan Kain can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoPemotonganKain.Focus();
                return;
            }
            else if (cboFakturPenerimaanKain.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select No. Faktur Penerimaan Kain!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboFakturPenerimaanKain.Focus();
                return;
            }
            else if (cboSupplierCode.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select No. Faktur Penerimaan Kain!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSupplierCode.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtSupplierName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Supplier name can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplierName.Focus();
                return;
            }
            else if (cboPICCode.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select No. Faktur Penerimaan Kain!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPICCode.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtPICName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Supplier name can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPICName.Focus();
                return;
            }
        }
    }
}
