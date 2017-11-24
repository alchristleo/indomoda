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
    public partial class AddPenerimaanTukangPotong : MetroFramework.Forms.MetroForm
    {
        private BindingSource _bs = null;
        private Form _form = null;
        private DataGridView _dv = null;
        private List<ListPTPModel> _dpo = null;
        public List<ListPTPModel> list = new List<ListPTPModel>();

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

        public void setDPO(ref List<ListPTPModel> dpo)
        {
            _dpo = dpo;
        }

        public AddPenerimaanTukangPotong()
        {
            InitializeComponent();
        }

        private void AddPenerimaanTukangPotong_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                colorBindingSource.DataSource = db.Colors.ToList();
            }
        }

        private void btnExitAddPenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnSaveAddPenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNoSeriTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "No. Seri can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoSeriTukangPotong.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtModelTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Model can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModelTukangPotong.Focus();
                return;
            }
            else if (cboWarna.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select warna!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboWarna.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtMerkTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Merk can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMerkTukangPotong.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtUkuranTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Ukuran can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUkuranTukangPotong.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtQtyTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Quantity can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtyTukangPotong.Focus();
                return;
            }
            //else if (!IsDigitsOnly(txtQtyTukangPotong.Text))
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "Quantity must be numeric!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtQtyTukangPotong.Clear();
            //    txtQtyTukangPotong.Focus();
            //    return;
            //}
            using (indomodaEntities db = new indomodaEntities())
            {
                int setIDListPTP = db.ListPenerimaanTukangPotongs.AsEnumerable().LastOrDefault() == null ? 1 : db.ListPenerimaanTukangPotongs.AsEnumerable().LastOrDefault().idListPTP + 1;
                int getIDPTP = Convert.ToInt32(PenerimaanTukangPotong.idPenerimaanTukangPotong);
                string getNoSeri = txtNoSeriTukangPotong.Text;
                string getModel = txtModelTukangPotong.Text;
                int getColorID = Convert.ToInt32(cboWarna.SelectedValue.ToString());
                string getMerk = txtMerkTukangPotong.Text;
                string getUkuran = txtUkuranTukangPotong.Text;
                double getQty = Convert.ToDouble(txtQtyTukangPotong.Text.ToString());

                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to save this List penerimaan tukang potong to database?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int a = GenericQuery.ExecSQLCommand("INSERT INTO ListPenerimaanTukangPotong (idListPTP, idPenerimaanTukangPotong, noSeri, model, ColorID, merk, ukuran, quantity, statusSPKSablon, statusSPKBordir, statusSPKCMT, statusNoSeri, idSPKSablon, idSPKBordir, idSPKCMT) VALUES(@idListPTP, @idPenerimaanTukangPotong, @noSeri, @model, @ColorID, @merk, @ukuran, @quantity, @statusSPKSablon, @statusSPKBordir, @statusSPKCMT, @statusNoSeri, @idSPKSablon, @idSPKBordir, @idSPKCMT)", new[] {
                                new SqlParameter("@idListPTP", setIDListPTP),
                                new SqlParameter("@idPenerimaanTukangPotong", getIDPTP),
                                new SqlParameter("@noSeri", getNoSeri),
                                new SqlParameter("@model", getModel),
                                new SqlParameter("@ColorID", getColorID),
                                new SqlParameter("@merk", getMerk),
                                new SqlParameter("@ukuran", getUkuran),
                                new SqlParameter("@quantity", getQty),
                                new SqlParameter("@statusSPKSablon", false),
                                new SqlParameter("@statusSPKBordir", false),
                                new SqlParameter("@statusSPKCMT", false),
                                new SqlParameter("@statusNoSeri", ""),
                                new SqlParameter("@idSPKSablon", ""),
                                new SqlParameter("@idSPKBordir", ""),
                                new SqlParameter("@idSPKCMT", "")
                            });
                        db.SaveChangesAsync().Wait();

                        if (_bs == null)
                        {
                            _bs = new BindingSource();
                        }

                        _bs.Add(new ListPenerimaanTukangPotong
                        {
                            idListPTP = setIDListPTP,
                            idPenerimaanTukangPotong = getIDPTP,
                            noSeri = getNoSeri,
                            model = getModel,
                            ColorID = getColorID,
                            merk = getMerk,
                            ukuran = getUkuran,
                            quantity = getQty,
                            statusSPKSablon = null,
                            statusSPKBordir = null,
                            statusSPKCMT = null,
                            statusNoSeri = null,
                            idSPKSablon = null,
                            idSPKBordir = null,
                            idSPKCMT = null 
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
                        MetroFramework.MetroMessageBox.Show(this, "Success! This list penerimaan tukang potong has been added to database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.Close();
            }
        }
    }
}
