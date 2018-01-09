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
                    long poNumber = Convert.ToInt64(db.PONumber.ToString());
                    txtSupplierCode.Text = db.SupplierCode.ToString();
                    txtSupplierName.Text = db.SupplierName.ToString();
                    txtPONumber.Text = db.PONumber.ToString();
                    List<FakturDetailPO> listFakturDetail = GenericQuery.SqlQuery<FakturDetailPO>("SELECT df.idFaktur, df.NoFaktur, df.PONumber, df.status, dp.DetailPOID, dp.MaterialID, dp.ColorID, dp.DetailQty, dp.DetailStatus, dp.statusFaktur, dp.noPemotonganKain, dp.tempPemotongan from DetailFaktur df JOIN DetailPO dp on df.PONumber = dp.PONumber WHERE df.PONumber = '" + poNumber + "'");
                    detailPOBindingSource.DataSource = listFakturDetail.ToList();

                    int rowCount = dataGridView1.Rows.Count;
                    for (int i = 0; i < rowCount; i++)
                    {
                        dataGridView1.Columns[0].ValueType = typeof(int);
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
                        dataGridView1.UpdateCellValue(0, i);
                    }
                    dataGridView1.Refresh();
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
                colorBindingSource.DataSource = db.Colors.ToList();
                materialBindingSource.DataSource = db.Materials.ToList();
                dataGridView1.Refresh();
            }
        }

        private void btnExitPemotonganKain_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboPICName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPICName.Items.Count > 0 && cboPICName.Text != "")
            {
                int eID = Convert.ToInt32(cboPICName.SelectedValue.ToString());
                var dba = GenericQuery.SqlQuerySingle<Employee>("SELECT e.EmployeeID, e.EmployeeName, e.EmployeeCode, e.EmployeeEmail, e.EmployeePhone, e.EmployeePosition from Employees e WHERE e.EmployeeID = '" + eID + "'");
                txtPICCode.Text = dba.EmployeeCode.ToString();
            }
        }

        private void btnDeleteFaktur_Click(object sender, EventArgs e)
        {
            if (cboFakturPenerimaanKain.Items.Count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "List Faktur is empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to delete this faktur kain", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    using (indomodaEntities db = new indomodaEntities())
                    {
                        try
                        {
                            string noFaktur = cboFakturPenerimaanKain.SelectedValue.ToString();
                            int c = GenericQuery.ExecSQLCommand("DELETE FROM DetailFaktur WHERE NoFaktur = '" + noFaktur + "'");
                            db.SaveChangesAsync().Wait();
                            cboFakturPenerimaanKain.Refresh();
                            dataGridView1.Refresh();

                            try
                            {
                                int setStatus = 0;
                                long poNumber = Convert.ToInt64(txtPONumber.Text.ToString());
                                int d = GenericQuery.ExecSQLCommand("UPDATE PreOrderKains SET status = @status WHERE PONumber = '" + poNumber + "'", new[] {
                                    new SqlParameter("@status", setStatus)
                                });
                                db.SaveChangesAsync().Wait();
                            }
                            catch (Exception ex)
                            {
                                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            List<FakturKainModel> listFaktur = GenericQuery.SqlQuery<FakturKainModel>("select df.idFaktur, df.NoFaktur, df.PONumber, df.status, df.Date_time, p.SupplierID, i.SupplierCode, i.SupplierName from DetailFaktur df JOIN PreOrderKains p on df.PONumber = p.PONumber JOIN IndomodaSuppliers i on p.SupplierID = i.SupplierID WHERE df.status = '" + 0 + "'");
                            listFaktur.Remove(new FakturKainModel() { NoFaktur = noFaktur });
                            detailFakturBindingSourceCbo.DataSource = listFaktur.ToList();

                            MetroFramework.MetroMessageBox.Show(this, "Success! This PO has been deleted from the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnUpdateStatusPemotongan_Click(object sender, EventArgs e)
        {
            if (cboFakturPenerimaanKain.Items.Count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Detail PO for this No pemotongan kain is empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboFakturPenerimaanKain.Items.Count > 0 && txtSupplierCode.Text == "" && txtSupplierName.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select no pemotongan kain first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to update this detail PO pemotongan status?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (indomodaEntities db = new indomodaEntities())
                    {
                        try
                        {
                            int currentRow = dataGridView1.CurrentRow.Index;
                            int currentDetailPOID = Convert.ToInt32(dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString());
                            bool setStatusFaktur = Convert.ToBoolean(dataGridView1.Rows[currentRow].Cells[5].Value);
                            int tempPK = Convert.ToBoolean(setStatusFaktur == true) ? 1 : 0; //means current detail PO status PK is done, but no PK is not set yet
                            bool checkTempPK = Convert.ToBoolean(dataGridView1.Rows[currentRow].Cells[7].Value.ToString() == "2") ? true : false;
                            long po = Convert.ToInt64(txtPONumber.Text.ToString());
                            if (checkTempPK)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "You can not edit this detail PO pemotongan again, this detail PO pemotongan has been updated before", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                List<FakturDetailPO> listFakturDetail = GenericQuery.SqlQuery<FakturDetailPO>("select df.idFaktur, df.NoFaktur, df.PONumber, df.status, dp.DetailPOID, dp.MaterialID, dp.ColorID, dp.DetailQty, dp.DetailStatus, dp.statusFaktur, dp.noPemotonganKain, dp.tempPemotongan from DetailFaktur df JOIN DetailPO dp on df.PONumber = dp.PONumber WHERE df.PONumber = '" + po + "'");
                                detailPOBindingSource.DataSource = listFakturDetail.ToList();

                                int rowCount = dataGridView1.Rows.Count;
                                for (int i = 0; i < rowCount; i++)
                                {
                                    dataGridView1.Columns[0].ValueType = typeof(int);
                                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                                    dataGridView1.UpdateCellValue(0, i);
                                }
                                dataGridView1.Refresh();
                            }
                            else
                            {
                                int a = GenericQuery.ExecSQLCommand("UPDATE DetailPO SET statusFaktur = @statusFaktur, tempPemotongan = @tempPemotongan WHERE DetailPOID = '" + currentDetailPOID + "'", new[] {
                                    new SqlParameter("@statusFaktur", setStatusFaktur),
                                    new SqlParameter("@tempPemotongan", tempPK)
                                });
                                db.SaveChangesAsync().Wait();
                                List<FakturDetailPO> listFakturDetail = GenericQuery.SqlQuery<FakturDetailPO>("select df.idFaktur, df.NoFaktur, df.PONumber, df.status, dp.DetailPOID, dp.MaterialID, dp.ColorID, dp.DetailQty, dp.DetailStatus, dp.statusFaktur, dp.noPemotonganKain, dp.tempPemotongan from DetailFaktur df JOIN DetailPO dp on df.PONumber = dp.PONumber WHERE df.PONumber = '" + po + "'");
                                detailPOBindingSource.DataSource = listFakturDetail.ToList();

                                int rowCount = dataGridView1.Rows.Count;
                                for (int i = 0; i < rowCount; i++)
                                {
                                    dataGridView1.Columns[0].ValueType = typeof(int);
                                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                                    dataGridView1.UpdateCellValue(0, i);
                                }
                                dataGridView1.Refresh();

                                MetroFramework.MetroMessageBox.Show(this, "Success! This detail PO pemotongan status has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnSavePemotonganKain_Click(object sender, EventArgs e)
        {
            if (txtNoPemotonganKain.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "No pemotongan kain must be filled!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoPemotonganKain.Focus();
                txtNoPemotonganKain.ForeColor = System.Drawing.Color.Red;
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
            else if (txtPICCode.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select the PIC Name first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPICName.Focus();
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to save this pemotongan kain data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (indomodaEntities db = new indomodaEntities())
                    {
                        string noFaktur = cboFakturPenerimaanKain.SelectedValue.ToString();
                        string noPK = txtNoPemotonganKain.Text.ToString();
                        long noPO = Convert.ToInt64(txtPONumber.Text.ToString());
                        int setPICCode = Convert.ToInt32(cboPICName.SelectedValue.ToString());
                        int setStatusPemotonganKain = 0;
                        int setPemotonganKainID = db.DetailPemotonganKains.AsEnumerable().LastOrDefault() == null ? 1 : db.DetailPemotonganKains.AsEnumerable().LastOrDefault().idPemotonganKain + 1;

                        try
                        {
                            int a = GenericQuery.ExecSQLCommand("INSERT INTO DetailPemotonganKain (idPemotonganKain, noPemotonganKain, NoFaktur, PONumber, EmployeeID, Date_time, status) VALUES(@idPemotonganKain, @noPemotonganKain, @NoFaktur, @PONumber, @EmployeeID, @Date_time, @status)", new[] {
                                        new SqlParameter("@idPemotonganKain", setPemotonganKainID),
                                        new SqlParameter("@noPemotonganKain", noPK),
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
                                int setTempKain = 2;
                                int count = 0;

                                int c = GenericQuery.ExecSQLCommand("UPDATE DetailPO SET noPemotonganKain = @noPemotonganKain, tempPemotongan = @tempPemotongan WHERE PONumber = '" + noPO + "' AND tempPemotongan = '" + 1 + "'", new[] {
                                    new SqlParameter("@noPemotonganKain", noPK),
                                    new SqlParameter("@tempPemotongan", setTempKain)
                                });
                                db.SaveChangesAsync().Wait();

                                dataGridView1.Refresh();

                                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                {
                                    if (dataGridView1.Rows[i].Cells[7].Value.ToString() != "0")
                                    {
                                        count++;
                                    }
                                }

                                if (count == dataGridView1.Rows.Count)
                                {
                                    int b = GenericQuery.ExecSQLCommand("UPDATE DetailFaktur SET status = @status WHERE NoFaktur = '" + noFaktur + "'", new[] {
                                        new SqlParameter("@status", setFakturStatus)
                                    });
                                    db.SaveChangesAsync().Wait();
                                    List<FakturDetailPO> listFakturDetail = GenericQuery.SqlQuery<FakturDetailPO>("select df.idFaktur, df.NoFaktur, df.PONumber, df.status, dp.DetailPOID, dp.MaterialID, dp.ColorID, dp.DetailQty, dp.DetailStatus, dp.statusFaktur, dp.noPemotonganKain, dp.tempPemotongan from DetailFaktur df JOIN DetailPO dp on df.PONumber = dp.PONumber WHERE df.PONumber = '" + noPO + "'");
                                    detailPOBindingSource.DataSource = listFakturDetail.ToList();

                                    int rowCount = dataGridView1.Rows.Count;
                                    for (int i = 0; i < rowCount; i++)
                                    {
                                        dataGridView1.Columns[0].ValueType = typeof(int);
                                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
                                        dataGridView1.UpdateCellValue(0, i);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            cboFakturPenerimaanKain.Refresh();
                            List<FakturKainModel> newListFaktur = GenericQuery.SqlQuery<FakturKainModel>("select df.idFaktur, df.NoFaktur, df.PONumber, df.status, df.Date_time, p.SupplierID, i.SupplierCode, i.SupplierName from DetailFaktur df JOIN PreOrderKains p on df.PONumber = p.PONumber JOIN IndomodaSuppliers i on p.SupplierID = i.SupplierID WHERE df.status = '" + 0 + "'");
                            newListFaktur.Remove(new FakturKainModel { NoFaktur = noFaktur });
                            detailFakturBindingSourceCbo.DataSource = newListFaktur.ToList();
                            dataGridView1.Rows.Clear();
                            //detailFakturBindingSource.DataSource = db.DetailFakturs.ToList();

                            txtNoPemotonganKain.Clear();
                            txtPONumber.Clear();
                            txtSupplierCode.Clear();
                            txtSupplierName.Clear();
                            txtPICCode.Clear();
                            dataGridView1.Refresh();
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
    }
}
