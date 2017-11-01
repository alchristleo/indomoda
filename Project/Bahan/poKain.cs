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

namespace Project
{
    public partial class poKain : MetroFramework.Forms.MetroForm
    {
        indomodaEntities db;

        private BindingSource _bs = null;
        private DataGridView _dv = null;
        private Form _form = null;
        public static string poNumber;

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
                MetroFramework.MetroMessageBox.Show(this, "You need to add detail PO first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int currentPOID = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());

            //DetailPO obj = detailPOBindingSource.Current as DetailPO;
            //if (obj != null)
            //{
            //    using (AddPOKain editPO = new AddPOKain(obj))
            //    {
            //        if (editPO.ShowDialog() == DialogResult.OK)
            //        {
            //            try
            //            {
            //                detailPOBindingSource.EndEdit();
            //                db.SaveChangesAsync();
            //            }
            //            catch (Exception ex)
            //            {
            //                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }
            //}
        }

        private void btnDeletePoKain_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add detail PO first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            int currentPOID = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                            int b = GenericQuery.ExecSQLCommand("DELETE FROM DetailPO WHERE DetailPOID = '"+currentPOID+"'");
                            db.SaveChangesAsync().Wait();
                            dataGridView1.Rows.RemoveAt(currentRow);
                            dataGridView1.Refresh();
                            bindingSourcePreOrderKain.EndEdit();

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

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                lblGrandTotal.Text = CellSum().ToString();
            }
        }

        private double CellSum()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                double d = 0;
                Double.TryParse(dataGridView1.Rows[i].Cells[6].Value.ToString(), out d);
                sum += d;
            }
            return sum;
        }

        private int CalculateTotal()
        {
            int total = 0;
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum = sum + int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
            }
            return sum;
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
            lblGrandTotal.Text = CellSum().ToString();
        }

        private void btnSavePoKain_Click(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                if (dataGridView1.RowCount == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "You need to add detail PO first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Do you want to save this transaction to database?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            int setPOID = db.PreOrderKains.AsEnumerable().LastOrDefault() == null ? 1 : db.PreOrderKains.AsEnumerable().LastOrDefault().idPOKain + 1;
                            int SupplierID = Convert.ToInt32(cboSupplierCode.SelectedValue.ToString());
                            int a = GenericQuery.ExecSQLCommand("INSERT INTO PreOrderKains (idPOKain, PONumber, SupplierID, GrandTotal, Date_time) VALUES(@idPOKain, @PONumber, @SupplierID, @GrandTotal, @Date_time)", new[] {
                                new SqlParameter("@idPOKain", setPOID),
                                new SqlParameter("@PONumber", lblPONumber.Text),
                                new SqlParameter("@SupplierID", SupplierID),
                                new SqlParameter("@GrandTotal", lblGrandTotalDB.Text),
                                new SqlParameter("@Date_time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
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

        private void dataGridView1_RowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int grandTotal = CalculateTotal();
                lblGrandTotalDB.Text = grandTotal.ToString();
                lblGrandTotal.Text = String.Format(grandTotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("id-ID")));
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int grandTotal = CalculateTotal();
                lblGrandTotalDB.Text = grandTotal.ToString();
                lblGrandTotal.Text = String.Format(grandTotal.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("id-ID")));
            }
        }
    }
}
