using Project.Helpers;
using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class PenjualanBaju : MetroFramework.Forms.MetroForm
    {
        private BindingSource _bs = null;
        private DataGridView _dv = null;
        private Form _form = null;
        public static int id;
        private List<ListPenjualanBajuModel> _dpo = null;
        public List<ListPenjualanBajuModel> listLPB = new List<ListPenjualanBajuModel>();

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

        public void setDPO(List<ListPenjualanBajuModel> dpo)
        {
            _dpo = dpo;
        }

        public PenjualanBaju()
        {
            InitializeComponent();
        }

        private void cboCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomerName.Items.Count > 0 && cboCustomerName.Text != "")
            {
                int cID = Convert.ToInt32(cboCustomerName.SelectedValue.ToString());
                var dba = GenericQuery.SqlQuerySingle<Customer>("SELECT c.CustomerID, c.CustomerCode, c.CustomerName, c.CustomerAddress, c.CustomerPhone from Customers c WHERE c.CustomerID = '" + cID + "'");
                lblCustomerCode.Text = dba.CustomerCode.ToString();
                lblCustomerAddress.Text = dba.CustomerAddress.ToString();
            }
        }

        private void btnAddPB_Click(object sender, EventArgs e)
        {
            AddPenjualanBaju apb = new AddPenjualanBaju();
            apb.setDGV(ref dataGridView1);
            apb.setBS(ref listPenjualanBajuBindingSource);
            apb.Show();
        }

        private void btnEditPB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add list penjualan baju first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EditPenjualanBaju epb = new EditPenjualanBaju();
                int currentID = Convert.ToInt32(dataGridView1[10, dataGridView1.CurrentRow.Index].Value.ToString());

                listLPB = GenericQuery.SqlQuery<ListPenjualanBajuModel>("SELECT a.idLPB, a.idDPB, a.noSeri, a.qtyLPB, a.priceLPB, a.totalLPB, a.statusLPB, b.model, b.ColorID, b.merk, b.ukuran FROM ListPenjualanBaju a JOIN ListBajuJadi b ON a.noSeri = b.noSeri WHERE a.idLPB = '"+currentID+"'");
                epb.setDPO(ref listLPB);
                epb.setDGV(ref dataGridView1);
                epb.setBS(ref listPenjualanBajuBindingSource);
                epb.Show();
            }
        }

        private void btnDeletePB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add list penjualan baju first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            int currentID = Convert.ToInt32(dataGridView1[10, dataGridView1.CurrentRow.Index].Value.ToString());
                            int b = GenericQuery.ExecSQLCommand("DELETE FROM ListPenjualanBaju WHERE idLPB = '" + currentID + "'");
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
                            listPenjualanBajuBindingSource.EndEdit();

                            btnCountGTPB.PerformClick();

                            MetroFramework.MetroMessageBox.Show(this, "Success! This List penjualan baju has been deleted from database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnCountGTPB_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            decimal gt = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                gt = gt + decimal.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
            }
            lblGrandTotal.Text = String.Format(gt.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("id-ID")));
            lblGrandTotalDB.Text = gt.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNOTransaksi.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must fill no transaksi!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNOTransaksi.Focus();
                return;
            }
            else if (dataGridView1.RowCount == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "List penjualan baju is empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lblCustomerAddress.Text == "" && lblCustomerCode.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select customer name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCustomerName.Focus();
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to save this transaction to database?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (indomodaEntities db = new indomodaEntities())
                    {
                        try
                        {
                            int idDPB = db.DetailPenjualanBajus.AsEnumerable().LastOrDefault() == null ? 1 : db.DetailPenjualanBajus.AsEnumerable().LastOrDefault().idDPB + 1;
                            int cID = Convert.ToInt32(cboCustomerName.SelectedValue.ToString());
                            decimal setGTotal = Convert.ToDecimal(lblGrandTotalDB.Text.ToString());
                            int setStatus = 0;

                            int a = GenericQuery.ExecSQLCommand("INSERT INTO DetailPenjualanBaju (idDPB, noPenjualan, CustomerID, GrandTotal, Datetime, Status) VALUES(@idDPB, @noPenjualan, @CustomerID, @GrandTotal, @Datetime, @Status)", new[] {
                                new SqlParameter("@idDPB", idDPB),
                                new SqlParameter("@noPenjualan", txtNOTransaksi.Text),
                                new SqlParameter("@CustomerID", cID),
                                new SqlParameter("@GrandTotal", setGTotal),
                                new SqlParameter("@Datetime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                                new SqlParameter("@Status", setStatus)
                            });
                            db.SaveChangesAsync().Wait();

                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                string noSeri = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                var dba = GenericQuery.SqlQuerySingle<ListBajuJadi>("SELECT a.idBJ, a.noSeri, a.model, a.ColorID, a.merk, a.ukuran, a.stock FROM ListBajuJadi a WHERE a.noSeri = '" + noSeri + "'");
                                double stockKurang = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value.ToString());
                                double stockAwal = dba.stock;
                                double stockAkhir = stockAwal - stockKurang;
                                int idLPB = Convert.ToInt32(dataGridView1.Rows[i].Cells[10].Value.ToString());
                                bool statusLPB = true;

                                int b = GenericQuery.ExecSQLCommand("UPDATE ListBajuJadi SET stock = @stock WHERE noSeri = '"+noSeri+"'", new[] {
                                    new SqlParameter("@stock", stockAkhir)
                                });
                                db.SaveChangesAsync().Wait();

                                int c = GenericQuery.ExecSQLCommand("UPDATE ListPenjualanBaju SET statusLPB = @statusLPB WHERE idLPB = '" + idLPB + "'", new[] {
                                    new SqlParameter("@statusLPB", statusLPB)
                                });
                                db.SaveChangesAsync().Wait();
                            }

                            listPenjualanBajuBindingSource.EndEdit();

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

        private void PenjualanBaju_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                id = db.ListPenjualanBajus.AsEnumerable().LastOrDefault() == null ? 1 : db.ListPenjualanBajus.AsEnumerable().LastOrDefault().idDPB + 1;
                customerBindingSource.DataSource = db.Customers.ToList();
                colorBindingSource.DataSource = db.Colors.ToList();
            }

            dataGridView1.Columns[7].DefaultCellStyle.Format = "C";
            dataGridView1.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            dataGridView1.Columns[8].DefaultCellStyle.Format = "C";
            dataGridView1.Columns[8].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
        }
    }
}
