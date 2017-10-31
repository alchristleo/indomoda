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

        private void Pembeli_Load(object sender, EventArgs e)
        {
            db = new indomodaEntities();
            customerBindingSource.DataSource = db.Customers.ToList();
        }

        private void btnRefreshCust_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            customerBindingSource.DataSource = db.Customers.ToList();
            Cursor.Current = Cursors.Default;
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
