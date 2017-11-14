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
    public partial class MasterBahan : MetroFramework.Forms.MetroForm
    {
        public MasterBahan()
        {
            InitializeComponent();
        }

        indomodaEntities db;

        private void MasterBahan_Load(object sender, EventArgs e)
        {
            db = new indomodaEntities();
            materialBindingSource.DataSource = db.Materials.ToList();
            int rowCount = dataGridBahan.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                dataGridBahan.Columns[0].ValueType = typeof(int);
                dataGridBahan.Rows[i].Cells[0].Value = i + 1;
                dataGridBahan.UpdateCellValue(0, i);
            }
            dataGridBahan.Refresh();
        }

        private void btnRefreshBahan_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            materialBindingSource.DataSource = db.Materials.ToList();
            int rowCount = dataGridBahan.Rows.Count;
            for (int i = 0; i < rowCount; i++)
            {
                dataGridBahan.Columns[0].ValueType = typeof(int);
                dataGridBahan.Rows[i].Cells[0].Value = i + 1;
                dataGridBahan.UpdateCellValue(0, i);
            }
            dataGridBahan.Refresh();
            Cursor.Current = Cursors.Hand;
        }

        private void btnAddBahan_Click(object sender, EventArgs e)
        {
            using (AddEditMaterial addMaterial = new AddEditMaterial(new Material
            {
                MaterialID = db.Materials.AsEnumerable().LastOrDefault() == null ? 1 : db.Materials.AsEnumerable().LastOrDefault().MaterialID + 1
            }))
            {
                if (addMaterial.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        materialBindingSource.Add(addMaterial.MaterialInfo);
                        db.Materials.Add(addMaterial.MaterialInfo);
                        db.SaveChangesAsync().Wait();

                        int rowCount = dataGridBahan.Rows.Count;
                        for (int i = 0; i < rowCount; i++)
                        {
                            dataGridBahan.Columns[0].ValueType = typeof(int);
                            dataGridBahan.Rows[i].Cells[0].Value = i + 1;
                            dataGridBahan.UpdateCellValue(0, i);
                        }
                        dataGridBahan.Refresh();

                        MetroFramework.MetroMessageBox.Show(this, "Success! New material has been added to the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEditBahan_Click(object sender, EventArgs e)
        {
            if (dataGridBahan.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add Bahan first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Material obj = materialBindingSource.Current as Material;
            if (obj != null)
            {
                using (AddEditMaterial editMaterial = new AddEditMaterial(obj))
                {
                    if (editMaterial.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            materialBindingSource.EndEdit();
                            db.SaveChangesAsync();
                            MetroFramework.MetroMessageBox.Show(this, "Success! This material data has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnDeleteBahan_Click(object sender, EventArgs e)
        {
            if (dataGridBahan.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add Bahan first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to delete this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    int currentRow = dataGridBahan.CurrentRow.Index;
                    db.Materials.Remove(dataGridBahan.Rows[currentRow].DataBoundItem as Material);
                    materialBindingSource.RemoveAt(currentRow);
                    db.SaveChangesAsync().Wait();
                    // Refresh id to sync with db
                    materialBindingSource.DataSource = db.Materials.ToList();
                    int rowCount = dataGridBahan.Rows.Count;
                    for (int i = 0; i < rowCount; i++)
                    {
                        dataGridBahan.Columns[0].ValueType = typeof(int);
                        dataGridBahan.Rows[i].Cells[0].Value = i + 1;
                        dataGridBahan.UpdateCellValue(0, i);
                    }
                    dataGridBahan.Refresh();
                    MetroFramework.MetroMessageBox.Show(this, "Success! This material has been removed from the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void btnSaveBahan_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    materialBindingSource.EndEdit();
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
