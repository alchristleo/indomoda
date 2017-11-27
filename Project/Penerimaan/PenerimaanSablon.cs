using Project.Helpers;
using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class PenerimaanSablon : MetroFramework.Forms.MetroForm
    {
        public static int CR;
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

        public PenerimaanSablon()
        {
            InitializeComponent();
        }

        private void cboPicPenerimaanSablon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPicPenerimaanSablon.Items.Count > 0 && cboPicPenerimaanSablon.Text != "")
            {
                int eID = Convert.ToInt32(cboPicPenerimaanSablon.SelectedValue.ToString());
                var dba = GenericQuery.SqlQuerySingle<Employee>("SELECT e.EmployeeID, e.EmployeeName, e.EmployeeCode, e.EmployeeEmail, e.EmployeePhone, e.EmployeePosition from Employees e WHERE e.EmployeeID = '" + eID + "'");
                txtPICCodePenerimaan.Text = dba.EmployeeCode.ToString();
            }
        }

        private void cboNoSpkSablonPenerimaan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNoSpkSablonPenerimaan.Items.Count > 0 && cboNoSpkSablonPenerimaan.Text != "")
            {
                cboNoSpkSablonPenerimaan.Refresh();
                int idSPK = Convert.ToInt32(cboNoSpkSablonPenerimaan.SelectedValue.ToString());
                List<QuantityRecordPTPModel> listPTP = GenericQuery.SqlQuery<QuantityRecordPTPModel>("SELECT df.idListPTP, df.idPenerimaanTukangPotong, df.noSeri, df.model, df.ColorID, df.merk, df.ukuran, df.quantity, df.statusSPKSablon, df.statusSPKBordir, df.statusSPKCMT, df.statusNoSeri, df.idSPKSablon, df.idSPKBordir, df.idSPKCMT, qr.id, qr.qtyAwalSablon, qr.qtySablonBS, qr.qtySablonHilang, qr.qtyAwalBordir, qr.qtyBordirBS, qr.qtyBordirHilang, qr.qtyAwalCMT, qr.qtyCMTBS, qr.qtyCMTHilang FROM ListPenerimaanTukangPotong df JOIN QuantityRecord qr on df.noSeri = qr.noSeri WHERE df.idSPKSablon = '" + idSPK + "' AND df.statusNoSeri = '" + 0 + "'");
                listPenerimaanTukangPotongBindingSource.DataSource = listPTP.ToList();

                int rowCount = dataGridView1.Rows.Count;
                for (int i = 0; i < rowCount; i++)
                {
                    string sablon = dataGridView1.Rows[i].Cells[13].Value.ToString();
                    string bordir = dataGridView1.Rows[i].Cells[14].Value.ToString();
                    string cmt = dataGridView1.Rows[i].Cells[15].Value.ToString();
                    string noSeri = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    var dba = GenericQuery.SqlQuerySingle<QuantityRecord>("SELECT qr.id, qr.noSeri, qr.qtyAwalSablon, qr.qtySablonBS, qr.qtySablonHilang, qr.qtyAwalBordir, qr.qtyBordirBS, qr.qtyBordirHilang, qr.qtyAwalCMT, qr.qtyCMTBS, qr.qtyCMTHilang FROM QuantityRecord qr WHERE qr.noSeri = '" + noSeri + "'");
                    double qtyAwal = Convert.ToDouble(dba.qtyAwalSablon.ToString());
                    double qtyHilang = Convert.ToDouble(dba.qtySablonHilang.ToString());
                    double qtyBS = Convert.ToDouble(dba.qtySablonBS.ToString());
                    double qtyAkhir = qtyAwal - (qtyHilang + qtyBS);

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

                    if (qtyHilang != 0 && qtyBS != 0)
                    {
                        dataGridView1.Columns[6].ValueType = typeof(double);
                        dataGridView1.Rows[i].Cells[6].Value = qtyAwal;
                        dataGridView1.UpdateCellValue(6, i);
                    }

                    dataGridView1.Columns[0].ValueType = typeof(int);
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.UpdateCellValue(0, i);

                    dataGridView1.Columns[7].ValueType = typeof(double);
                    dataGridView1.Rows[i].Cells[7].Value = qtyHilang;
                    dataGridView1.UpdateCellValue(7, i);

                    dataGridView1.Columns[8].ValueType = typeof(double);
                    dataGridView1.Rows[i].Cells[8].Value = qtyBS;
                    dataGridView1.UpdateCellValue(8, i);

                    if (qtyAkhir < 1)
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

        private void PenerimaanSablon_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                string type = "sablon";
                employeeBindingSource.DataSource = db.Employees.ToList();
                colorBindingSource.DataSource = db.Colors.ToList();
                List<DetailSPK> cboPK = GenericQuery.SqlQuery<DetailSPK>("select sp.idSPK, sp.noSPK, sp.EmployeeID, sp.Datetime, sp.type, sp.status FROM DetailSPK sp WHERE sp.type = '" + type +"'");
                detailSPKBindingSource.DataSource = cboPK.ToList();
            }
        }

        private void btnUpdateStatusPemotongan_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "List penerimaan tukang potong is empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CR = dataGridView1.CurrentRow.Index;
                UpdateQuantity uq = new UpdateQuantity();
                int currentIDPTP = Convert.ToInt32(dataGridView1[17, dataGridView1.CurrentRow.Index].Value.ToString());
                listPTPQR = GenericQuery.SqlQuery<QuantityRecordPTPModel>("SELECT df.idListPTP, df.idPenerimaanTukangPotong, df.noSeri, df.model, df.ColorID, df.merk, df.ukuran, df.quantity, df.statusSPKSablon, df.statusSPKBordir, df.statusSPKCMT, df.statusNoSeri, df.idSPKSablon, df.idSPKBordir, df.idSPKCMT, qr.id, qr.qtyAwalSablon, qr.qtySablonBS, qr.qtySablonHilang, qr.qtyAwalBordir, qr.qtyBordirBS, qr.qtyBordirHilang, qr.qtyAwalCMT, qr.qtyCMTBS, qr.qtyCMTHilang FROM ListPenerimaanTukangPotong df JOIN QuantityRecord qr on df.noSeri = qr.noSeri WHERE df.idListPTP = '" + currentIDPTP + "'");
                uq.setDPO(ref listPTPQR);
                uq.setDGV(ref dataGridView1);
                uq.setBS(ref listPenerimaanTukangPotongBindingSource);
                uq.Show();
            }
        }

        private void btnSavePenerimaanSablon_Click(object sender, EventArgs e)
        {

        }

        private void btnExitPenerimaanSablon_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
