﻿using Project.Helpers;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Project
{
    public partial class StockKain : MetroFramework.Forms.MetroForm
    {
        public StockKain()
        {
            InitializeComponent();
        }

        private void fetchButton_Click(object sender, EventArgs e)
        {
            string date1 = startDate.Value.ToString("yyyy-MM-dd 00:00:00");
            string date2 = endDate.Value.ToString("yyyy-MM-dd 00:00:00");
            DateTime StartDate = startDate.Value;
            DateTime EndDate = endDate.Value;
            int diff = EndDate.Date.Subtract(StartDate.Date).Days;

            if (StartDate.ToShortDateString() == EndDate.ToShortDateString())
            {
                MetroFramework.MetroMessageBox.Show(this, "Start Date and End Date can not be same", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (diff < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Start Date can not be greated than End Date", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.Rows.Clear();
                List<LaporanStokKain> withRange = GenericQuery.SqlQuery<LaporanStokKain>("SELECT a.DetailPOID, a.PONumber, a.MaterialID, a.ColorID, a.DetailQty, a.DetailPrice, a.DetailTotal, a.DetailStatus, b.Date_time FROM DetailPO a JOIN PreOrderKains b ON a.PONumber = b.PONumber WHERE b.Date_time BETWEEN '" + date1 + "' AND '" + date2 + "'");
                detailPOBindingSource.DataSource = withRange.ToList();

                int rowCount = dataGridView1.Rows.Count;
                for (int i = 0; i < rowCount; i++)
                {
                    string status = dataGridView1.Rows[i].Cells[9].Value.ToString();
                    dataGridView1.Columns[0].ValueType = typeof(int);
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.UpdateCellValue(0, i);

                    if (status == "True")
                    {
                        dataGridView1.Rows[i].Cells[8].Style.BackColor = System.Drawing.Color.LightGreen;
                        dataGridView1.Rows[i].Cells[8].Value = "Sudah diterima";
                        dataGridView1.UpdateCellValue(8, i);
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[8].Style.BackColor = System.Drawing.Color.LightPink;
                        dataGridView1.Rows[i].Cells[8].Value = "Belum diterima";
                        dataGridView1.UpdateCellValue(8, i);
                    }
                }

                dataGridView1.Columns[5].DefaultCellStyle.Format = "C";
                dataGridView1.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
                dataGridView1.Columns[6].DefaultCellStyle.Format = "C";
                dataGridView1.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
                dataGridView1.Columns[7].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss tt";
            }
        }

        private void StockKain_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                materialBindingSource.DataSource = db.Materials.ToList();
                colorBindingSource.DataSource = db.Colors.ToList();
                List<LaporanStokKain> all = GenericQuery.SqlQuery<LaporanStokKain>("SELECT a.DetailPOID, a.PONumber, a.MaterialID, a.ColorID, a.DetailQty, a.DetailPrice, a.DetailTotal, a.DetailStatus, b.Date_time FROM DetailPO a JOIN PreOrderKains b ON a.PONumber = b.PONumber");
                detailPOBindingSource.DataSource = all.ToList();

                int rowCount = dataGridView1.Rows.Count;
                for (int i = 0; i < rowCount; i++)
                {
                    string status = dataGridView1.Rows[i].Cells[9].Value.ToString();
                    dataGridView1.Columns[0].ValueType = typeof(int);
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.UpdateCellValue(0, i);

                    if (status == "True")
                    {
                        dataGridView1.Rows[i].Cells[8].Style.BackColor = System.Drawing.Color.LightGreen;
                        dataGridView1.Rows[i].Cells[8].Value = "Sudah diterima";
                        dataGridView1.UpdateCellValue(8, i);
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[8].Style.BackColor = System.Drawing.Color.LightPink;
                        dataGridView1.Rows[i].Cells[8].Value = "Belum diterima";
                        dataGridView1.UpdateCellValue(8, i);
                    }
                }
                dataGridView1.Columns[5].DefaultCellStyle.Format = "C";
                dataGridView1.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
                dataGridView1.Columns[6].DefaultCellStyle.Format = "C";
                dataGridView1.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
                dataGridView1.Columns[7].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss tt";
            }
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text;

            if (!IsDigitsOnly(query))
            {
                MetroFramework.MetroMessageBox.Show(this, "No PO must be numeric", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (query == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "No PO can not be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.Rows.Clear();
                List<LaporanStokKain> withRange = GenericQuery.SqlQuery<LaporanStokKain>("SELECT a.DetailPOID, a.PONumber, a.MaterialID, a.ColorID, a.DetailQty, a.DetailPrice, a.DetailTotal, a.DetailStatus, b.Date_time FROM DetailPO a JOIN PreOrderKains b ON a.PONumber = b.PONumber WHERE a.PONumber = '" + query + "'");
                detailPOBindingSource.DataSource = withRange.ToList();

                int rowCount = dataGridView1.Rows.Count;
                for (int i = 0; i < rowCount; i++)
                {
                    string status = dataGridView1.Rows[i].Cells[9].Value.ToString();
                    dataGridView1.Columns[0].ValueType = typeof(int);
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.UpdateCellValue(0, i);

                    if (status == "True")
                    {
                        dataGridView1.Rows[i].Cells[8].Style.BackColor = System.Drawing.Color.LightGreen;
                        dataGridView1.Rows[i].Cells[8].Value = "Sudah diterima";
                        dataGridView1.UpdateCellValue(8, i);
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[8].Style.BackColor = System.Drawing.Color.LightPink;
                        dataGridView1.Rows[i].Cells[8].Value = "Belum diterima";
                        dataGridView1.UpdateCellValue(8, i);
                    }
                }

                dataGridView1.Columns[5].DefaultCellStyle.Format = "C";
                dataGridView1.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
                dataGridView1.Columns[6].DefaultCellStyle.Format = "C";
                dataGridView1.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("id-ID");
                dataGridView1.Columns[7].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss tt";
            }
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
                    grfx.DrawString("No data found", new Font("Arial", 12), Brushes.Black, new PointF(sndr.Width/2 - 50, sndr.Height / 2));
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
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
        }
    }
}