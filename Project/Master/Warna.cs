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
    public partial class Warna : MetroFramework.Forms.MetroForm
    {
        public Warna()
        {
            InitializeComponent();
        }

        indomodaEntities db;

        private void Warna_Load(object sender, EventArgs e)
        {
            db = new indomodaEntities();
            colorBindingSource.DataSource = db.Colors.ToList();
        }

        private void btnRefreshWarna_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            colorBindingSource.DataSource = db.Colors.ToList();
            Cursor.Current = Cursors.Default;
        }

        private void btnAddWarna_Click(object sender, EventArgs e)
        {
            using (AddEditWarna addWarna = new AddEditWarna(new Color
            {
                ColorID = db.Colors.AsEnumerable().LastOrDefault() == null ? 1 : db.Colors.AsEnumerable().LastOrDefault().ColorID + 1
            }))
            {
                if (addWarna.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        colorBindingSource.Add(addWarna.ColorInfo);
                        db.Colors.Add(addWarna.ColorInfo);
                        db.SaveChangesAsync().Wait();
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEditWarna_Click(object sender, EventArgs e)
        {
            if (colorDataGrid.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add Color first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Color obj = colorBindingSource.Current as Color;
            if (obj != null)
            {
                using (AddEditWarna editWarna = new AddEditWarna(obj))
                {
                    if (editWarna.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            colorBindingSource.EndEdit();
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

        private void btnDeleteWarna_Click(object sender, EventArgs e)
        {
            if (colorDataGrid.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add Color first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to delete this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    int currentRow = colorDataGrid.CurrentRow.Index;
                    db.Colors.Remove(colorDataGrid.Rows[currentRow].DataBoundItem as Color);
                    colorBindingSource.RemoveAt(currentRow);
                    db.SaveChangesAsync().Wait();
                    // Refresh id to sync with db
                    colorBindingSource.DataSource = db.Colors.ToList();
                }
            }
        }

        private void btnSaveWarna_Click(object sender, EventArgs e)
        {
            try
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to save the changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    colorBindingSource.EndEdit();
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
    }
}
