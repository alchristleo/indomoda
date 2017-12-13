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
    public partial class EditPenjualanBaju : MetroFramework.Forms.MetroForm
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

        public EditPenjualanBaju()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string noSeri = list[0].noSeri;
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
            else if (txtQtyEdit.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must fill the quantity!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtyEdit.Focus();
                return;
            }
            else if (Convert.ToDouble(txtQtyEdit.Text) > currentStock)
            {
                MetroFramework.MetroMessageBox.Show(this, "Quantity can't be greater than current stock!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtyEdit.Focus();
                return;
            }
            else if (txtHargaEdit.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must fill the price!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHargaEdit.Focus();
                return;
            }

            using (indomodaEntities db = new indomodaEntities())
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to update this List baju jadi to database?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int cID = list[0].ColorID;
                        string model = list[0].model;
                        string merk = list[0].merk;
                        string ukuran = list[0].ukuran;
                        double qtyLPB = Convert.ToDouble(txtQtyEdit.Text.ToString());
                        decimal priceLPB = Convert.ToDecimal(txtHargaEdit.Text.ToString());
                        decimal totalLPB = (decimal)qtyLPB * priceLPB;
                        bool statusLPB = list[0].statusLPB;
                        int a = GenericQuery.ExecSQLCommand("UPDATE ListPenjualanBaju SET qtyLPB = @qtyLPB, priceLPB = @priceLPB, totalLPB = @totalLPB WHERE idLPB = '"+txtIDLPB.Text+"'", new[] {
                            new SqlParameter("@qtyLPB", qtyLPB),
                            new SqlParameter("@priceLPB", priceLPB),
                            new SqlParameter("@totalLPB", totalLPB)
                        });
                        db.SaveChangesAsync().Wait();

                        if (_bs == null)
                        {
                            _bs = new BindingSource();
                        }

                        foreach (var i in _bs.List.Cast<ListPenjualanBaju>().Where(x => x.idLPB == Convert.ToInt32(txtIDLPB.Text)))
                        {
                            i.qtyLPB = qtyLPB;
                            i.priceLPB = priceLPB;
                            i.totalLPB = totalLPB;
                        }
                        _dv.DataSource = _bs;
                        _dv.EndEdit();
                        _dv.Refresh();

                        int rowCount = _dv.Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            _dv.Columns[0].ValueType = typeof(int);
                            _dv.Rows[i].Cells[0].Value = i + 1;
                            _dv.UpdateCellValue(0, i);
                        }
                        _dv.Refresh();
                        MetroFramework.MetroMessageBox.Show(this, "Success! This list penjualan baju has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
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

        private void EditPenjualanBaju_Load(object sender, EventArgs e)
        {
            using (indomodaEntities entity = new indomodaEntities())
            {
                colorBindingSource.DataSource = entity.Colors.ToList();
            }

            list = _dpo;

            if (list != null && list.Count > 0)
            {
                cboWarna.SelectedValue = list[0].ColorID;
                txtNoSeri.Text = list[0].noSeri;
                txtModel.Text = list[0].model;
                txtMerk.Text = list[0].merk;
                txtUkuran.Text = list[0].ukuran;
                txtQtyEdit.Text = list[0].qtyLPB.ToString();
                txtHargaEdit.Text = list[0].priceLPB.ToString();
                txtIDLPB.Text = list[0].idLPB.ToString();
            }

            txtQtyEdit.Focus();
        }
    }
}
