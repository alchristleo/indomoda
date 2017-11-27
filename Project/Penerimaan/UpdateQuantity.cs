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
    public partial class UpdateQuantity : MetroFramework.Forms.MetroForm
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

        public UpdateQuantity()
        {
            InitializeComponent();
        }

        private void UpdateQuantity_Load(object sender, EventArgs e)
        {

            list = _dpo;

            if (list != null && list.Count > 0)
            {
                txtNoSeri.Text = list[0].noSeri;
                var dba = GenericQuery.SqlQuerySingle<QuantityRecord>("SELECT qr.id, qr.noSeri, qr.qtyAwalSablon, qr.qtySablonBS, qr.qtySablonHilang, qr.qtyAwalBordir, qr.qtyBordirBS, qr.qtyBordirHilang, qr.qtyAwalCMT, qr.qtyCMTBS, qr.qtyCMTHilang FROM QuantityRecord qr WHERE qr.noSeri = '" + txtNoSeri.Text + "'");
                if (dba.qtySablonHilang != 0 && dba.qtySablonBS != 0)
                {
                    txtQuantityAwal.Text = dba.qtyAwalSablon.ToString();
                }
                else
                {
                    txtQuantityAwal.Text = list[0].quantity.ToString();
                }
                if (list[0].qtySablonHilang != 0) { txtBarangHilang.Text = list[0].qtySablonHilang.ToString(); }
                if (list[0].qtySablonBS != 0) { txtBarangBS.Text = list[0].qtySablonBS.ToString(); }
            }
            txtBarangHilang.Focus();
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
                            int a = GenericQuery.ExecSQLCommand("UPDATE QuantityRecord SET qtyAwalSablon = @qtyAwalSablon, qtySablonBS = @qtySablonBS, qtySablonHilang = @qtySablonHilang WHERE noSeri = '" + noSeri + "'", new[] {
                                new SqlParameter("@qtyAwalSablon", qtyAwal),
                                new SqlParameter("@qtySablonBS", barangBS),
                                new SqlParameter("@qtySablonHilang", barangHilang)
                            });
                            db.SaveChangesAsync().Wait();

                            int crIdx = PenerimaanSablon.CR;
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
    }
}
