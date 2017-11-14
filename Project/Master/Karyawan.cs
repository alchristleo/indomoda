using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Karyawan : MetroFramework.Forms.MetroForm
    {
        public Karyawan()
        {
            InitializeComponent();
        }

        indomodaEntities db;

        private void Karyawan_Load(object sender, EventArgs e)
        {
            db = new indomodaEntities();
            employeeBindingSource2.DataSource = db.Employees.ToList();
            int rowCount = employeeDataGrid.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                employeeDataGrid.Columns[0].ValueType = typeof(int);
                employeeDataGrid.Rows[i].Cells[0].Value = i + 1;
                employeeDataGrid.UpdateCellValue(0, i);
            }
            employeeDataGrid.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            employeeBindingSource2.DataSource = db.Employees.ToList();
            int rowCount = employeeDataGrid.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                employeeDataGrid.Columns[0].ValueType = typeof(int);
                employeeDataGrid.Rows[i].Cells[0].Value = i + 1;
                employeeDataGrid.UpdateCellValue(0, i);
            }
            employeeDataGrid.Refresh();
            Cursor.Current = Cursors.Hand;
        }

        private  void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (AddEditEmployee addKaryawan = new AddEditEmployee(new Employee {
                EmployeeID = db.Employees.AsEnumerable().LastOrDefault() == null ? 1 : db.Employees.AsEnumerable().LastOrDefault().EmployeeID + 1
            }))
            {
                if (addKaryawan.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        employeeBindingSource2.Add(addKaryawan.EmployeeInfo);
                        db.Employees.Add(addKaryawan.EmployeeInfo);
                        db.SaveChangesAsync().Wait();
                        int rowCount = employeeDataGrid.Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            employeeDataGrid.Columns[0].ValueType = typeof(int);
                            employeeDataGrid.Rows[i].Cells[0].Value = i + 1;
                            employeeDataGrid.UpdateCellValue(0, i);
                        }
                        employeeDataGrid.Refresh();

                        MetroFramework.MetroMessageBox.Show(this, "Success! New employee has been added to the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (employeeDataGrid.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add Karyawan first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Employee obj = employeeBindingSource2.Current as Employee;
            if (obj != null)
            {
                using (AddEditEmployee editKaryawan = new AddEditEmployee(obj))
                {
                    if (editKaryawan.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            employeeBindingSource2.EndEdit();
                            db.SaveChangesAsync();
                            MetroFramework.MetroMessageBox.Show(this, "Success! Employee data has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (employeeDataGrid.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add Karyawan first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to delete this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    int currentRow = employeeDataGrid.CurrentRow.Index;
                    db.Employees.Remove(employeeDataGrid.Rows[currentRow].DataBoundItem as Employee);
                    employeeBindingSource2.RemoveAt(currentRow);
                    db.SaveChangesAsync().Wait();
                    // Refresh id to sync with db
                    employeeBindingSource2.DataSource = db.Employees.ToList();
                    int rowCount = employeeDataGrid.Rows.Count;
                    for (int i = 0; i < rowCount; i++)
                    {
                        employeeDataGrid.Columns[0].ValueType = typeof(int);
                        employeeDataGrid.Rows[i].Cells[0].Value = i + 1;
                        employeeDataGrid.UpdateCellValue(0, i);
                    }
                    employeeDataGrid.Refresh();
                    MetroFramework.MetroMessageBox.Show(this, "Success! This employee has been removed from the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    employeeBindingSource2.EndEdit();
                    db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void employeeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
