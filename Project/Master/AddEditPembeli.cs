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
    public partial class AddEditPembeli : MetroFramework.Forms.MetroForm
    {
        public AddEditPembeli()
        {
            InitializeComponent();
        }

        indomodaEntities db;

        public AddEditPembeli(Customer obj)
        {
            InitializeComponent();
            bindingSourceCustomer.DataSource = obj;
        }

        public Customer CustomerInfo { get { return bindingSourceCustomer.Current as Customer; } }

        private void AddEditPembeli_Load(object sender, EventArgs e)
        {
            db = new indomodaEntities();
        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            lblCustomerCode.Clear();
            lblCustomerName.Clear();
            lblCustomerAddress.Clear();
            lblCustomerPhone.Clear();
            lblCustomerCode.Focus();
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lblCustomerCode.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter customer code!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblCustomerCode.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lblCustomerName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter customer name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblCustomerName.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lblCustomerAddress.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter customer address!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblCustomerAddress.Focus();
                return;
            }
            else if (!IsDigitsOnly(lblCustomerPhone.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Customer phone must be numeric!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblCustomerPhone.Clear();
                lblCustomerPhone.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lblCustomerPhone.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter customer phone!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblCustomerPhone.Focus();
                return;
            }

            bindingSourceCustomer.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
