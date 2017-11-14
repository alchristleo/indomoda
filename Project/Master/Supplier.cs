using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Supplier : MetroFramework.Forms.MetroForm
    {
        public Supplier()
        {
            InitializeComponent();
        }

        indomodaEntities db;

        private void Supplier_Load(object sender, EventArgs e)
        {
            db = new indomodaEntities();
            supplierBindingSource.DataSource = db.IndomodaSuppliers.ToList();
            int rowCount = supplierDataGrid.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                supplierDataGrid.Columns[0].ValueType = typeof(int);
                supplierDataGrid.Rows[i].Cells[0].Value = i + 1;
                supplierDataGrid.UpdateCellValue(0, i);
            }
            supplierDataGrid.Refresh();
        }

        private void btnRefreshSup_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            supplierBindingSource.DataSource = db.IndomodaSuppliers.ToList();
            int rowCount = supplierDataGrid.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                supplierDataGrid.Columns[0].ValueType = typeof(int);
                supplierDataGrid.Rows[i].Cells[0].Value = i + 1;
                supplierDataGrid.UpdateCellValue(0, i);
            }
            supplierDataGrid.Refresh();
            Cursor.Current = Cursors.Default;
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            using (AddEditSupplier addSupplier = new AddEditSupplier(new IndomodaSupplier
            {
                SupplierID = db.IndomodaSuppliers.AsEnumerable().LastOrDefault() == null ? 1 : db.IndomodaSuppliers.AsEnumerable().LastOrDefault().SupplierID + 1
            }))
            {
                if (addSupplier.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        supplierBindingSource.Add(addSupplier.SupplierInfo);
                        db.IndomodaSuppliers.Add(addSupplier.SupplierInfo);
                        db.SaveChangesAsync().Wait();
                        int rowCount = supplierDataGrid.Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            supplierDataGrid.Columns[0].ValueType = typeof(int);
                            supplierDataGrid.Rows[i].Cells[0].Value = i + 1;
                            supplierDataGrid.UpdateCellValue(0, i);
                        }
                        supplierDataGrid.Refresh();
                        MetroFramework.MetroMessageBox.Show(this, "Success! New supplier has been added to the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEditSup_Click(object sender, EventArgs e)
        {
            if(supplierDataGrid.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add Supplier first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            IndomodaSupplier obj = supplierBindingSource.Current as IndomodaSupplier;
            if (obj != null)
            {
                using (AddEditSupplier editSupplier = new AddEditSupplier(obj))
                {
                    if (editSupplier.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            supplierBindingSource.EndEdit();
                            db.SaveChangesAsync();
                            MetroFramework.MetroMessageBox.Show(this, "Success! This supplier data has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnDeleteSup_Click(object sender, EventArgs e)
        {
            if (supplierDataGrid.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add Supplier first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to delete this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    int currentRow = supplierDataGrid.CurrentRow.Index;
                    db.IndomodaSuppliers.Remove(supplierDataGrid.Rows[currentRow].DataBoundItem as IndomodaSupplier);
                    supplierBindingSource.RemoveAt(currentRow);
                    db.SaveChangesAsync().Wait();
                    // Refresh id to sync with db
                    supplierBindingSource.DataSource = db.IndomodaSuppliers.ToList();
                    int rowCount = supplierDataGrid.Rows.Count;
                    for (int i = 0; i < rowCount; i++)
                    {
                        supplierDataGrid.Columns[0].ValueType = typeof(int);
                        supplierDataGrid.Rows[i].Cells[0].Value = i + 1;
                        supplierDataGrid.UpdateCellValue(0, i);
                    }
                    supplierDataGrid.Refresh();
                    MetroFramework.MetroMessageBox.Show(this, "Success! This supplier has been removed from the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void btnSaveSup_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    supplierBindingSource.EndEdit();
                    db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
