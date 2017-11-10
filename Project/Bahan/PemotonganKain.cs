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
using System.Data.SqlClient;

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
                    txtPONumber.Text = db.PONumber.ToString();
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
                detailFakturBindingSourceCbo.DataSource = listFaktur.ToList();
                employeeBindingSource.DataSource = db.Employees.ToList();
                detailFakturBindingSource.DataSource = db.DetailFakturs.ToList();
            }
        }

        private void btnSavePemotonganKain_Click(object sender, EventArgs e)
        {
            if (txtNoPemotonganKain.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "No pemotongan kain must be filled!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoPemotonganKain.Focus();
            }
            else if (cboFakturPenerimaanKain.Items.Count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Detail Faktur List is empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboFakturPenerimaanKain.Items.Count > 0 && txtSupplierCode.Text == "" && txtSupplierName.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select the Detail Faktur first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboFakturPenerimaanKain.Focus();
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to save this pemotongan kain data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (indomodaEntities db = new indomodaEntities())
                    {
                        string noFaktur = cboFakturPenerimaanKain.SelectedValue.ToString();
                        int setPICCode = Convert.ToInt32(cboPICCode.SelectedValue.ToString());
                        int setStatusPemotonganKain = 0;
                        int setPemotonganKainID = db.DetailPemotonganKains.AsEnumerable().LastOrDefault() == null ? 1 : db.DetailPemotonganKains.AsEnumerable().LastOrDefault().idPemotonganKain + 1;

                        try
                        {
                            int a = GenericQuery.ExecSQLCommand("INSERT INTO DetailPemotonganKain (idPemotonganKain, noPemotonganKain, NoFaktur, PONumber, EmployeeID, Date_time, status) VALUES(@idPemotonganKain, @noPemotonganKain, @NoFaktur, @PONumber, @EmployeeID, @Date_time, @status)", new[] {
                                        new SqlParameter("@idPemotonganKain", setPemotonganKainID),
                                        new SqlParameter("@noPemotonganKain", txtNoPemotonganKain.Text.ToString()),
                                        new SqlParameter("@NOFaktur", noFaktur),
                                        new SqlParameter("@PONumber", txtPONumber.Text.ToString()),
                                        new SqlParameter("@EmployeeID", setPICCode),
                                        new SqlParameter("@Date_time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                                        new SqlParameter("@status", setStatusPemotonganKain)
                                    });
                            db.SaveChangesAsync().Wait();

                            try
                            {
                                int setFakturStatus = 1;
                                int b = GenericQuery.ExecSQLCommand("UPDATE DetailFaktur SET status = @status WHERE NoFaktur = '" + noFaktur + "'", new[] {
                                    new SqlParameter("@status", setFakturStatus)
                                });
                                db.SaveChangesAsync().Wait();
                            }
                            catch (Exception ex)
                            {
                                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            cboFakturPenerimaanKain.Refresh();
                            List<FakturKainModel> newListFaktur = GenericQuery.SqlQuery<FakturKainModel>("select df.idFaktur, df.NoFaktur, df.PONumber, df.status, df.Date_time, p.SupplierID, i.SupplierCode, i.SupplierName from DetailFaktur df JOIN PreOrderKains p on df.PONumber = p.PONumber JOIN IndomodaSuppliers i on p.SupplierID = i.SupplierID WHERE df.status = '" + 0 + "'");
                            newListFaktur.Remove(new FakturKainModel { NoFaktur = noFaktur });
                            detailFakturBindingSourceCbo.DataSource = newListFaktur.ToList();
                            txtNoPemotonganKain.Clear();
                            txtPONumber.Clear();
                            txtSupplierCode.Clear();
                            txtSupplierName.Clear();
                            MetroFramework.MetroMessageBox.Show(this, "Success! Pemotongan kain has been added to database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnExitPemotonganKain_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
