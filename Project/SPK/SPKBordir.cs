using Project.Helpers;
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
    public partial class SPKBordir : MetroFramework.Forms.MetroForm
    {
        public SPKBordir()
        {
            InitializeComponent();
        }

        private void btnExitSPKBordir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddSPKBordir_Click(object sender, EventArgs e)
        {
            AddSpkBordir addspkBordir = new AddSpkBordir();
            addspkBordir.Show();
        }

        private void cboPICBordir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPICBordir.Items.Count > 0 && cboPICBordir.Text != "")
            {
                int eID = Convert.ToInt32(cboPICBordir.SelectedValue.ToString());
                var dba = GenericQuery.SqlQuerySingle<Employee>("SELECT e.EmployeeID, e.EmployeeName, e.EmployeeCode, e.EmployeeEmail, e.EmployeePhone, e.EmployeePosition from Employees e WHERE e.EmployeeID = '" + eID + "'");
                txtPicCodeBordir.Text = dba.EmployeeCode.ToString();
            }
        }
    }
}
