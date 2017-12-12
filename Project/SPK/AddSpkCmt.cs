﻿using Project.Helpers;
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
    public partial class AddSpkCmt : MetroFramework.Forms.MetroForm
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

        public AddSpkCmt()
        {
            InitializeComponent();
        }

        private void btnExitAddSpkCmt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddSpkCmt_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                colorBindingSource.DataSource = db.Colors.ToList();
                List<ListPenerimaanTukangPotong> listPTP = GenericQuery.SqlQuery<ListPenerimaanTukangPotong>("SELECT lp.idListPTP, lp.idPenerimaanTukangPotong, lp.noSeri, lp.model, lp.ColorID, lp.merk, lp.ukuran, lp.quantity, lp.statusSPKSablon, lp.statusSPKBordir, lp.statusSPKCMT, lp.statusNoSeri, lp.idSPKSablon, lp.idSPKBordir, lp.idSPKCMT  FROM ListPenerimaanTukangPotong lp WHERE lp.statusNoSeri  = '" + 0 + "' ORDER BY lp.statusSPKCMT ASC");
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

        private void btnSaveAddSpkCMT_Click(object sender, EventArgs e)
        {
            int currentIDPTP = Convert.ToInt32(dataGridView1[17, dataGridView1.CurrentRow.Index].Value.ToString());
            var dba = GenericQuery.SqlQuerySingle<ListPenerimaanTukangPotong>("SELECT lp.idListPTP, lp.idPenerimaanTukangPotong, lp.noSeri, lp.model, lp.ColorID, lp.merk, lp.ukuran, lp.quantity, lp.statusSPKSablon, lp.statusSPKBordir, lp.statusSPKCMT, lp.statusNoSeri, lp.idSPKSablon, lp.idSPKBordir, lp.idSPKCMT  FROM ListPenerimaanTukangPotong lp WHERE lp.idListPTP = '" + currentIDPTP + "'");
            if (String.IsNullOrEmpty(txtNoSeriCMT.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "No. Seri can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoSeriCMT.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtModelCMT.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Model can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModelCMT.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtMerkCMT.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Merk can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMerkCMT.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtUkuranCMT.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Ukuran can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUkuranCMT.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtQtyCMT.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Quantity can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtyCMT.Focus();
                return;
            }
            else if (dba.statusSPKCMT.ToString() == "True")
            {
                MetroFramework.MetroMessageBox.Show(this, "You can't add this No. Seri to the SPK Bordir again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.Focus();
                return;
            }
            else if (dba.statusSPKSablon.ToString() == "False" && dba.statusSPKBordir.ToString() == "False")
            {
                MetroFramework.MetroMessageBox.Show(this, "No. Seri ini belum dimasukkan ke dalam SPK Sablon maupun Bordir!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.Focus();
            }
            else
            {
                using (indomodaEntities db = new indomodaEntities())
                {
                    int getIDSPK = Convert.ToInt32(SPKCmt.idSPK);
                    bool setStatusCMT = true;
                    bool setStatusSablon = Convert.ToBoolean(dba.statusSPKSablon.ToString());
                    bool setStatusBordir = Convert.ToBoolean(dba.statusSPKBordir.ToString());
                    int setIDSPKSablon = Convert.ToInt32(dba.idSPKSablon.ToString());
                    int setIDSPKBordir = Convert.ToInt32(dba.idSPKBordir.ToString());
                    if (MetroFramework.MetroMessageBox.Show(this, "Do you want to update this List penerimaan tukang potong?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            int a = GenericQuery.ExecSQLCommand("UPDATE ListPenerimaanTukangPotong SET statusSPKCMT = @statusSPKCMT, idSPKCMT = @idSPKCMT WHERE idListPTP = '" + currentIDPTP + "'", new[] {
                                new SqlParameter("@statusSPKCMT", setStatusCMT),
                                new SqlParameter("@idSPKCMT", getIDSPK)
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
                                noSeri = txtNoSeriCMT.Text,
                                model = txtModelCMT.Text,
                                ColorID = Convert.ToInt32(cboCMTWarna.SelectedValue.ToString()),
                                merk = txtMerkCMT.Text,
                                ukuran = txtUkuranCMT.Text,
                                quantity = Convert.ToDouble(txtQtyCMT.Text.ToString()),
                                statusSPKSablon = setStatusSablon,
                                statusSPKBordir = setStatusBordir,
                                statusSPKCMT = setStatusCMT,
                                statusNoSeri = 0,
                                idSPKSablon = setIDSPKSablon,
                                idSPKBordir = setIDSPKBordir,
                                idSPKCMT = getIDSPK
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
                            MetroFramework.MetroMessageBox.Show(this, "Success! This list penerimaan tukang potong has been added to SPK CMT", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int currentIDPTP = Convert.ToInt32(dataGridView1[17, dataGridView1.CurrentRow.Index].Value.ToString());
                var db = GenericQuery.SqlQuerySingle<ListPenerimaanTukangPotong>("SELECT lp.idListPTP, lp.idPenerimaanTukangPotong, lp.noSeri, lp.model, lp.ColorID, lp.merk, lp.ukuran, lp.quantity, lp.statusSPKSablon, lp.statusSPKBordir, lp.statusSPKCMT, lp.statusNoSeri, lp.idSPKSablon, lp.idSPKBordir, lp.idSPKCMT  FROM ListPenerimaanTukangPotong lp WHERE lp.idListPTP = '" + currentIDPTP + "'");
                txtNoSeriCMT.Text = db.noSeri.ToString();
                txtNoPTP.Text = db.idPenerimaanTukangPotong.ToString();
                txtModelCMT.Text = db.model.ToString();
                txtMerkCMT.Text = db.merk.ToString();
                txtQtyCMT.Text = db.quantity.ToString();
                txtUkuranCMT.Text = db.ukuran.ToString();
                cboCMTWarna.SelectedValue = db.ColorID;
            }
        }
    }
}
