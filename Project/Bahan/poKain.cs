using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using Project.Helpers;
using System.Data.SqlClient;
using Project.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace Project
{
    public partial class poKain : MetroFramework.Forms.MetroForm
    {
        indomodaEntities db;

        private BindingSource _bs = null;
        private DataGridView _dv = null;
        private Form _form = null;
        public static string poNumber;
        private List<DetailPOModel> _dpo = null;
        public List<DetailPOModel> listPO = new List<DetailPOModel>();

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

        public void setDPO(List<DetailPOModel> dpo)
        {
            _dpo = dpo;
        }

        public poKain()
        {
            InitializeComponent();
        }

        private void btnAddPoKain_Click(object sender, EventArgs e)
        {
            poNumber = lblPONumber.Text;
            AddPOKain addpokain = new AddPOKain();
            addpokain.setDGV(ref dataGridView1);
            addpokain.setBS(ref detailPOBindingSource);
            addpokain.Show();
        }

        private void btnEditPoKain_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add detail PO first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EditPOKain editpokain = new EditPOKain();
                int currentPOID = Convert.ToInt32(dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString());

                listPO = GenericQuery.SqlQuery<DetailPOModel>("SELECT d.DetailPOID, d.PONumber, d.MaterialID, d.ColorID, d.DetailQty, d.DetailPrice, d.DetailTotal, d.DetailStatus, m.MaterialCode, m.MaterialName, c.ColorCode, c.ColorName FROM DetailPO d JOIN Materials m ON d.MaterialID = m.MaterialID JOIN Colors c ON d.ColorID = c.ColorID  WHERE DetailPOID = '" + currentPOID + "'");
                editpokain.setDPO(ref listPO);
                editpokain.setDGV(ref dataGridView1);
                editpokain.setBS(ref detailPOBindingSource);
                editpokain.Show();
            }
        }

        private void btnDeletePoKain_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add detail PO first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            int currentPOID = Convert.ToInt32(dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString());
                            int b = GenericQuery.ExecSQLCommand("DELETE FROM DetailPO WHERE DetailPOID = '"+currentPOID+"'");
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
                            bindingSourcePreOrderKain.EndEdit();

                            btnCountGrandTotal.PerformClick();

                            MetroFramework.MetroMessageBox.Show(this, "Success! This Detail PO has been deleted from database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        
        private void poKain_Load(object sender, EventArgs e)
        {
            long randomNumber = Convert.ToInt64(DateTime.Now.ToString("ddMMyyHHmm"));
            lblPONumber.Text = randomNumber.ToString();
            using (indomodaEntities db = new indomodaEntities())
            {
                indomodaSupplierBindingSource.DataSource = db.IndomodaSuppliers.ToList();
                materialBindingSource.DataSource = db.Materials.ToList();
                colorBindingSource.DataSource = db.Colors.ToList();
            }
            dataGridView1.Columns[5].DefaultCellStyle.Format = "C";
            dataGridView1.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            dataGridView1.Columns[6].DefaultCellStyle.Format = "C";
            dataGridView1.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
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

        private void afterSave()
        {
            btnAddPoKain.Enabled = false;
            btnEditPoKain.Enabled = false;
            btnDeletePoKain.Enabled = false;
            btnCountGrandTotal.Enabled = false;
            btnSavePoKain.Dispose();
            btnExitPoKain.Location = new Point(355, 617);
        }

        private void btnSavePoKain_Click(object sender, EventArgs e)
        {
            btnCountGrandTotal.PerformClick();

            using (indomodaEntities db = new indomodaEntities())
            {
                if (dataGridView1.RowCount == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "You need to add detail PO first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (lblSupplierCode.Text == "" && lblSupplierAddress.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "You must select supplier first !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Do you want to save this transaction to database?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            int setPOID = db.PreOrderKains.AsEnumerable().LastOrDefault() == null ? 1 : db.PreOrderKains.AsEnumerable().LastOrDefault().idPOKain + 1;
                            int SupplierID = Convert.ToInt32(cboSupplierName.SelectedValue.ToString());
                            decimal setGTotal = Convert.ToDecimal(lblGrandTotalDB.Text.ToString());
                            bool setStatus = false;
                            int a = GenericQuery.ExecSQLCommand("INSERT INTO PreOrderKains (idPOKain, PONumber, SupplierID, GrandTotal, Date_time, status) VALUES(@idPOKain, @PONumber, @SupplierID, @GrandTotal, @Date_time, @status)", new[] {
                                new SqlParameter("@idPOKain", setPOID),
                                new SqlParameter("@PONumber", lblPONumber.Text),
                                new SqlParameter("@SupplierID", SupplierID),
                                new SqlParameter("@GrandTotal", setGTotal),
                                new SqlParameter("@Date_time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                                new SqlParameter("@status", setStatus)
                            });

                            db.SaveChangesAsync().Wait();
                            bindingSourcePreOrderKain.EndEdit();

                            MetroFramework.MetroMessageBox.Show(this, "Success! Transaction has been added to the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);

                            afterSave();
                            List<POKainSupplierModel> LI = GenericQuery.SqlQuery<POKainSupplierModel>("SELECT a.idPOKain, a.PONumber, a.SupplierID, a.GrandTotal, a.Date_time, a.status, b.SupplierName, b.SupplierCode, b.SupplierAddress FROM PreOrderKains a JOIN IndomodaSuppliers b ON a.SupplierID = b.SupplierID WHERE a.PONumber = '"+lblPONumber.Text+"'");
                            preOrderKainBindingSource.DataSource = LI.ToList();
                            int rowCount = dataGridView2.Rows.Count;
                            for (int i = 0; i < rowCount; i++)
                            {
                                dataGridView2.Columns[0].ValueType = typeof(int);
                                dataGridView2.Rows[i].Cells[0].Value = i + 1;
                                dataGridView2.UpdateCellValue(0, i);
                            }
                            dataGridView2.Columns[5].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss tt";
                            dataGridView2.Columns[6].DefaultCellStyle.Format = "C";
                            dataGridView2.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
                            dataGridView2.Refresh();
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnExitPoKain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCountGrandTotal_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            decimal gt = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                gt = gt + decimal.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
            }
            lblGrandTotal.Text = String.Format(gt.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("id-ID")));
            lblGrandTotalDB.Text = gt.ToString();
        }

        private void cboSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSupplierName.Items.Count > 0 && cboSupplierName.Text != "")
            {
                int sID = Convert.ToInt32(cboSupplierName.SelectedValue.ToString());
                var dba = GenericQuery.SqlQuerySingle<IndomodaSupplier>("SELECT i.SupplierID, i.SupplierCode, i.SupplierName, i.SupplierAddress, i.SupplierPhone from IndomodaSuppliers i WHERE i.SupplierID = '" + sID + "'");
                lblSupplierCode.Text = dba.SupplierCode.ToString();
                lblSupplierAddress.Text = dba.SupplierAddress.ToString();
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
                MetroFramework.MetroMessageBox.Show(this, "You must save this PO to database first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    Clipboard.SetDataObject("Grand Total");
                    object misValue3 = System.Reflection.Missing.Value;
                    Excel.Range CR3 = (Excel.Range)xlWorkSheet.Cells[5 + currentRow, 6];
                    CR3.Select();
                    xlWorkSheet.Paste(CR3, Type.Missing);

                    Clipboard.SetDataObject(lblGrandTotal.Text);
                    object misValue4 = System.Reflection.Missing.Value;
                    Excel.Range CR4 = (Excel.Range)xlWorkSheet.Cells[5 + currentRow, 7];
                    CR4.Select();
                    xlWorkSheet.Paste(CR4, Type.Missing);
                    Excel.Range aRange = xlWorkSheet.get_Range("A1", "G100");
                    aRange.EntireColumn.AutoFit();

                    var columnHeadingsRange = xlWorkSheet.Range[
                    xlWorkSheet.Cells[1, 1],
                    xlWorkSheet.Cells[1, 7]];
                    var columnHeadingsRange2 = xlWorkSheet.Range[
                    xlWorkSheet.Cells[4, 1],
                    xlWorkSheet.Cells[4, 7]];
                    var table1 = xlWorkSheet.Range[
                    xlWorkSheet.Cells[1, 1],
                    xlWorkSheet.Cells[2, 7]];
                    var table2 = xlWorkSheet.Range[
                    xlWorkSheet.Cells[4, 1],
                    xlWorkSheet.Cells[5 + currentRow, 7]];
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
