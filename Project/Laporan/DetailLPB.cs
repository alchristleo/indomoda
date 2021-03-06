﻿using Project.Helpers;
using Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Project
{
    public partial class DetailLPB : MetroFramework.Forms.MetroForm
    {
        public DetailLPB()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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

            Excel.Range aRange = xlWorkSheet.get_Range("A1", "M100");
            aRange.EntireColumn.AutoFit();

            int RowCount = dataGridView1.Rows.Count;
            var columnHeadingsRange = xlWorkSheet.Range[
            xlWorkSheet.Cells[1, 1],
            xlWorkSheet.Cells[1, 10]];
            columnHeadingsRange.Interior.Color = System.Drawing.Color.Yellow;
            var table1 = xlWorkSheet.Range[
            xlWorkSheet.Cells[1, 1],
            xlWorkSheet.Cells[RowCount + 1, 10]];
            table1.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            table1.Borders.Weight = Excel.XlBorderWeight.xlThin;
        }

        private void btnPrint_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip2 = new ToolTip();
            ToolTip2.AutoPopDelay = 3000;
            ToolTip2.InitialDelay = 1000;
            ToolTip2.ReshowDelay = 500;
            ToolTip2.SetToolTip(this.btnPrint, "Print current data in table");
        }

        private void DetailPenjualanBaju_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                string query = LaporanPenjualan.ntb;
                colorBindingSource.DataSource = db.Colors.ToList();
                List<LaporanPenjualanBajuModel> all = GenericQuery.SqlQuery<LaporanPenjualanBajuModel>("SELECT a.idLPB, a.idDPB, a.noSeri, a.model, a.ColorID, a.merk, a.ukuran, a.qtyLPB, a.priceLPB, a.totalLPB, a.statusLPB, b.noPenjualan FROM ListPenjualanBaju a JOIN DetailPenjualanBaju b ON a.idDPB = b.idDPB WHERE b.noPenjualan = '" + query + "'");
                listPenjualanBajuBindingSource.DataSource = all.ToList();

                int rowCount = dataGridView1.Rows.Count;
                for (int i = 0; i < rowCount; i++)
                {
                    double stock = Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value.ToString());
                    dataGridView1.Columns[0].ValueType = typeof(int);
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.UpdateCellValue(0, i);
                }
                dataGridView1.Columns[8].DefaultCellStyle.Format = "C";
                dataGridView1.Columns[8].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
                dataGridView1.Columns[9].DefaultCellStyle.Format = "C";
                dataGridView1.Columns[9].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
            }
        }
    }
}
