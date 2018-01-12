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
using Excel = Microsoft.Office.Interop.Excel;

namespace Project
{
    public partial class PenerimaanTukangPotong : MetroFramework.Forms.MetroForm
    {
        private BindingSource _bs = null;
        private DataGridView _dv = null;
        private Form _form = null;
        public static int idPenerimaanTukangPotong;
        private List<ListPTPModel> _dpo = null;
        public List<ListPTPModel> listPO = new List<ListPTPModel>();

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

        public void setDPO(List<ListPTPModel> dpo)
        {
            _dpo = dpo;
        }

        public PenerimaanTukangPotong()
        {
            InitializeComponent();
        }

        private void btnExitPenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboNoPemotonganKain_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNoPemotonganKain.Items.Count > 0 && cboNoPemotonganKain.Text != "")
                {
                    cboNoPemotonganKain.Refresh();
                    string noPemotonganKain = cboNoPemotonganKain.SelectedValue.ToString();
                    var db = GenericQuery.SqlQuerySingle<PemotonganKainModel>("select pk.idPemotonganKain, pk.noPemotonganKain, pk.NoFaktur, pk.PONumber, pk.EmployeeID, pk.status, e.EmployeeCode, e.EmployeeName from DetailPemotonganKain pk JOIN Employees e on pk.EmployeeID = e.EmployeeID WHERE pk.status = '" + 0 + "' AND pk.noPemotonganKain = '" + noPemotonganKain + "'");
                    txtPICCode.Text = db.EmployeeCode.ToString();
                    txtPICName.Text = db.EmployeeName.ToString();

                    List<DetailPO> detailPO = GenericQuery.SqlQuery<DetailPO>("SELECT df.DetailPOID, df.PONumber, df.MaterialID, df.ColorID, df.DetailQty, df.DetailPrice, df.DetailTotal, df.DetailStatus, df.statusFaktur, df.noPemotonganKain, df.tempPemotongan FROM DetailPO df WHERE df.noPemotonganKain = '"+noPemotonganKain+"' AND df.tempPemotongan = '"+2+"'");
                    detailPOBindingSource.DataSource = detailPO.ToList();
                    dataGridView2.Visible = true;

                    int rowCount = dataGridView2.Rows.Count;
                    for (int i = 0; i < rowCount; i++)
                    {
                        dataGridView2.Columns[0].ValueType = typeof(int);
                        dataGridView2.Rows[i].Cells[0].Value = i + 1;
                        dataGridView2.UpdateCellValue(0, i);
                    }
                    dataGridView2.Refresh();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            if (cboNoPemotonganKain.Items.Count < 1 && txtPICCode.Text == "" && txtPICName.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select No pemotongan kain first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNoPemotonganKain.Focus();
            }
            else
            {
                idPenerimaanTukangPotong = Convert.ToInt32(txtIDPenerimaanTukangPotong.Text);
                AddPenerimaanTukangPotong addPenerimaanTukangPotong = new AddPenerimaanTukangPotong();
                addPenerimaanTukangPotong.setDGV(ref dataGridView1);
                addPenerimaanTukangPotong.setBS(ref listPenerimaanTukangPotongBindingSource);
                addPenerimaanTukangPotong.Show();
            }
        }

        private void btnEditPenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add list penerimaan tukang potong first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EditPenerimaanTukangPotong editPTP = new EditPenerimaanTukangPotong();
                int currentIDPTP = Convert.ToInt32(dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString());

