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
    public partial class AddEditSupplier : MetroFramework.Forms.MetroForm
    {
        public AddEditSupplier()
        {
            InitializeComponent();
        }

        indomodaEntities db;

        public IndomodaSupplier SupplierInfo { get { return bindingSourceSupplier.Current as IndomodaSupplier; } }

        public AddEditSupplier(IndomodaSupplier obj)
        {
            InitializeComponent();
            bindingSourceSupplier.DataSource = obj;
        }

        private void AddEditSupplier_Load(object sender, EventArgs e)
        {
            db = new indomodaEntities();
        }

        private void btnClearSupplier_Click(object sender, EventArgs e)
        {
            lblSupplierCode.Clear();
            lblSupplierName.Clear();
            lblSupplierAddress.Clear();
            lblSupplierPhone.Clear();
            lblSupplierCode.Focus();
        }

        private void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lblSupplierCode.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter supplier code!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblSupplierCode.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lblSupplierName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter supplier name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblSupplierName.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lblSupplierAddress.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter supplier address!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblSupplierAddress.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lblSupplierPhone.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter supplier phone!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblSupplierPhone.Focus();
                return;
            }

            bindingSourceSupplier.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
