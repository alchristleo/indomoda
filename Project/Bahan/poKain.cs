using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using Project.Helpers;
using System.Data.SqlClient;
using Project.Models;

namespace Project
{
    public partial class poKain : MetroFramework.Forms.MetroForm
    {
        indomodaEntities db;

        private BindingSource _bs = null;
        private DataGridView _dv = null;
        private Form _form = null;
        public static string poNumber;
        private List<DetailPOModel> _dpo = null;
        public List<DetailPOModel> listPO = new List<DetailPOModel>();

        public void setRefForm(Form form)
        {
            _form = form;
        }

        public void setBS(BindingSource bs)
        {
            _bs = bs;
        }

        public void setDGV(DataGridView dv)
        {
            _dv = dv;
        }

        public void setDPO(List<DetailPOModel> dpo)
        {
            _dpo = dpo;
        }

        public poKain()
        {
            InitializeComponent();
        }

        private void btnAddPoKain_Click(object sender, EventArgs e)
        {
            poNumber = lblPONumber.Text;
            AddPOKain addpokain = new AddPOKain();
            addpokain.setDGV(ref dataGridView1);
            addpokain.setBS(ref detailPOBindingSource);
            addpokain.Show();
        }

        private void btnEditPoKain_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add detail PO first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EditPOKain editpokain = new EditPOKain();
                int currentPOID = Convert.ToInt32(dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString());

                listPO = GenericQuery.SqlQuery<DetailPOModel>("SELECT d.DetailPOID, d.PONumber, d.MaterialID, d.ColorID, d.DetailQty, d.DetailPrice, d.DetailTotal, d.DetailStatus, m.MaterialCode, m.MaterialName, c.ColorCode, c.ColorName FROM DetailPO d JOIN Materials m ON d.MaterialID = m.MaterialID JOIN Colors c ON d.ColorID = c.ColorID  WHERE DetailPOID = '" + currentPOID + "'");
                editpokain.setDPO(ref listPO);
                editpokain.setDGV(ref dataGridView1);
                editpokain.setBS(ref detailPOBindingSource);
                editpokain.Show();
            }
        }

        private void btnDeletePoKain_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add detail PO first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to delete this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    using (indomodaEntities db = new indomodaEntities())
                    {
                        try
                        {
                            int currentRow = dataGridView1.CurrentRow.Index;
                            int currentPOID = Convert.ToInt32(dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString());
                            int b = GenericQuery.ExecSQLCommand("DELETE FROM DetailPO WHERE DetailPOID = '"+currentPOID+"'");
                            db.SaveChangesAsync().Wait();
                            dataGridView1.Rows.RemoveAt(currentRow);

                            int rowCount = dataGridView1.Rows.Count;
                            for (int i = 0; i < rowCount; i++)
                            {
                                dataGridView1.Columns[0].ValueType = typeof(int);
                                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                                dataGridView1.UpdateCellValue(0, i);
                            }
                            dataGridView1.Refresh();
                            bindingSourcePreOrderKain.EndEdit();

                            btnCountGrandTotal.PerformClick();

                            MetroFramework.MetroMessageBox.Show(this, "Success! This Detail PO has been deleted to the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        
        private void poKain_Load(object sender, EventArgs e)
        {
            long randomNumber = Convert.ToInt64(DateTime.Now.ToString("ddMMyyHHmm"));
            lblPONumber.Text = randomNumber.ToString();
            using (indomodaEntities db = new indomodaEntities())
            {
                indomodaSupplierBindingSource.DataSource = db.IndomodaSuppliers.ToList();
                materialBindingSource.DataSource = db.Materials.ToList();
                colorBindingSource.DataSource = db.Colors.ToList();
            }
            dataGridView1.Columns[5].DefaultCellStyle.Format = "C";
            dataGridView1.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            dataGridView1.Columns[6].DefaultCellStyle.Format = "C";
            dataGridView1.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
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

        private void btnSavePoKain_Click(object sender, EventArgs e)
        {
            btnCountGrandTotal.PerformClick();

            using (indomodaEntities db = new indomodaEntities())
            {
                if (dataGridView1.RowCount == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "You need to add detail PO first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Do you want to save this transaction to database?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            int setPOID = db.PreOrderKains.AsEnumerable().LastOrDefault() == null ? 1 : db.PreOrderKains.AsEnumerable().LastOrDefault().idPOKain + 1;
                            int SupplierID = Convert.ToInt32(cboSupplierName.SelectedValue.ToString());
                            decimal setGTotal = Convert.ToDecimal(lblGrandTotalDB.Text.ToString());
                            bool setStatus = false;
                            int a = GenericQuery.ExecSQLCommand("INSERT INTO PreOrderKains (idPOKain, PONumber, SupplierID, GrandTotal, Date_time, status) VALUES(@idPOKain, @PONumber, @SupplierID, @GrandTotal, @Date_time, @status)", new[] {
                                new SqlParameter("@idPOKain", setPOID),
                                new SqlParameter("@PONumber", lblPONumber.Text),
                                new SqlParameter("@SupplierID", SupplierID),
                                new SqlParameter("@GrandTotal", setGTotal),
                                new SqlParameter("@Date_time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                                new SqlParameter("@status", setStatus)
                            });

                            db.SaveChangesAsync().Wait();
                            bindingSourcePreOrderKain.EndEdit();

                            MetroFramework.MetroMessageBox.Show(this, "Success! Transaction has been added to the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnExitPoKain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCountGrandTotal_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            decimal gt = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                gt = gt + decimal.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
            }
            lblGrandTotal.Text = String.Format(gt.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("id-ID")));
            lblGrandTotalDB.Text = gt.ToString();
        }

        private void cboSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSupplierName.Items.Count > 0 && cboSupplierName.Text != "")
            {
                int sID = Convert.ToInt32(cboSupplierName.SelectedValue.ToString());
                var dba = GenericQuery.SqlQuerySingle<IndomodaSupplier>("SELECT i.SupplierID, i.SupplierCode, i.SupplierName, i.SupplierAddress, i.SupplierPhone from IndomodaSuppliers i WHERE i.SupplierID = '" + sID + "'");
                lblSupplierCode.Text = dba.SupplierCode.ToString();
                lblSupplierAddress.Text = dba.SupplierAddress.ToString();
            }
        }
    }
}
