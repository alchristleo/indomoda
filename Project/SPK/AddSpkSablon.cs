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
    public partial class AddSpkSablon : MetroFramework.Forms.MetroForm
    {
        private BindingSource _bs = null;
        private Form _form = null;
        private DataGridView _dv = null;
        private List<DetailSPKModel> _dpo = null;
        public List<DetailSPKModel> list = new List<DetailSPKModel>();

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

        public void setDPO(ref List<DetailSPKModel> dpo)
        {
            _dpo = dpo;
        }

        public AddSpkSablon()
        {
            InitializeComponent();
        }

        private void btnExitAddSpkSablon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveAddSpkSablon_Click(object sender, EventArgs e)
        {
            int currentIDPTP = Convert.ToInt32(dataGridView1[17, dataGridView1.CurrentRow.Index].Value.ToString());
            var dba = GenericQuery.SqlQuerySingle<ListPenerimaanTukangPotong>("SELECT lp.idListPTP, lp.idPenerimaanTukangPotong, lp.noSeri, lp.model, lp.ColorID, lp.merk, lp.ukuran, lp.quantity, lp.statusSPKSablon, lp.statusSPKBordir, lp.statusSPKCMT, lp.statusNoSeri, lp.idSPKSablon, lp.idSPKBordir, lp.idSPKCMT  FROM ListPenerimaanTukangPotong lp WHERE lp.idListPTP = '" + currentIDPTP + "'");
            if (String.IsNullOrEmpty(txtNoSeriSablon.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "No. Seri can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoSeriSablon.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtModelSablon.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Model can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModelSablon.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtMerkSablon.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Merk can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMerkSablon.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtUkuranSablon.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Ukuran can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUkuranSablon.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtQtySablon.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Quantity can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtySablon.Focus();
                return;
            }
            else if (dba.statusSPKSablon.ToString() == "True")
            {
                MetroFramework.MetroMessageBox.Show(this, "You can't add this List penerimaan tukang potong to the SPK Sablon again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.Focus();
                return;
            }
            using (indomodaEntities db = new indomodaEntities())
            {
                int getIDSPK = Convert.ToInt32(SPKSablon.idSPK);
                bool setStatusSablon = true;
                bool setStatusBordir = Convert.ToBoolean(dba.statusSPKBordir.ToString());
                bool setStatusCMT = Convert.ToBoolean(dba.statusSPKCMT.ToString());
                int setIDSPKBordir = Convert.ToInt32(dba.idSPKBordir.ToString());
                int setIDSPKCMT = Convert.ToInt32(dba.idSPKCMT.ToString());
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to update this List penerimaan tukang potong?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int a = GenericQuery.ExecSQLCommand("UPDATE ListPenerimaanTukangPotong SET statusSPKSablon = @statusSPKSablon, idSPKSablon = @idSPKSablon WHERE idListPTP = '" + currentIDPTP + "'", new[] {
                                new SqlParameter("@statusSPKSablon", setStatusSablon),
                                new SqlParameter("@idSPKSablon", getIDSPK)
                            });
                        db.SaveChangesAsync().Wait();

                        if (_bs == null)
                        {
                            _bs = new BindingSource();
                        }

                        _bs.Add(new ListPenerimaanTukangPotong
                        {
                            idListPTP = currentIDPTP,
                            idPenerimaanTukangPotong = Convert.ToInt32(txtNoPTP.Text.ToString()),
                            noSeri = txtNoSeriSablon.Text,
                            model = txtModelSablon.Text,
                            ColorID = Convert.ToInt32(cboSablonWarna.SelectedValue.ToString()),
                            merk = txtMerkSablon.Text,
                            ukuran = txtUkuranSablon.Text,
                            quantity = Convert.ToDouble(txtQtySablon.Text.ToString()),
                            statusSPKSablon = setStatusSablon,
                            statusSPKBordir = setStatusBordir,
                            statusSPKCMT = setStatusCMT,
                            statusNoSeri = 0,
                            idSPKSablon = getIDSPK,
                            idSPKBordir = setIDSPKBordir,
                            idSPKCMT = setIDSPKCMT
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
                        MetroFramework.MetroMessageBox.Show(this, "Success! This list penerimaan tukang potong has been added to SPK Sablon", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.Close();
            }
        }

        private void AddSpkSablon_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                colorBindingSource.DataSource = db.Colors.ToList();
                List<ListPenerimaanTukangPotong> listPTP = GenericQuery.SqlQuery<ListPenerimaanTukangPotong>("SELECT lp.idListPTP, lp.idPenerimaanTukangPotong, lp.noSeri, lp.model, lp.ColorID, lp.merk, lp.ukuran, lp.quantity, lp.statusSPKSablon, lp.statusSPKBordir, lp.statusSPKCMT, lp.statusNoSeri, lp.idSPKSablon, lp.idSPKBordir, lp.idSPKCMT  FROM ListPenerimaanTukangPotong lp WHERE lp.statusNoSeri  = '" + 0 + "' ORDER BY lp.statusSPKSablon ASC");
                listPenerimaanTukangPotongBindingSource.DataSource = listPTP.ToList();

                int rowCount = dataGridView1.Rows.Count;
                for (int i = 0; i < rowCount; i++)
                {
                    string sablon = dataGridView1.Rows[i].Cells[10].Value.ToString();
                    string bordir = dataGridView1.Rows[i].Cells[11].Value.ToString();
                    string cmt = dataGridView1.Rows[i].Cells[12].Value.ToString();

                    if (sablon == "True")
                    {
                        dataGridView1.Columns[7].ValueType = typeof(String);
                        dataGridView1.Rows[i].Cells[7].Value = "Sudah di sablon";
                        dataGridView1.UpdateCellValue(7, i);
                    }
                    else
                    {

                        dataGridView1.Columns[7].ValueType = typeof(String);
                        dataGridView1.Rows[i].Cells[7].Value = "-";
                        dataGridView1.UpdateCellValue(7, i);
                    }

                    if (bordir == "True")
                    {
                        dataGridView1.Columns[8].ValueType = typeof(String);
                        dataGridView1.Rows[i].Cells[8].Value = "Sudah di bordir";
                        dataGridView1.UpdateCellValue(8, i);
                    }
                    else
                    {

                        dataGridView1.Columns[8].ValueType = typeof(String);
                        dataGridView1.Rows[i].Cells[8].Value = "-";
                        dataGridView1.UpdateCellValue(8, i);
                    }

                    if (cmt == "True")
                    {
                        dataGridView1.Columns[9].ValueType = typeof(String);
                        dataGridView1.Rows[i].Cells[9].Value = "Sudah di CMT";
                        dataGridView1.UpdateCellValue(9, i);
                    }
                    else
                    {

                        dataGridView1.Columns[9].ValueType = typeof(String);
                        dataGridView1.Rows[i].Cells[9].Value = "-";
                        dataGridView1.UpdateCellValue(9, i);
                    }

                    dataGridView1.Columns[0].ValueType = typeof(int);
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.UpdateCellValue(0, i);
                }
                dataGridView1.Refresh();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int currentIDPTP = Convert.ToInt32(dataGridView1[17, dataGridView1.CurrentRow.Index].Value.ToString());
                var db = GenericQuery.SqlQuerySingle<ListPenerimaanTukangPotong>("SELECT lp.idListPTP, lp.idPenerimaanTukangPotong, lp.noSeri, lp.model, lp.ColorID, lp.merk, lp.ukuran, lp.quantity, lp.statusSPKSablon, lp.statusSPKBordir, lp.statusSPKCMT, lp.statusNoSeri, lp.idSPKSablon, lp.idSPKBordir, lp.idSPKCMT  FROM ListPenerimaanTukangPotong lp WHERE lp.idListPTP = '" + currentIDPTP + "'");
                txtNoSeriSablon.Text = db.noSeri.ToString();
                txtNoPTP.Text = db.idPenerimaanTukangPotong.ToString();
                txtModelSablon.Text = db.model.ToString();
                txtMerkSablon.Text = db.merk.ToString();
                txtQtySablon.Text = db.quantity.ToString();
                txtUkuranSablon.Text = db.ukuran.ToString();
                cboSablonWarna.SelectedValue = db.ColorID;
            }
        }
    }
}