                listPO = GenericQuery.SqlQuery<ListPTPModel>("SELECT lp.idListPTP, lp.idPenerimaanTukangPotong, lp.noSeri, lp.model, lp.ColorID, lp.merk, lp.ukuran, lp.quantity, c.ColorName FROM ListPenerimaanTukangPotong lp JOIN Colors c ON lp.ColorID = c.ColorID  WHERE idListPTP = '" + currentIDPTP + "'");
                editPTP.setDPO(ref listPO);
                editPTP.setDGV(ref dataGridView1);
                editPTP.setBS(ref listPenerimaanTukangPotongBindingSource);
                editPTP.Show();
            }
        }

        private void btnDeletePenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add List penerimaan tukang potong first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            int currentIDPTP = Convert.ToInt32(dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString());
                            string noSeri = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                            int b = GenericQuery.ExecSQLCommand("DELETE FROM ListPenerimaanTukangPotong WHERE idListPTP = '" + currentIDPTP + "'");
                            db.SaveChangesAsync().Wait();
                            dataGridView1.Rows.RemoveAt(currentRow);

                            int c = GenericQuery.ExecSQLCommand("DELETE FROM QuantityRecord WHERE noSeri = '" + noSeri + "'");
                            db.SaveChangesAsync().Wait();

                            //int d = GenericQuery.ExecSQLCommand("DELETE FROM DatetimeNotification WHERE noSeri = '"+noSeri+"'");
                            //db.SaveChangesAsync().Wait();

                            int rowCount = dataGridView1.Rows.Count;
                            for (int i = 0; i < rowCount; i++)
                            {
                                dataGridView1.Columns[0].ValueType = typeof(int);
                                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                                dataGridView1.UpdateCellValue(0, i);
                            }
                            dataGridView1.Refresh();
                            listPenerimaanTukangPotongBindingSource.EndEdit();

                            MetroFramework.MetroMessageBox.Show(this, "Success! This List penerimaan tukang potong has been deleted from database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void PenerimaanTukangPotong_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                int setID = db.DetailPenerimaanTukangPotongs.AsEnumerable().LastOrDefault() == null ? 1 : db.DetailPenerimaanTukangPotongs.AsEnumerable().LastOrDefault().idPenerimaanTukangPotong + 1;
                txtIDPenerimaanTukangPotong.Text = setID.ToString();
                List<PemotonganKainModel> cboPK = GenericQuery.SqlQuery<PemotonganKainModel>("select pk.idPemotonganKain, pk.noPemotonganKain, pk.NoFaktur, pk.PONumber, pk.EmployeeID, pk.status, e.EmployeeCode, e.EmployeeName from DetailPemotonganKain pk JOIN Employees e on pk.EmployeeID = e.EmployeeID WHERE pk.status = '" + 0 + "'");
                detailPemotonganKainBindingSourceCbo.DataSource = cboPK.ToList();
                colorBindingSource.DataSource = db.Colors.ToList();
                materialBindingSource.DataSource = db.Materials.ToList();
            }
        }

        private void afterSave()
        {
            txtNoPenerimaanTukangPotong.Enabled = false;
            cboNoPemotonganKain.Enabled = false;
            txtPICCode.Enabled = false;
            txtPICName.Enabled = false;
            btnAddPenerimaanTukangPotong.Enabled = false;
            btnEditPenerimaanTukangPotong.Enabled = false;
            btnDeletePenerimaanTukangPotong.Enabled = false;
            btnSavePenerimaanTukangPotong.Dispose();
            btnExitPenerimaanTukangPotong.Location = new Point(370, 622);
        }

        private void btnSavePenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            if (txtNoPenerimaanTukangPotong.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "No penerimaan tukang potong must be filled!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoPenerimaanTukangPotong.Focus();
            }
            else if (cboNoPemotonganKain.Items.Count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Pemotongan kain List is empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboNoPemotonganKain.Items.Count > 0 && txtPICCode.Text == "" && txtPICName.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select No pemotongan kain first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNoPemotonganKain.Focus();
            }
            else if (dataGridView1.Rows.Count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must add List penerimaan tukang potong first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (indomodaEntities db = new indomodaEntities())
                    {
                        int setIDPTK = Convert.ToInt32(txtIDPenerimaanTukangPotong.Text.ToString());
                        string noPTK = txtNoPenerimaanTukangPotong.Text;
                        string setNoPK = cboNoPemotonganKain.SelectedValue.ToString();
                        bool setStatusPTK = false;
                        int a = GenericQuery.ExecSQLCommand("INSERT INTO DetailPenerimaanTukangPotong (idPenerimaanTukangPotong, noPenerimaanTukangPotong, noPemotonganKain, Date_time, status) VALUES(@idPenerimaanTukangPotong, @noPenerimaanTukangPotong, @noPemotonganKain, @Date_time, @status)", new[] {
                            new SqlParameter("@idPenerimaanTukangPotong", setIDPTK),
                            new SqlParameter("@noPenerimaanTukangPotong", noPTK),
                            new SqlParameter("@noPemotonganKain", setNoPK),
                            new SqlParameter("@Date_time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                            new SqlParameter("@status", setStatusPTK)
                        });

                        db.SaveChangesAsync().Wait();

                        try
                        {
                            int setStatusDetailPK = 1;
                            int b = GenericQuery.ExecSQLCommand("UPDATE DetailPemotonganKain SET status = @status WHERE noPemotonganKain = '" + setNoPK + "'", new[] {
                                    new SqlParameter("@status", setStatusDetailPK)
                                });
                            db.SaveChangesAsync().Wait();
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        MetroFramework.MetroMessageBox.Show(this, "Success! Penerimaan tukang potong for this data has been added to the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        afterSave();
                        List<DetailPTPModel> LI = GenericQuery.SqlQuery<DetailPTPModel>("SELECT a.idPenerimaanTukangPotong, a.noPenerimaanTukangPotong, a.noPemotonganKain, a.Date_time, a.status, b.EmployeeID, c.EmployeeName, c.EmployeeCode FROM DetailPenerimaanTukangPotong a JOIN DetailPemotonganKain b ON a.noPemotonganKain = b.noPemotonganKain JOIN Employees c ON b.EmployeeID = c.EmployeeID WHERE a.idPenerimaanTukangPotong = '" + txtIDPenerimaanTukangPotong.Text + "'");
                        detailPenerimaanTukangPotongBindingSource.DataSource = LI.ToList();
                        int rowCount = dataGridView3.Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            dataGridView3.Columns[0].ValueType = typeof(int);
                            dataGridView3.Rows[i].Cells[0].Value = i + 1;
                            dataGridView3.UpdateCellValue(0, i);
                        }
                        dataGridView3.Columns[5].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss tt";
                        dataGridView3.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void copyAlltoClipboard2()
        {
            dataGridView3.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView3.MultiSelect = true;
            dataGridView3.SelectAll();
            DataObject dataObj = dataGridView3.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "List data is empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridView2.Rows.Count < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must save this No. Penerimaan Tukang Potong to database first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int currentRow = dataGridView1.Rows.Count;

                    copyAlltoClipboard2();
                    Microsoft.Office.Interop.Excel.Application xlexcel;
                    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;
                    xlexcel = new Excel.Application();
                    xlexcel.Visible = true;
                    xlWorkBook = xlexcel.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                    CR.EntireColumn.AutoFit();
                    CR.Select();
                    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                    copyAlltoClipboard();
                    object misValue2 = System.Reflection.Missing.Value;
                    Excel.Range CR2 = (Excel.Range)xlWorkSheet.Cells[4, 1];
                    CR2.EntireColumn.AutoFit();
                    CR2.Select();
                    xlWorkSheet.PasteSpecial(CR2, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                    Excel.Range aRange = xlWorkSheet.get_Range("A1", "M100");
                    aRange.EntireColumn.AutoFit();

                    var columnHeadingsRange = xlWorkSheet.Range[
                    xlWorkSheet.Cells[1, 1],
                    xlWorkSheet.Cells[1, 6]];
                    var columnHeadingsRange2 = xlWorkSheet.Range[
                    xlWorkSheet.Cells[4, 1],
                    xlWorkSheet.Cells[4, 7]];
                    var table1 = xlWorkSheet.Range[
                    xlWorkSheet.Cells[1, 1],
                    xlWorkSheet.Cells[2, 6]];
                    var table2 = xlWorkSheet.Range[
                    xlWorkSheet.Cells[4, 1],
                    xlWorkSheet.Cells[4 + currentRow, 7]];
                    columnHeadingsRange.Interior.Color = System.Drawing.Color.Yellow;
                    columnHeadingsRange2.Interior.Color = System.Drawing.Color.Yellow;
                    table1.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    table1.Borders.Weight = Excel.XlBorderWeight.xlThin;
                    table2.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    table2.Borders.Weight = Excel.XlBorderWeight.xlThin;
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPrint_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.AutoPopDelay = 3000;
            ToolTip1.InitialDelay = 1000;
            ToolTip1.ReshowDelay = 500;
            ToolTip1.SetToolTip(this.btnPrint, "Print current data in table");
        }
    }
}
