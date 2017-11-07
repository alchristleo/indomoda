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
        }

        private void btnExitPenerimaanKain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboNoPOKain_SelectedIndexChanged(object sender, EventArgs e)
        {
            long poNumber = Convert.ToInt64(cboNoPOKain.SelectedValue.ToString());
            var db = GenericQuery.SqlQuerySingle<POKainModel>("SELECT p.idPOKain, p.PONumber, p.SupplierID, s.SupplierName, s.SupplierCode FROM PreOrderKains p JOIN IndomodaSuppliers s ON p.SupplierID = s.SupplierID WHERE p.PONumber = '" + poNumber + "'");
            txtSupplierCode.Text = db.SupplierCode.ToString();
            txtSupplierName.Text = db.SupplierName.ToString();
            List<DetailPOModel> listPO = GenericQuery.SqlQuery<DetailPOModel>("SELECT * FROM DetailPO WHERE PONumber = '" + poNumber + "'");
            detailPOBindingSource.DataSource = listPO.ToList();
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
            }
        }

        private void btnDeletePenerimaanKain_Click(object sender, EventArgs e)
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
                        preOrderKainBindingSource.DataSource = db.PreOrderKains.ToList();

                        MetroFramework.MetroMessageBox.Show(this, "Success! This PO has been deleted to the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
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

                        MetroFramework.MetroMessageBox.Show(this, "Success! This detail PO stauts has been marked as done", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSaveUpdateStatus_Click(object sender, EventArgs e)
        {
            long poNumber = Convert.ToInt64(cboNoPOKain.SelectedValue.ToString());
            List<DetailPOModel> listPO = GenericQuery.SqlQuery<DetailPOModel>("SELECT * FROM DetailPO WHERE PONumber = '" + poNumber + "' AND DetailStatus = '"+0+"'");
            if (listPO.Count > 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must mark all the Detail PO as done first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                using (indomodaEntities db = new indomodaEntities())
                {
                    try
                    {
                        int setStatus = 1;
                        int a = GenericQuery.ExecSQLCommand("UPDATE PreOrderKains SET status = @status WHERE PONumber = '" + poNumber + "'", new[] {          
                                new SqlParameter("@status", setStatus)
                            });
                        db.SaveChangesAsync().Wait();
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
            }
        }
    }
}
