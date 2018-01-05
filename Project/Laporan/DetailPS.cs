using Project.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace Project
{
    public partial class DetailPS : MetroFramework.Forms.MetroForm
    {
        public DetailPS()
        {
            InitializeComponent();
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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DetailPS_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                string query = LaporanPenerimaanSablon.nps;
                colorBindingSource.DataSource = db.Colors.ToList();
                List<LaporanPSModel> all = GenericQuery.SqlQuery<LaporanPSModel>("SELECT a.idDetail, a.noPenerimaan, a.noSPK, a.noSeri, a.type, a.tempSablon, a.tempBordir, a.tempCMT, b.model, b.ColorID, b.merk, b.ukuran, c.qtyAwalSablon, c.qtySablonBS, c.qtySablonHilang FROM DetailPenerimaanSBC a JOIN ListPenerimaanTukangPotong b ON a.noSeri = b.noSeri JOIN QuantityRecord c ON a.noSeri = c.noSeri WHERE a.type = 'sablon' AND a.noPenerimaan = '"+query+"'");
                detailPenerimaanSBCBindingSource.DataSource = all.ToList();

                int rowCount = dataGridView1.Rows.Count;
                for (int i = 0; i < rowCount; i++)
                {
                    double x = Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value);
                    double a = Convert.ToDouble(dataGridView1.Rows[i].Cells[9].Value);
                    double b = Convert.ToDouble(dataGridView1.Rows[i].Cells[10].Value);
                    double y = x - (a + b);
                    dataGridView1.Columns[0].ValueType = typeof(int);
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.UpdateCellValue(0, i);

                    dataGridView1.Columns[0].ValueType = typeof(int);
                    dataGridView1.Rows[i].Cells[11].Value = y;
                    dataGridView1.UpdateCellValue(0, i);
                }
                dataGridView1.Refresh();
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
    }
}
