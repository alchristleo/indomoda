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
    public partial class SPKSablon : MetroFramework.Forms.MetroForm
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

        public SPKSablon()
        {
            InitializeComponent();
        }

        private void SPKSablon_Load(object sender, EventArgs e)
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

        private void btnAddSPKSablon_Click(object sender, EventArgs e)
        {
            idSPK = Convert.ToInt32(txtIDSPK.Text.ToString());
            AddSpkSablon addspk = new AddSpkSablon();
            addspk.setDGV(ref dataGridView1);
            addspk.setBS(ref listPenerimaanTukangPotongBindingSource);
            addspk.Show();
        }

        private void btnDeleteSPKSablon_Click(object sender, EventArgs e)
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
                            bool setStatusSablon = false;
                            int a = GenericQuery.ExecSQLCommand("UPDATE ListPenerimaanTukangPotong SET statusSPKSablon = @statusSPKSablon, idSPKSablon = @idSPKSablon WHERE idListPTP = '" + currentIDPTP + "'", new[] {
                                new SqlParameter("@statusSPKSablon", setStatusSablon),
                                new SqlParameter("@idSPKSablon", setIDSPK)
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

        private void btnExitSPKSablon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveSPKSablon_Click(object sender, EventArgs e)
        {
            if (txtNoSpkSablon.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "No SPK Bordir must be filled!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoSpkSablon.Focus();
            }
            else if (cboPICSablon.Items.Count > 0 && txtPicCodeSablon.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Select the PIC Bordir first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPICSablon.Focus();
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
                        int setEID = Convert.ToInt32(cboPICSablon.SelectedValue.ToString());
                        string setType = "sablon";
                        int setStatus = 0;
                        int a = GenericQuery.ExecSQLCommand("INSERT INTO DetailSPK (idSPK, noSPK, EmployeeID, Datetime, type, status) VALUES(@idSPK, @noSPK, @EmployeeID, @Datetime, @type, @status)", new[] {
                            new SqlParameter("@idSPK", setIDSPK),
                            new SqlParameter("@noSPK", txtNoSpkSablon.Text.ToString()),
                            new SqlParameter("@EmployeeID", setEID),
                            new SqlParameter("@Datetime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                            new SqlParameter("@type", setType),
                            new SqlParameter("@status", setStatus)
                        });

                        db.SaveChangesAsync().Wait();

                        MetroFramework.MetroMessageBox.Show(this, "Success! No SPK for this data has been added to the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboPICSablon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPICSablon.Items.Count > 0 && cboPICSablon.Text != "")
            {
                int eID = Convert.ToInt32(cboPICSablon.SelectedValue.ToString());
                var dba = GenericQuery.SqlQuerySingle<Employee>("SELECT e.EmployeeID, e.EmployeeName, e.EmployeeCode, e.EmployeeEmail, e.EmployeePhone, e.EmployeePosition from Employees e WHERE e.EmployeeID = '" + eID + "'");
                txtPicCodeSablon.Text = dba.EmployeeCode.ToString();
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
                    dataGridView1.Rows[i].Cells[9].Value = "Sudah di sablon";
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
                    dataGridView1.Rows[i].Cells[9].Value = "Sudah di sablon";
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
    }
}
