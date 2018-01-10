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
    public partial class Pembeli : MetroFramework.Forms.MetroForm
    {
        public Pembeli()
        {
            InitializeComponent();
        }

        indomodaEntities db;

        private void setNumber()
        {
            int rowCount = customerDataGrid.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                customerDataGrid.Columns[0].ValueType = typeof(int);
                customerDataGrid.Rows[i].Cells[0].Value = i + 1;
                customerDataGrid.UpdateCellValue(0, i);
            }
            customerDataGrid.Refresh();
        }

        private void Pembeli_Load(object sender, EventArgs e)
        {
            db = new indomodaEntities();
            customerBindingSource.DataSource = db.Customers.ToList();
            setNumber();
        }

        private void btnRefreshCust_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            customerBindingSource.DataSource = db.Customers.ToList();
            setNumber();
            Cursor.Current = Cursors.Hand;
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            using (AddEditPembeli addPembeli = new AddEditPembeli(new Customer
            {
                CustomerID = db.Customers.AsEnumerable().LastOrDefault() == null ? 1 : db.Customers.AsEnumerable().LastOrDefault().CustomerID + 1
            }))
            {
                if (addPembeli.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        customerBindingSource.Add(addPembeli.CustomerInfo);
                        db.Customers.Add(addPembeli.CustomerInfo);
                        db.SaveChangesAsync().Wait();
                        setNumber();
                        MetroFramework.MetroMessageBox.Show(this, "Success! New customer has been added to the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEditCust_Click(object sender, EventArgs e)
        {
            if (customerDataGrid.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add Customer first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Customer obj = customerBindingSource.Current as Customer;
            if (obj != null)
            {
                using (AddEditPembeli editPembeli = new AddEditPembeli(obj))
                {
                    if (editPembeli.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            customerBindingSource.EndEdit();
                            db.SaveChangesAsync();
                            MetroFramework.MetroMessageBox.Show(this, "Success! This customer data has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            if (customerDataGrid.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add Customer first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to delete this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    int currentRow = customerDataGrid.CurrentRow.Index;
                    db.Customers.Remove(customerDataGrid.Rows[currentRow].DataBoundItem as Customer);
                    customerBindingSource.RemoveAt(currentRow);
                    db.SaveChangesAsync().Wait();
                    // Refresh id to sync with db
                    customerBindingSource.DataSource = db.Customers.ToList();
                    setNumber();
                    MetroFramework.MetroMessageBox.Show(this, "Success! This customer hase been removed from the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void btnSaveCust_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    customerBindingSource.EndEdit();
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
