using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project.Helpers;
using Project.Models;

namespace Project
{
    public partial class PemotonganKain : MetroFramework.Forms.MetroForm
    {
        public PemotonganKain()
        {
            InitializeComponent();
        }

        private void cboFakturPenerimaanKain_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboFakturPenerimaanKain.Items.Count > 0 && cboFakturPenerimaanKain.Text != "")
                {
                    cboFakturPenerimaanKain.Refresh();
                    string noFakturKain = cboFakturPenerimaanKain.SelectedValue.ToString();
                    var db = GenericQuery.SqlQuerySingle<FakturKainModel>("select df.idFaktur, df.NoFaktur, df.PONumber, df.status, df.Date_time, p.SupplierID, i.SupplierCode, i.SupplierName from DetailFaktur df JOIN PreOrderKains p on df.PONumber = p.PONumber JOIN IndomodaSuppliers i on p.SupplierID = i.SupplierID WHERE df.status = '"+0+"' AND df.NoFaktur = '"+noFakturKain+"'");
                    txtSupplierCode.Text = db.SupplierCode.ToString();
                    txtSupplierName.Text = db.SupplierName.ToString();
                }
            }
            catch (NullReferenceException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PemotonganKain_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                List<FakturKainModel> listFaktur = GenericQuery.SqlQuery<FakturKainModel>("select df.idFaktur, df.NoFaktur, df.PONumber, df.status, df.Date_time, p.SupplierID, i.SupplierCode, i.SupplierName from DetailFaktur df JOIN PreOrderKains p on df.PONumber = p.PONumber JOIN IndomodaSuppliers i on p.SupplierID = i.SupplierID WHERE df.status = '" + 0 + "'");
                detailFakturBindingSource.DataSource = listFaktur.ToList();
                employeeBindingSource.DataSource = db.Employees.ToList();
                detailFakturBindingSource.DataSource = db.DetailFakturs.ToList();
                detailFakturBindingSourceCbo.DataSource = db.DetailFakturs.ToList();
            }
        }

        private void btnExitPemotonganKain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSavePemotonganKain_Click(object sender, EventArgs e)
        {
           
        }
    }
}
