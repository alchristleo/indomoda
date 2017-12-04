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
    public partial class UpdateBordir : MetroFramework.Forms.MetroForm
    {
        private BindingSource _bs = null;
        private Form _form = null;
        private DataGridView _dv = null;
        private List<QuantityRecordPTPModel> _dpo = null;
        public List<QuantityRecordPTPModel> list = new List<QuantityRecordPTPModel>();

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

        public void setDPO(ref List<QuantityRecordPTPModel> dpo)
        {
            _dpo = dpo;
        }

        public UpdateBordir()
        {
            InitializeComponent();
        }

        private void btnExitUpdate_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (txtBarangHilang.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must fill barang hilang quantity first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBarangHilang.Focus();
            }
            else if (txtBarangBS.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must fill barang BS quantity first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBarangBS.Focus();
            }
            else
            {
                using (indomodaEntities db = new indomodaEntities())
                {
                    try
                    {
                        if (MetroFramework.MetroMessageBox.Show(this, "Do you want to update quantity list penerimaan tukang potong to database?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            double barangHilang = Convert.ToDouble(txtBarangHilang.Text.ToString());
                            double barangBS = Convert.ToDouble(txtBarangBS.Text.ToString());
                            string noSeri = txtNoSeri.Text;
                            double qtyAwal = Convert.ToDouble(txtQuantityAwal.Text);
                            double qtyAkhir = qtyAwal - (barangHilang + barangBS);
                            int a = GenericQuery.ExecSQLCommand("UPDATE QuantityRecord SET qtyAwalBordir = @qtyAwalBordir, qtyBordirBS = @qtyBordirBS, qtyBordirHilang = @qtyBordirHilang WHERE noSeri = '" + noSeri + "'", new[] {
                                new SqlParameter("@qtyAwalBordir", qtyAwal),
                                new SqlParameter("@qtyBordirBS", barangBS),
                                new SqlParameter("@qtyBordirHilang", barangHilang)
                            });
                            db.SaveChangesAsync().Wait();

                            string br = "bordir";
                            List<DetailPenerimaanSBC> tempList = GenericQuery.SqlQuery<DetailPenerimaanSBC>("SELECT p.idDetail, p.noPenerimaan, p.noSPK, p.noSeri, p.type, p.tempSablon, p.tempBordir, p.tempCMT FROM DetailPenerimaanSBC p WHERE p.noSeri = '" + noSeri + "' AND p.type = '"+br+"'");
                            if (tempList.Count < 1)
                            {
                                int idDetail = db.DetailPenerimaanSBCs.AsEnumerable().LastOrDefault() == null ? 1 : db.DetailPenerimaanSBCs.AsEnumerable().LastOrDefault().idDetail + 1;
                                string noSPK = PenerimaanBordir.CS;
                                string setType = "bordir";
                                int setStatusBordir = 1;
                                int temp = 0;
                                int b = GenericQuery.ExecSQLCommand("INSERT INTO DetailPenerimaanSBC (idDetail, noPenerimaan, noSPK, noSeri, type, tempSablon, tempBordir, tempCMT) VALUES(@idDetail, @noPenerimaan, @noSPK, @noSeri, @type, @tempSablon, @tempBordir, @tempCMT)", new[] {
                                    new SqlParameter("@idDetail", idDetail),
                                    new SqlParameter("@noPenerimaan", DBNull.Value),
                                    new SqlParameter("@noSPK", noSPK),
                                    new SqlParameter("@noSeri", noSeri),
                                    new SqlParameter("@type", setType),
                                    new SqlParameter("@tempSablon", temp),
                                    new SqlParameter("@tempBordir", setStatusBordir),
                                    new SqlParameter("@tempCMT", temp)
                                });
                                db.SaveChangesAsync().Wait();
                            }

                            int crIdx = PenerimaanBordir.CR;
                            _dv.Columns[7].ValueType = typeof(double);
                            _dv.Rows[crIdx].Cells[7].Value = barangHilang;
                            _dv.UpdateCellValue(7, crIdx);

                            _dv.Columns[8].ValueType = typeof(double);
                            _dv.Rows[crIdx].Cells[8].Value = barangBS;
                            _dv.UpdateCellValue(8, crIdx);

                            _dv.Columns[9].ValueType = typeof(double);
                            _dv.Rows[crIdx].Cells[9].Value = qtyAkhir;
                            _dv.UpdateCellValue(9, crIdx);

                            _dv.Refresh();

                            int rowCount = _dv.Rows.Count;
                            for (int i = 0; i < rowCount; i++)
                            {
                                _dv.Columns[0].ValueType = typeof(int);
                                _dv.Rows[i].Cells[0].Value = i + 1;
                                _dv.UpdateCellValue(0, i);
                            }
                            _dv.Refresh();

                            MetroFramework.MetroMessageBox.Show(this, "Success! Quantity for this list has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.Close();
            }
        }

        private void UpdateBordir_Load(object sender, EventArgs e)
        {
            list = _dpo;

            if (list != null && list.Count > 0)
            {
                txtNoSeri.Text = list[0].noSeri;
                var dba = GenericQuery.SqlQuerySingle<QuantityRecord>("SELECT qr.id, qr.noSeri, qr.qtyAwalSablon, qr.qtySablonBS, qr.qtySablonHilang, qr.qtyAwalBordir, qr.qtyBordirBS, qr.qtyBordirHilang, qr.qtyAwalCMT, qr.qtyCMTBS, qr.qtyCMTHilang FROM QuantityRecord qr WHERE qr.noSeri = '" + txtNoSeri.Text + "'");
                if (dba.qtyBordirHilang != null && dba.qtyBordirBS != null)
                {
                    txtQuantityAwal.Text = dba.qtyAwalSablon.ToString();
                }
                else
                {
                    txtQuantityAwal.Text = list[0].quantity.ToString();
                }
                if (list[0].qtyBordirHilang != null) { txtBarangHilang.Text = list[0].qtyBordirHilang.ToString(); }
                if (list[0].qtyBordirBS != null) { txtBarangBS.Text = list[0].qtyBordirBS.ToString(); }
            }
            txtBarangHilang.Focus();
        }
    }
}
