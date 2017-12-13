using Project.Helpers;
using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class AddPenjualanBaju : MetroFramework.Forms.MetroForm
    {
        private BindingSource _bs = null;
        private Form _form = null;
        private DataGridView _dv = null;
        private List<ListPenjualanBajuModel> _dpo = null;
        public List<ListPenjualanBajuModel> list = new List<ListPenjualanBajuModel>();

        public void setRefForm(Form form)
        {
            _form = form;
        }

        public void setBS(ref BindingSource bs)
        {
            _bs = bs;
        }

        public void setDGV(ref DataGridView dv)
        {
            _dv = dv;
        }

        public void setDPO(ref List<ListPenjualanBajuModel> dpo)
        {
            _dpo = dpo;
        }

        public AddPenjualanBaju()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string noSeri = txtNoSeri.Text.ToString();
            var dba = GenericQuery.SqlQuerySingle<ListBajuJadi>("SELECT a.idBJ, a.noSeri, a.model, a.ColorID, a.merk, a.ukuran, a.stock FROM ListBajuJadi a WHERE a.noSeri = '" + noSeri + "'");
            double currentStock = dba.stock;

            if (String.IsNullOrEmpty(txtNoSeri.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "No. Seri can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoSeri.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtModel.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Model can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModel.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtMerk.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Merk can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMerk.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtUkuran.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Ukuran can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUkuran.Focus();
                return;
            }
            else if (txtQtyInput.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must fill the quantity!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtyInput.Focus();
                return;
            }
            else if (Convert.ToDouble(txtQtyInput.Text.ToString()) > currentStock)
            {
                MetroFramework.MetroMessageBox.Show(this, "Quantity can't be greater than the current stock!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtyInput.Focus();
                return;
            }
            else if (txtHargaInput.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must fill the price!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtyInput.Focus();
                return;
            }

            using (indomodaEntities db = new indomodaEntities())
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to save this List penjualan baju to database?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int idLPB = db.ListPenjualanBajus.AsEnumerable().LastOrDefault() == null ? 1 : db.ListPenjualanBajus.AsEnumerable().LastOrDefault().idLPB + 1;
                        int idDPB = PenjualanBaju.id;
                        string merk = txtMerk.Text.ToString();
                        string model = txtModel.Text.ToString();
                        string ukuran = txtUkuran.Text.ToString();
                        int cID = Convert.ToInt32(cboWarna.SelectedValue.ToString());
                        double qtyLPB = Convert.ToDouble(txtQtyInput.Text.ToString());
                        decimal priceLPB = Convert.ToDecimal(txtHargaInput.Text.ToString());
                        decimal totalLPB = (decimal)qtyLPB * priceLPB;
                        bool statusLPB = false;
                        
                        int a = GenericQuery.ExecSQLCommand("INSERT INTO ListPenjualanBaju (idLPB, idDPB, noSeri, model, ColorID, merk, ukuran, qtyLPB, priceLPB, totalLPB, statusLPB) VALUES(@idLPB, @idDPB, @noSeri, @model, @ColorID, @merk, @ukuran, @qtyLPB, @priceLPB, @totalLPB, @statusLPB)", new[] {
                            new SqlParameter("@idLPB", idLPB),
                            new SqlParameter("@idDPB", idDPB),
                            new SqlParameter("@noSeri", noSeri),
                            new SqlParameter("@model", model),
                            new SqlParameter("@ColorID", cID),
                            new SqlParameter("@merk", merk),
                            new SqlParameter("@ukuran", ukuran),
                            new SqlParameter("@qtyLPB", qtyLPB),
                            new SqlParameter("@priceLPB", priceLPB),
                            new SqlParameter("@totalLPB", totalLPB),
                            new SqlParameter("@statusLPB", statusLPB)
                        });
                        db.SaveChangesAsync().Wait();

                        if (_bs == null)
                        {
                            _bs = new BindingSource();
                        }

                        _bs.Add(new ListPenjualanBaju
                        {
                            idLPB = idLPB,
                            idDPB = idDPB,
                            noSeri = noSeri,
                            merk = merk,
                            ColorID = cID,
                            model = model,
                            ukuran = ukuran,
                            qtyLPB = qtyLPB,
                            priceLPB = priceLPB,
                            totalLPB = totalLPB,
                            statusLPB = statusLPB
                        });
                        _dv.Refresh();

                        int rowCount = _dv.Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            _dv.Columns[0].ValueType = typeof(int);
                            _dv.Rows[i].Cells[0].Value = i + 1;
                            _dv.UpdateCellValue(0, i);
                        }
                        _dv.Refresh();
                        MetroFramework.MetroMessageBox.Show(this, "Success! New List penjualan baju has been added to database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                PenjualanBaju btnCount = (PenjualanBaju)Application.OpenForms["PenjualanBaju"];
                btnCount.btnCountGTPB.PerformClick();
                this.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int currentIDBJ = Convert.ToInt32(dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString());
                var db = GenericQuery.SqlQuerySingle<ListBajuJadi>("SELECT bj.idBJ, bj.noSeri, bj.model, bj.ColorID, bj.merk, bj.ukuran, bj.stock FROM ListBajuJadi bj WHERE bj.idBJ  = '" + currentIDBJ + "'");
                txtNoSeri.Text = db.noSeri.ToString();
                txtModel.Text = db.model.ToString();
                cboWarna.SelectedValue = db.ColorID;
                txtMerk.Text = db.merk.ToString();
                txtUkuran.Text = db.ukuran.ToString();
            }
        }

        private void AddPenjualanBaju_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                colorBindingSource.DataSource = db.Colors.ToList();
                List<ListBajuJadi> listBJ = GenericQuery.SqlQuery<ListBajuJadi>("SELECT bj.idBJ, bj.noSeri, bj.model, bj.ColorID, bj.merk, bj.ukuran, bj.stock FROM ListBajuJadi bj WHERE bj.stock  != '" + 0 + "'");
                listBajuJadiBindingSource.DataSource = listBJ.ToList();

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
    }
}
