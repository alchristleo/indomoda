﻿using Project.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Project
{
    public partial class LaporanPenerimaanCMT : MetroFramework.Forms.MetroForm
    {
        public static string npc;

        public LaporanPenerimaanCMT()
        {
            InitializeComponent();
        }

        private void dataGridSetup()
        {
            int rowCount = dataGridView1.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                dataGridView1.Columns[0].ValueType = typeof(int);
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.UpdateCellValue(0, i);
            }
            dataGridView1.Columns[4].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss tt";
        }

        private void LaporanPenerimaanCMT_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                employeeBindingSource.DataSource = db.Employees.ToList();
                List<PenerimaanSBC> pb = GenericQuery.SqlQuery<PenerimaanSBC>("SELECT a.id, a.noPenerimaan, a.noSPK, a.EmployeeID, a.Datetime, a.type, a.status FROM PenerimaanSBC a WHERE a.type = 'cmt'");
                penerimaanSBCBindingSource.DataSource = pb.ToList();

                dataGridSetup();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text;

            if (query == "")
            {
                dataGridView1.Rows.Clear();
                List<PenerimaanSBC> pc = GenericQuery.SqlQuery<PenerimaanSBC>("SELECT a.id, a.noPenerimaan, a.noSPK, a.EmployeeID, a.Datetime, a.type, a.status FROM PenerimaanSBC a WHERE a.type = 'cmt'");
                penerimaanSBCBindingSource.DataSource = pc.ToList();

                dataGridSetup();
            }
            else
            {
                dataGridView1.Rows.Clear();
                List<PenerimaanSBC> pc = GenericQuery.SqlQuery<PenerimaanSBC>("SELECT a.id, a.noPenerimaan, a.noSPK, a.EmployeeID, a.Datetime, a.type, a.status FROM PenerimaanSBC a WHERE a.type = 'cmt' AND a.noPenerimaan LIKE '%"+query+"%'");
                penerimaanSBCBindingSource.DataSource = pc.ToList();

                dataGridSetup();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            List<PenerimaanSBC> pc = GenericQuery.SqlQuery<PenerimaanSBC>("SELECT a.id, a.noPenerimaan, a.noSPK, a.EmployeeID, a.Datetime, a.type, a.status FROM PenerimaanSBC a WHERE a.type = 'cmt'");
            penerimaanSBCBindingSource.DataSource = pc.ToList();

            dataGridSetup();
        }

        private void btnReset_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.AutoPopDelay = 3000;
            ToolTip1.InitialDelay = 1000;
            ToolTip1.ReshowDelay = 500;
            ToolTip1.SetToolTip(this.btnReset, "Reset search");
        }

        private void fetchButton_Click(object sender, EventArgs e)
        {
            string date1 = startDate.Value.ToString("yyyy-MM-dd 00:00:00");
            string date2 = endDate.Value.ToString("yyyy-MM-dd 00:00:00");
            DateTime StartDate = startDate.Value;
            DateTime EndDate = endDate.Value;
            int diff = EndDate.Date.Subtract(StartDate.Date).Days;
            txtSearch.Clear();

            if (StartDate.ToShortDateString() == EndDate.ToShortDateString())
            {
                dataGridView1.Rows.Clear();
                MetroFramework.MetroMessageBox.Show(this, "Start Date and End Date can not be same", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (diff < 1)
            {
                dataGridView1.Rows.Clear();
                MetroFramework.MetroMessageBox.Show(this, "Start Date can not be greated than End Date", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.Rows.Clear();
                List<PenerimaanSBC> withRange = GenericQuery.SqlQuery<PenerimaanSBC>("SELECT a.id, a.noPenerimaan, a.noSPK, a.EmployeeID, a.Datetime, a.type, a.status FROM PenerimaanSBC a WHERE a.type = 'cmt' AND a.Datetime BETWEEN '" + date1 + "' AND '" + date2 + "'");
                penerimaanSBCBindingSource.DataSource = withRange.ToList();

                dataGridSetup();
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "List data is empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    copyAlltoClipboard();
                    Microsoft.Office.Interop.Excel.Application xlexcel;
                    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;
                    xlexcel = new Excel.Application();
                    xlexcel.Visible = true;
                    xlWorkBook = xlexcel.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                    CR.Select();
                    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                    Excel.Range aRange = xlWorkSheet.get_Range("A1", "J100");
                    aRange.EntireColumn.AutoFit();

                    int RowCount = dataGridView1.Rows.Count;
                    var columnHeadingsRange = xlWorkSheet.Range[
                    xlWorkSheet.Cells[1, 1],
                    xlWorkSheet.Cells[1, 5]];
                    columnHeadingsRange.Interior.Color = System.Drawing.Color.Yellow;
                    var table1 = xlWorkSheet.Range[
                    xlWorkSheet.Cells[1, 1],
                    xlWorkSheet.Cells[RowCount + 1, 5]];
                    table1.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    table1.Borders.Weight = Excel.XlBorderWeight.xlThin;
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPrint_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip2 = new ToolTip();
            ToolTip2.AutoPopDelay = 3000;
            ToolTip2.InitialDelay = 1000;
            ToolTip2.ReshowDelay = 500;
            ToolTip2.SetToolTip(this.btnPrint, "Print current data in table");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                npc = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                DetailPC dps = new DetailPC();
                dps.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            DataGridView sndr = (DataGridView)sender;

            if (sndr.Rows.Count == 0) // <-- if there are no rows in the DataGridView when it paints, then it will create your message
            {
                using (Graphics grfx = e.Graphics)
                {
                    // create a white rectangle so text will be easily readable
                    // grfx.FillRectangle(Brushes.White, new Rectangle(new Point(), new Size(sndr.Width, sndr.Height/2)));
                    // write text on top of the white rectangle just created
                    grfx.DrawString("No data found", new Font("Arial", 12), Brushes.Black, new PointF(sndr.Width / 2 - 50, sndr.Height / 2));
                }
            }
        }
    }
}
