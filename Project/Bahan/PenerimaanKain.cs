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
    public partial class PenerimaanKain : MetroFramework.Forms.MetroForm
    {
        public PenerimaanKain()
        {
            InitializeComponent();
            cboNoPOKain.Text = "Select PO Number";
        }

        private void btnExitPenerimaanKain_Click(object sender, EventArgs e)
        {
            cboNoPOKain.Text = "";
            txtSupplierCode.Clear();
            txtSupplierName.Clear();
            this.Close();
        }

        private void cboNoPOKain_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNoPOKain.Items.Count > 0 && cboNoPOKain.Text != "")
                {
                    cboNoPOKain.Refresh();
                    long poNumber = Convert.ToInt64(cboNoPOKain.SelectedValue.ToString());
                    var db = GenericQuery.SqlQuerySingle<POKainModel>("SELECT p.idPOKain, p.PONumber, p.SupplierID, s.SupplierName, s.SupplierCode FROM PreOrderKains p JOIN IndomodaSuppliers s ON p.SupplierID = s.SupplierID WHERE p.PONumber = '" + poNumber + "'");
                    txtSupplierCode.Text = db.SupplierCode.ToString();
                    txtSupplierName.Text = db.SupplierName.ToString();
                    List<DetailPOModel> listPO = GenericQuery.SqlQuery<DetailPOModel>("SELECT * FROM DetailPO WHERE PONumber = '" + poNumber + "'");
                    detailPOBindingSource.DataSource = listPO.ToList();
                }
            }
            catch (NullReferenceException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PenerimaanKain_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                //preOrderKainBindingSource.DataSource = db.PreOrderKains.ToList();
                List<PreOrderKain> listCboPO = GenericQuery.SqlQuery<PreOrderKain>("SELECT p.idPOKain, p.PONumber, p.SupplierID, p.status, p.SupplierID, p.GrandTotal, p.Date_time FROM PreOrderKains p WHERE p.status = '" + 0 + "'");
                preOrderKainBindingSource.DataSource = listCboPO.ToList();
                materialBindingSource.DataSource = db.Materials.ToList();
                colorBindingSource.DataSource = db.Colors.ToList();
                cboNoPOKain.Refresh();
            }
        }

        private void btnDeletePenerimaanKain_Click(object sender, EventArgs e)
        {
            if (cboNoPOKain.Items.Count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "PO List is empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to delete this PO?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    using (indomodaEntities db = new indomodaEntities())
                    {
                        try
                        {
                            long poNumber = Convert.ToInt64(cboNoPOKain.SelectedValue.ToString());
                            int b = GenericQuery.ExecSQLCommand("DELETE FROM PreOrderKains WHERE poNumber = '" + poNumber + "'");
                            db.SaveChangesAsync().Wait();
                            cboNoPOKain.Refresh();
                            dataGridView1.Refresh();
                            List<PreOrderKain> listCboPO = GenericQuery.SqlQuery<PreOrderKain>("SELECT p.idPOKain, p.PONumber, p.SupplierID, p.status, p.SupplierID, p.GrandTotal, p.Date_time FROM PreOrderKains p WHERE p.status = '" + 0 + "'");
                            listCboPO.Remove(new PreOrderKain() { PONumber = poNumber });
                            preOrderKainBindingSource.DataSource = listCboPO.ToList();

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

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Detail PO is empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to update this detail PO status?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (indomodaEntities db = new indomodaEntities())
                    {
                        try
                        {
                            int currentRow = dataGridView1.CurrentRow.Index;
                            int currentDetailPOID = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                            bool setStatus = Convert.ToBoolean(dataGridView1.Rows[currentRow].Cells[6].Value);
                            int a = GenericQuery.ExecSQLCommand("UPDATE DetailPO SET DetailStatus = @DetailStatus WHERE DetailPOID = '" + currentDetailPOID + "'", new[] {
                            new SqlParameter("@DetailStatus", setStatus)
                        });
                            db.SaveChangesAsync().Wait();
                            dataGridView1.Refresh();

                            MetroFramework.MetroMessageBox.Show(this, "Success! This detail PO stauts has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnSaveUpdateStatus_Click(object sender, EventArgs e)
        {
            if (cboNoPOKain.Items.Count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "PO List is empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboNoPOKain.Items.Count > 0 && txtSupplierCode.Text == "" && txtSupplierName.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select the PO Number first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboNoPOKain.Items.Count > 0 && txtSupplierCode.Text != "" && txtSupplierName.Text != "" && dataGridView1.Rows.Count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select the PO Number first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                long po = Convert.ToInt64(cboNoPOKain.SelectedValue.ToString());
                List<DetailPOModel> listPODb = GenericQuery.SqlQuery<DetailPOModel>("SELECT * FROM DetailPO WHERE PONumber = '" + po + "' AND DetailStatus = '" + 0 + "'");

                if (listPODb.Count > 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "You must mark all the Detail PO as done first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtNoFaktur.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "You must fill No Faktur first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtNoFaktur.Text.Length != 10 )
                {
                    MetroFramework.MetroMessageBox.Show(this, "No Faktur must be 10 characters!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (indomodaEntities db = new indomodaEntities())
                    {
                        try
                        {
                            int setStatus = 1;
                            int a = GenericQuery.ExecSQLCommand("UPDATE PreOrderKains SET status = @status WHERE PONumber = '" + po + "'", new[] {
                                new SqlParameter("@status", setStatus)
                            });
                            db.SaveChangesAsync().Wait();

                            try
                            {
                                int setFakturID = db.DetailFakturs.AsEnumerable().LastOrDefault() == null ? 1 : db.DetailFakturs.AsEnumerable().LastOrDefault().idFaktur + 1;
                                string setNoFaktur = txtNoFaktur.Text;
                                int setStatusFaktur = 0;
                                int b = GenericQuery.ExecSQLCommand("INSERT INTO DetailFaktur (idFaktur, NoFaktur, PONumber, Date_time, status) VALUES(@idFaktur, @NoFaktur, @PONumber, @Date_time, @status)", new[] {
                                    new SqlParameter("@idFaktur", setFakturID),
                                    new SqlParameter("@NoFaktur", setNoFaktur),
                                    new SqlParameter("@PONumber", po),
                                    new SqlParameter("@Date_time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                                    new SqlParameter("@status", setStatusFaktur)
                                });
                                db.SaveChangesAsync().Wait();
                            }
                            catch (Exception ex)
                            {
                                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            cboNoPOKain.Refresh();

                            if (cboNoPOKain.Items.Count == 0)
                            {
                                dataGridView1.Rows.Clear();
                                dataGridView1.Refresh();
                            }
                            else
                            {
                                dataGridView1.Rows.Clear();
                            }

                            btnSaveUpdateStatus.Refresh();
                            List<PreOrderKain> listCboPO = GenericQuery.SqlQuery<PreOrderKain>("SELECT p.idPOKain, p.PONumber, p.SupplierID, p.status, p.SupplierID, p.GrandTotal, p.Date_time FROM PreOrderKains p WHERE p.status = '" + 0 + "'");
                            listCboPO.Remove(new PreOrderKain() { PONumber = po });
                            preOrderKainBindingSource.DataSource = listCboPO.ToList();
                            txtSupplierCode.Clear();
                            txtSupplierName.Clear();
                            txtNoFaktur.Clear();
                            MetroFramework.MetroMessageBox.Show(this, "Success! No Faktur created and this PO has been marked as done", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
