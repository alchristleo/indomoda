using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project
{
    public partial class AddEditEmployee : MetroFramework.Forms.MetroForm
    {
        public AddEditEmployee()
        {
            InitializeComponent();
        }

        indomodaEntities db;

        public AddEditEmployee(Employee obj)
        {
            InitializeComponent();
            bindingSourceEmployee.DataSource = obj;
        }

        public Employee EmployeeInfo { get { return bindingSourceEmployee.Current as Employee; } }

        private void AddEditEmployee_Load(object sender, EventArgs e)
        {
            db = new indomodaEntities();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lblEmployeeName.Clear();
            lblEmployeeCode.Clear();
            lblEmployeeEmail.Clear();
            lblEmployeePhone.Clear();
            lblEmployeePosition.Clear();
            lblEmployeeName.Focus();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isEmail = Regex.IsMatch(lblEmployeeEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (String.IsNullOrEmpty(lblEmployeeName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter employee name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEmployeeName.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lblEmployeeCode.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter employee code!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEmployeeCode.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lblEmployeeEmail.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter employee email!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEmployeeEmail.Focus();
                return;
            }
            else if (!isEmail)
            {
                MetroFramework.MetroMessageBox.Show(this, "Wrong email format! Ex: budi@gmail.com", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEmployeeEmail.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lblEmployeePhone.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter employee phone!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEmployeePhone.Focus();
                return;
            }
            else if (!IsDigitsOnly(lblEmployeePhone.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Employee phone must be numeric!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEmployeePhone.Clear();
                lblEmployeePhone.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lblEmployeePosition.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter employee position!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEmployeePosition.Focus();
                return;
            }

            bindingSourceEmployee.EndEdit();
            DialogResult = DialogResult.OK;

        }
    }
}
