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
using Excel = Microsoft.Office.Interop.Excel;

namespace Project
{
    public partial class SPKCmt : MetroFramework.Forms.MetroForm
    {
        private BindingSource _bs = null;
        private DataGridView _dv = null;
        private Form _form = null;
        public static int idSPK;
        private List<DetailSPKModel> _dpo = null;
        public List<DetailSPKModel> list = new List<DetailSPKModel>();

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

        public void setDPO(List<DetailSPKModel> dpo)
        {
            _dpo = dpo;
        }

        public SPKCmt()
        {
            InitializeComponent();
        }

        private void afterSave()
        {
            btnAddSPKCMT.Enabled = false;
            btnDeleteSPKCMT.Enabled = false;
            btnSaveSPKCMT.Dispose();
            btnExitSPKCMT.Location = new Point(495, 591);
        }

        private void btnSaveSPKCMT_Click(object sender, EventArgs e)
        {
            if (txtNoSpkCMT.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "No SPK CMT must be filled!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoSpkCMT.Focus();
            }
            else if (cboPICCMT.Items.Count > 0 && txtPicCodeCMT.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Select the PIC CMT first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPICCMT.Focus();
            }
            else if (dataGridView1.Rows.Count < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add list penerimaan tukang potong to the table first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (indomodaEntities db = new indomodaEntities())
                    {
                        int setIDSPK = Convert.ToInt32(txtIDSPK.Text.ToString());
                        int setEID = Convert.ToInt32(cboPICCMT.SelectedValue.ToString());
                        string setType = "cmt";
                        int setStatus = 0;
                        int a = GenericQuery.ExecSQLCommand("INSERT INTO DetailSPK (idSPK, noSPK, EmployeeID, Datetime, type, status) VALUES(@idSPK, @noSPK, @EmployeeID, @Datetime, @type, @status)", new[] {
                            new SqlParameter("@idSPK", setIDSPK),
                            new SqlParameter("@noSPK", txtNoSpkCMT.Text.ToString()),
                            new SqlParameter("@EmployeeID", setEID),
                            new SqlParameter("@Datetime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                            new SqlParameter("@type", setType),
                            new SqlParameter("@status", setStatus)
                        });

                        db.SaveChangesAsync().Wait();

                        MetroFramework.MetroMessageBox.Show(this, "Success! No SPK for this data has been added to the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        afterSave();
                        List<SPKEmployeeModel> LI = GenericQuery.SqlQuery<SPKEmployeeModel>("SELECT a.idSPK, a.noSPK, a.EmployeeID, a.Datetime, a.type, a.status, b.EmployeeName, b.EmployeeCode FROM DetailSPK a JOIN Employees b ON a.EmployeeID = b.EmployeeID WHERE a.idSPK = '" + txtIDSPK.Text + "'");
                        detailSPKBindingSource.DataSource = LI.ToList();
                        int rowCount = dataGridView2.Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            dataGridView2.Columns[0].ValueType = typeof(int);
                            dataGridView2.Rows[i].Cells[0].Value = i + 1;
                            dataGridView2.UpdateCellValue(0, i);
                        }
                        dataGridView2.Columns[5].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss tt";
                        dataGridView2.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExitSPKCMT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteSPKCMT_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add List penerimaan tukang potong first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to delete this List penerimaan tukang potong from table?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    using (indomodaEntities db = new indomodaEntities())
                    {
                        try
                        {
                            int currentRow = dataGridView1.CurrentRow.Index;
                            int currentIDPTP = Convert.ToInt32(dataGridView1[17, dataGridView1.CurrentRow.Index].Value.ToString());
                            int setIDSPK = 0;
                            bool setStatusCMT = false;
                            int a = GenericQuery.ExecSQLCommand("UPDATE ListPenerimaanTukangPotong SET statusSPKCMT = @statusSPKCMT, idSPKCMT = @idSPKCMT WHERE idListPTP = '" + currentIDPTP + "'", new[] {
                                new SqlParameter("@statusSPKCMT", setStatusCMT),
                                new SqlParameter("@idSPKCMT", setIDSPK)
                            });
                            db.SaveChangesAsync().Wait();
                            dataGridView1.Rows.RemoveAt(currentRow);

                            int rowCount = dataGridView1.Rows.Count;
                            for (int i = 0; i < rowCount; i++)
                            {
                                dataGridView1.Columns[0].ValueType = typeof(int);
                                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                                dataGridView1.UpdateCellValue(0, i);
                            }
                            dataGridView1.Refresh();
                            listPenerimaanTukangPotongBindingSource.EndEdit();

                            MetroFramework.MetroMessageBox.Show(this, "Success! This List penerimaan tukang potong has been deleted from the table", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnAddSPKCMT_Click(object sender, EventArgs e)
        {
            idSPK = Convert.ToInt32(txtIDSPK.Text.ToString());
            AddSpkCmt addspk = new AddSpkCmt();
            addspk.setDGV(ref dataGridView1);
            addspk.setBS(ref listPenerimaanTukangPotongBindingSource);
            addspk.Show();
        }

        private void cboPICCMT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPICCMT.Items.Count > 0 && cboPICCMT.Text != "")
            {
                int eID = Convert.ToInt32(cboPICCMT.SelectedValue.ToString());
                var dba = GenericQuery.SqlQuerySingle<Employee>("SELECT e.EmployeeID, e.EmployeeName, e.EmployeeCode, e.EmployeeEmail, e.EmployeePhone, e.EmployeePosition from Employees e WHERE e.EmployeeID = '" + eID + "'");
                txtPicCodeCMT.Text = dba.EmployeeCode.ToString();
            }
        }

        private void SPKCmt_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                int setID = db.DetailSPKs.AsEnumerable().LastOrDefault() == null ? 1 : db.DetailSPKs.AsEnumerable().LastOrDefault().idSPK + 1;
                txtIDSPK.Text = setID.ToString();
                employeeBindingSource.DataSource = db.Employees.ToList();
                colorBindingSource.DataSource = db.Colors.ToList();
                //List<ListPenerimaanTukangPotong> listPTP = GenericQuery.SqlQuery<ListPenerimaanTukangPotong>("SELECT lp.idListPTP, lp.idPenerimaanTukangPotong, lp.noSeri, lp.model, lp.ColorID, lp.merk, lp.ukuran, lp.quantity, lp.statusSPKSablon, lp.statusSPKBordir, lp.statusSPKCMT, lp.statusNoSeri, lp.idSPKSablon, lp.idSPKBordir, lp.idSPKCMT  FROM ListPenerimaanTukangPotong lp");
                //listPenerimaanTukangPotongBindingSource.DataSource = listPTP.ToList();

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

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
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

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
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
            dataGridView2.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView2.MultiSelect = true;
            dataGridView2.SelectAll();
            DataObject dataObj = dataGridView2.GetClipboardContent();
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
                MetroFramework.MetroMessageBox.Show(this, "You must save this No. SPK CMT to database first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    xlWorkSheet.Cells[4, 10]];
                    var table1 = xlWorkSheet.Range[
                    xlWorkSheet.Cells[1, 1],
                    xlWorkSheet.Cells[2, 6]];
                    var table2 = xlWorkSheet.Range[
                    xlWorkSheet.Cells[4, 1],
                    xlWorkSheet.Cells[4 + currentRow, 10]];
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
