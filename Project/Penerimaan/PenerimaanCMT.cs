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
    public partial class PenerimaanCMT : MetroFramework.Forms.MetroForm
    {
        public static int CR;
        public static string CS;
        private BindingSource _bs = null;
        private DataGridView _dv = null;
        private Form _form = null;
        private List<QuantityRecordPTPModel> _dpo = null;
        public List<QuantityRecordPTPModel> listPTPQR = new List<QuantityRecordPTPModel>();

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

        public void setDPO(List<QuantityRecordPTPModel> dpo)
        {
            _dpo = dpo;
        }

        public PenerimaanCMT()
        {
            InitializeComponent();
        }

        private void btnUpdateStatusPemotongan_Click(object sender, EventArgs e)
        {
            string f = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            var dbb =  GenericQuery.SqlQuerySingle<QuantityRecord>("SELECT qr.id, qr.noSeri, qr.qtyAwalSablon, qr.qtySablonBS, qr.qtySablonHilang, qr.qtyAwalBordir, qr.qtyBordirBS, qr.qtyBordirHilang, qr.qtyAwalCMT, qr.qtyCMTBS, qr.qtyCMTHilang FROM QuantityRecord qr WHERE qr.noSeri = '" + f + "'");

            if (dataGridView1.Rows.Count < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "List No. Seri is empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dbb.qtyAwalSablon == null && dbb.qtyAwalBordir == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "No. Seri ini belum dimasukkan kedalam Penerimaan Sablon maupun Bordir!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idSPK = Convert.ToInt32(cboNoSpkCMTPenerimaan.SelectedValue.ToString());
                var dba = GenericQuery.SqlQuerySingle<DetailSPK>("SELECT sp.idSPK, sp.noSPK, sp.EmployeeID, sp.Datetime, sp.type, sp.status FROM DetailSPK sp WHERE sp.idSPK = '" + idSPK + "'");
                string noSPK = dba.noSPK;
                CS = noSPK;
                CR = dataGridView1.CurrentRow.Index;
                UpdateCMT uq = new UpdateCMT();
                int currentIDPTP = Convert.ToInt32(dataGridView1[17, dataGridView1.CurrentRow.Index].Value.ToString());
                listPTPQR = GenericQuery.SqlQuery<QuantityRecordPTPModel>("SELECT df.idListPTP, df.idPenerimaanTukangPotong, df.noSeri, df.model, df.ColorID, df.merk, df.ukuran, df.quantity, df.statusSPKSablon, df.statusSPKBordir, df.statusSPKCMT, df.statusNoSeri, df.idSPKSablon, df.idSPKBordir, df.idSPKCMT, qr.id, qr.qtyAwalSablon, qr.qtySablonBS, qr.qtySablonHilang, qr.qtyAwalBordir, qr.qtyBordirBS, qr.qtyBordirHilang, qr.qtyAwalCMT, qr.qtyCMTBS, qr.qtyCMTHilang FROM ListPenerimaanTukangPotong df JOIN QuantityRecord qr on df.noSeri = qr.noSeri WHERE df.idListPTP = '" + currentIDPTP + "'");
                uq.setDPO(ref listPTPQR);
                uq.setDGV(ref dataGridView1);
                uq.setBS(ref listPenerimaanTukangPotongBindingSource);
                uq.Show();
            }
        }

        private void btnResetPenerimaanCMT_Click(object sender, EventArgs e)
        {
            string noSeri = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            var dba = GenericQuery.SqlQuerySingle<QuantityRecord>("SELECT qr.id, qr.noSeri, qr.qtyAwalSablon, qr.qtySablonBS, qr.qtySablonHilang, qr.qtyAwalBordir, qr.qtyBordirBS, qr.qtyBordirHilang, qr.qtyAwalCMT, qr.qtyCMTBS, qr.qtyCMTHilang FROM QuantityRecord qr WHERE qr.noSeri = '" + noSeri + "'");

            if (dataGridView1.Rows.Count < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "List penerimaan tukang potong is empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridView1.Rows.Count > 0 && (dba.qtyCMTBS == null && dba.qtyCMTHilang == null))
            {
                MetroFramework.MetroMessageBox.Show(this, "You can't reset this quantity, quantity havent been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to reset this quantity?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    using (indomodaEntities db = new indomodaEntities())
                    {
                        try
                        {
                            int currentIDPTP = Convert.ToInt32(dataGridView1[17, dataGridView1.CurrentRow.Index].Value.ToString());
                            int a = GenericQuery.ExecSQLCommand("UPDATE QuantityRecord SET qtyAwalCMT = @qtyAwalCMT, qtyCMTBS = @qtyCMTBS, qtyCMTHilang = @qtyCMTHilang WHERE noSeri = '" + noSeri + "'", new[] {
                                new SqlParameter("@qtyAwalCMT", DBNull.Value),
                                new SqlParameter("@qtyCMTBS", DBNull.Value),
                                new SqlParameter("@qtyCMTHilang", DBNull.Value)
                            });
                            db.SaveChangesAsync().Wait();

                            double quantity = Convert.ToDouble(dba.qtyAwalCMT.ToString());
                            int b = GenericQuery.ExecSQLCommand("UPDATE ListPenerimaanTukangPotong SET quantity = @quantity WHERE noSeri = '" + noSeri + "'", new[] {
                                new SqlParameter("@quantity", quantity)
                            });
                            db.SaveChangesAsync().Wait();

                            string setType = "cmt";
                            int c = GenericQuery.ExecSQLCommand("DELETE FROM DetailPenerimaanSBC WHERE noSeri = '" + noSeri + "' AND type = '" + setType + "'");
                            db.SaveChangesAsync().Wait();

                            dataGridView1.Refresh();
                            dataGridView1.Columns[7].ValueType = typeof(string);
                            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value = "-";
                            dataGridView1.UpdateCellValue(7, dataGridView1.CurrentRow.Index);

                            dataGridView1.Columns[8].ValueType = typeof(string);
                            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value = "-";
                            dataGridView1.UpdateCellValue(8, dataGridView1.CurrentRow.Index);

                            dataGridView1.Columns[9].ValueType = typeof(string);
                            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value = "-";
                            dataGridView1.UpdateCellValue(9, dataGridView1.CurrentRow.Index);
                            dataGridView1.Refresh();
                            MetroFramework.MetroMessageBox.Show(this, "Success! This quantity has been reset", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnExitPenerimaanCMT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSavePenerimaanCMT_Click(object sender, EventArgs e)
        {
            if (txtNoPenerimaanCMT.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must fill no penerimaan CMT first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoPenerimaanCMT.Focus();
            }
            else if (txtPICCodePenerimaan.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select PIC penerimaan CMT first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPicPenerimaanCMT.Focus();
            }
            else if (cboNoSpkCMTPenerimaan.Items.Count < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "List no SPK CMT is empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to save this data to database?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (indomodaEntities db = new indomodaEntities())
                    {
                        try
                        {
                            int count = 0;
                            int idSPK = Convert.ToInt32(cboNoSpkCMTPenerimaan.SelectedValue.ToString());
                            var dba = GenericQuery.SqlQuerySingle<DetailSPK>("SELECT sp.idSPK, sp.noSPK, sp.EmployeeID, sp.Datetime, sp.type, sp.status FROM DetailSPK sp WHERE sp.idSPK = '" + idSPK + "'");
                            string noSPK = dba.noSPK;
                            string setType = "cmt";
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                var x = dataGridView1.Rows[i].Cells[9].Value.ToString();
                                string noSeri = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                int idDetail = db.DetailPenerimaanSBCs.AsEnumerable().LastOrDefault() == null ? 1 : db.DetailPenerimaanSBCs.AsEnumerable().LastOrDefault().idDetail + 1;
                                int newTempCMT = 2;

                                if (x != "-")
                                {
                                    var dbb = GenericQuery.SqlQuerySingle<ListPenerimaanTukangPotong>("SELECT lp.idListPTP, lp.idPenerimaanTukangPotong, lp.noSeri, lp.model, lp.ColorID, lp.merk, lp.ukuran, lp.quantity, lp.statusSPKSablon, lp.statusSPKBordir, lp.statusSPKCMT, lp.statusNoSeri, lp.idSPKSablon, lp.idSPKBordir, lp.idSPKCMT  FROM ListPenerimaanTukangPotong lp WHERE lp.noSeri = '" + noSeri + "'");
                                    var z = dbb.quantity.ToString();
                                    double qtyUpdate = Convert.ToDouble(x);

                                    if (x != z)
                                    {
                                        int statusNoSeri = 1;
                                        int a = GenericQuery.ExecSQLCommand("UPDATE ListPenerimaanTukangPotong SET quantity = @quantity, statusNoSeri = @statusNoSeri WHERE noSeri = '" + noSeri + "'", new[] {
                                            new SqlParameter("@quantity", qtyUpdate),
                                            new SqlParameter("@statusNoSeri", statusNoSeri)
                                        });
                                        db.SaveChangesAsync().Wait();

                                        int idBJ = db.ListBajuJadis.AsEnumerable().LastOrDefault() == null ? 1 : db.ListBajuJadis.AsEnumerable().LastOrDefault().idBJ + 1;
                                        string ns = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                        string model = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                        int colorID = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());
                                        //var dbe = GenericQuery.SqlQuerySingle<Color>("SELECT c.ColorID, c.ColorCode, c.ColorName FROM Colors c WHERE c.ColorName = '"+colorName+"'");
                                        //int colorID = dbe.ColorID;
                                        string merk = dataGridView1.Rows[i].Cells[4].Value.ToString();
                                        string ukuran = dataGridView1.Rows[i].Cells[5].Value.ToString();
                                        int f = GenericQuery.ExecSQLCommand("INSERT  INTO ListBajuJadi (idBJ, noSeri, model, ColorID, merk, ukuran, stock) VALUES(@idBJ, @noSeri, @model, @ColorID, @merk, @ukuran, @stock)", new[]{
                                            new SqlParameter("@idBJ", idBJ),
                                            new SqlParameter("@noSeri", ns),
                                            new SqlParameter("@model", model),
                                            new SqlParameter("@ColorID", colorID),
                                            new SqlParameter("@merk", merk),
                                            new SqlParameter("@ukuran", ukuran),
                                            new SqlParameter("@stock", x)
                                        });
                                        db.SaveChangesAsync().Wait();
                                    }

                                    List<DetailPenerimaanSBC> tempList = GenericQuery.SqlQuery<DetailPenerimaanSBC>("SELECT p.idDetail, p.noPenerimaan, p.noSPK, p.noSeri, p.type, p.tempSablon, p.tempBordir, p.tempCMT FROM DetailPenerimaanSBC p WHERE p.noSeri = '" + noSeri + "' AND p.type = '" + setType + "' AND p.tempCMT = '" + 1 + "'");
                                    if (tempList.Count != 0)
                                    {
                                        int b = GenericQuery.ExecSQLCommand("UPDATE DetailPenerimaanSBC SET noPenerimaan = @noPenerimaan, tempCMT = @tempCMT WHERE noSeri = '" + noSeri + "' AND type = '" + setType + "'", new[] {
                                            new SqlParameter("@noPenerimaan", txtNoPenerimaanCMT.Text),
                                            new SqlParameter("@tempCMT", newTempCMT)
                                        });
                                        db.SaveChangesAsync().Wait();
                                    }
                                    count++;
                                }
                            }

                            if (count == dataGridView1.Rows.Count)
                            {
                                int setStatusSPK = 1;
                                string type = "cmt";
                                int c = GenericQuery.ExecSQLCommand("UPDATE DetailSPK SET status = @status WHERE idSPK = '" + Convert.ToInt32(cboNoSpkCMTPenerimaan.SelectedValue.ToString()) + "'", new[] {
                                        new SqlParameter("@status", setStatusSPK)
                                    });
                                db.SaveChangesAsync().Wait();

                                List<DetailSPK> cboPK = GenericQuery.SqlQuery<DetailSPK>("select sp.idSPK, sp.noSPK, sp.EmployeeID, sp.Datetime, sp.type, sp.status FROM DetailSPK sp WHERE sp.type = '" + type + "' AND sp.status = '" + 0 + "'");
                                cboPK.Remove(new DetailSPK { idSPK = Convert.ToInt32(cboNoSpkCMTPenerimaan.SelectedValue.ToString()) });
                                detailSPKBindingSource.DataSource = cboPK.ToList();
                            }

                            int idPS = db.PenerimaanSBCs.AsEnumerable().LastOrDefault() == null ? 1 : db.PenerimaanSBCs.AsEnumerable().LastOrDefault().id + 1;
                            string noPS = txtNoPenerimaanCMT.Text;
                            int eID = Convert.ToInt32(cboNoSpkCMTPenerimaan.SelectedValue.ToString());
                            int status = 0;
                            int d = GenericQuery.ExecSQLCommand("INSERT INTO PenerimaanSBC (id, noPenerimaan, noSPK, EmployeeID, Datetime, type, status) VALUES(@id, @noPenerimaan, @noSPK, @EmployeeID, @Datetime, @type, @status)", new[]{
                                new SqlParameter("@id", idPS),
                                new SqlParameter("@noPenerimaan", noPS),
                                new SqlParameter("@noSPK", noSPK),
                                new SqlParameter("@EmployeeID", eID),
                                new SqlParameter("@Datetime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                                new SqlParameter("@type", setType),
                                new SqlParameter("@status", status)
                            });
                            db.SaveChangesAsync().Wait();

                            dataGridView1.Rows.Clear();
                            txtNoPenerimaanCMT.Clear();
                            txtPICCodePenerimaan.Clear();
                            dataGridView1.Refresh();
                            MetroFramework.MetroMessageBox.Show(this, "Success! Penerimaan CMT for this data has been created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void PenerimaanBordir_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                string type = "bordir";
                employeeBindingSource.DataSource = db.Employees.ToList();
                colorBindingSource.DataSource = db.Colors.ToList();
                List<DetailSPK> cboPK = GenericQuery.SqlQuery<DetailSPK>("select sp.idSPK, sp.noSPK, sp.EmployeeID, sp.Datetime, sp.type, sp.status FROM DetailSPK sp WHERE sp.type = '" + type + "' AND sp.status = '" + 0 + "'");
                detailSPKBindingSource.DataSource = cboPK.ToList();
            }
        }

        private void PenerimaanCMT_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                string type = "cmt";
                employeeBindingSource.DataSource = db.Employees.ToList();
                colorBindingSource.DataSource = db.Colors.ToList();
                List<DetailSPK> cboPK = GenericQuery.SqlQuery<DetailSPK>("select sp.idSPK, sp.noSPK, sp.EmployeeID, sp.Datetime, sp.type, sp.status FROM DetailSPK sp WHERE sp.type = '" + type + "' AND sp.status = '" + 0 + "'");
                detailSPKBindingSource.DataSource = cboPK.ToList();
            }
        }

        private void cboNoSpkCMTPenerimaan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNoSpkCMTPenerimaan.Items.Count > 0 && cboNoSpkCMTPenerimaan.Text != "")
            {
                cboNoSpkCMTPenerimaan.Refresh();
                int idSPK = Convert.ToInt32(cboNoSpkCMTPenerimaan.SelectedValue.ToString());
                List<QuantityRecordPTPModel> listPTP = GenericQuery.SqlQuery<QuantityRecordPTPModel>("SELECT df.idListPTP, df.idPenerimaanTukangPotong, df.noSeri, df.model, df.ColorID, df.merk, df.ukuran, df.quantity, df.statusSPKSablon, df.statusSPKBordir, df.statusSPKCMT, df.statusNoSeri, df.idSPKSablon, df.idSPKBordir, df.idSPKCMT, qr.id, qr.qtyAwalSablon, qr.qtySablonBS, qr.qtySablonHilang, qr.qtyAwalBordir, qr.qtyBordirBS, qr.qtyBordirHilang, qr.qtyAwalCMT, qr.qtyCMTBS, qr.qtyCMTHilang FROM ListPenerimaanTukangPotong df JOIN QuantityRecord qr on df.noSeri = qr.noSeri WHERE df.idSPKCMT = '" + idSPK + "' AND df.statusNoSeri = '" + 0 + "'");
                listPenerimaanTukangPotongBindingSource.DataSource = listPTP.ToList();

                int rowCount = dataGridView1.Rows.Count;
                for (int i = 0; i < rowCount; i++)
                {
                    string sablon = dataGridView1.Rows[i].Cells[13].Value.ToString();
                    string bordir = dataGridView1.Rows[i].Cells[14].Value.ToString();
                    string cmt = dataGridView1.Rows[i].Cells[15].Value.ToString();
                    string noSeri = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    var dba = GenericQuery.SqlQuerySingle<QuantityRecord>("SELECT qr.id, qr.noSeri, qr.qtyAwalSablon, qr.qtySablonBS, qr.qtySablonHilang, qr.qtyAwalBordir, qr.qtyBordirBS, qr.qtyBordirHilang, qr.qtyAwalCMT, qr.qtyCMTBS, qr.qtyCMTHilang FROM QuantityRecord qr WHERE qr.noSeri = '" + noSeri + "'");
                    double? x = dba.qtyAwalCMT;
                    double? y = dba.qtyCMTHilang;
                    double? z = dba.qtyCMTBS;
                    var qtyAwal = x ?? x;
                    var qtyHilang = y ?? y;
                    var qtyBS = z ?? z;
                    var qtyAkhir = qtyAwal - (qtyHilang + qtyBS);

                    if (sablon == "True")
                    {
                        dataGridView1.Columns[10].ValueType = typeof(String);
                        dataGridView1.Rows[i].Cells[10].Value = "Sudah di sablon";
                        dataGridView1.UpdateCellValue(10, i);
                    }
                    else
                    {

                        dataGridView1.Columns[10].ValueType = typeof(String);
                        dataGridView1.Rows[i].Cells[10].Value = "-";
                        dataGridView1.UpdateCellValue(10, i);
                    }

                    if (bordir == "True")
                    {
                        dataGridView1.Columns[11].ValueType = typeof(String);
                        dataGridView1.Rows[i].Cells[11].Value = "Sudah di bordir";
                        dataGridView1.UpdateCellValue(11, i);
                    }
                    else
                    {

                        dataGridView1.Columns[11].ValueType = typeof(String);
                        dataGridView1.Rows[i].Cells[11].Value = "-";
                        dataGridView1.UpdateCellValue(11, i);
                    }

                    if (cmt == "True")
                    {
                        dataGridView1.Columns[12].ValueType = typeof(String);
                        dataGridView1.Rows[i].Cells[12].Value = "Sudah di CMT";
                        dataGridView1.UpdateCellValue(12, i);
                    }
                    else
                    {

                        dataGridView1.Columns[12].ValueType = typeof(String);
                        dataGridView1.Rows[i].Cells[12].Value = "-";
                        dataGridView1.UpdateCellValue(12, i);
                    }

                    if (!String.IsNullOrEmpty(qtyAwal.ToString()))
                    {
                        dataGridView1.Columns[6].ValueType = typeof(double);
                        dataGridView1.Rows[i].Cells[6].Value = qtyAwal;
                        dataGridView1.UpdateCellValue(6, i);
                    }

                    dataGridView1.Columns[0].ValueType = typeof(int);
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.UpdateCellValue(0, i);

                    if (qtyHilang == null)
                    {
                        dataGridView1.Columns[7].ValueType = typeof(string);
                        dataGridView1.Rows[i].Cells[7].Value = "-";
                        dataGridView1.UpdateCellValue(7, i);
                    }
                    else
                    {
                        dataGridView1.Columns[7].ValueType = typeof(double);
                        dataGridView1.Rows[i].Cells[7].Value = qtyHilang;
                        dataGridView1.UpdateCellValue(7, i);
                    }

                    if (qtyBS == null)
                    {
                        dataGridView1.Columns[8].ValueType = typeof(string);
                        dataGridView1.Rows[i].Cells[8].Value = "-";
                        dataGridView1.UpdateCellValue(8, i);
                    }
                    else
                    {
                        dataGridView1.Columns[8].ValueType = typeof(double);
                        dataGridView1.Rows[i].Cells[8].Value = qtyBS;
                        dataGridView1.UpdateCellValue(8, i);
                    }

                    if (qtyAkhir == null)
                    {
                        dataGridView1.Columns[9].ValueType = typeof(string);
                        dataGridView1.Rows[i].Cells[9].Value = "-";
                        dataGridView1.UpdateCellValue(9, i);
                    }
                    else
                    {
                        dataGridView1.Columns[9].ValueType = typeof(double);
                        dataGridView1.Rows[i].Cells[9].Value = qtyAkhir;
                        dataGridView1.UpdateCellValue(9, i);
                    }
                }
                dataGridView1.Refresh();
            }
        }

        private void cboPicPenerimaanCMT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPicPenerimaanCMT.Items.Count > 0 && cboPicPenerimaanCMT.Text != "")
            {
                int eID = Convert.ToInt32(cboPicPenerimaanCMT.SelectedValue.ToString());
                var dba = GenericQuery.SqlQuerySingle<Employee>("SELECT e.EmployeeID, e.EmployeeName, e.EmployeeCode, e.EmployeeEmail, e.EmployeePhone, e.EmployeePosition from Employees e WHERE e.EmployeeID = '" + eID + "'");
                txtPICCodePenerimaan.Text = dba.EmployeeCode.ToString();
            }
        }
    }
}
