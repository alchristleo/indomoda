using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Reflection;
using System.Data.SqlClient;
using Project.Helpers;
using Project.Models;

namespace Project
{
    public partial class EditPOKain : MetroForm
    {
        private BindingSource _bs = null;
        private Form _form = null;
        private DataGridView _dv = null;
        private List<DetailPOModel> _dpo = null;
        public List<DetailPOModel> list = new List<DetailPOModel>();

        public void setRefForm(Form form)
        {
            _form = form;
        }

        public void setBS(ref BindingSource bs)
        {
            _bs = bs;
        }

        public void setDGV(ref DataGridView dv)
        {
            _dv = dv;
        }

        public void setDPO(ref List<DetailPOModel> dpo)
        {
            _dpo = dpo;
        }

        public EditPOKain()
        {
            InitializeComponent();

        }

        private void btnExitPOKain_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnSavePOKain_Click(object sender, EventArgs e)
        {
            if (cboMaterialCode.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select the Bahan Code!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaterialCode.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtAddMaterialName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Bahan name can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddMaterialName.Focus();
                return;
            }
            else if (cboColorCode.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select the Warna Code!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboColorCode.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtAddColorName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Warna name can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddColorName.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtAddQuantity.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Quantity can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddQuantity.Focus();
                return;
            }
            else if (!IsDigitsOnly(txtAddQuantity.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Quantity must be numeric!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddQuantity.Clear();
                txtAddQuantity.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtAddPrice.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Price can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddPrice.Focus();
                return;
            }
            else if (!IsDigitsOnly(txtAddPrice.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Price must be numeric!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddPrice.Clear();
                txtAddPrice.Focus();
                return;
            }

            using (indomodaEntities db = new indomodaEntities())
            {
                list = _dpo;
                int setDetailPOID = list[0].DetailPOID; 
                long getPONumber = Convert.ToInt64(poKain.poNumber);
                int getMaterialID = Convert.ToInt32(cboMaterialCode.SelectedValue.ToString());
                int getColorID = Convert.ToInt32(cboColorCode.SelectedValue.ToString());
                int getQty = Convert.ToInt32(txtAddQuantity.Text.ToString());
                int getPrice = Convert.ToInt32(txtAddPrice.Text.ToString());
                int setTotal = getQty * getPrice;
                bool setStatus = false;

                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to save this detail PO to database?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int a = GenericQuery.ExecSQLCommand("UPDATE DetailPO SET DetailPOID = @DetailPOID, PONumber = @PONumber, MaterialID = @MaterialID, ColorID = @ColorID, DetailQty = @DetailQty, DetailPrice = @DetailPrice, DetailTotal = @DetailTotal, DetailStatus = @DetailStatus WHERE DetailPOID = '"+setDetailPOID+"'", new[] {
                                new SqlParameter("DetailPOID", setDetailPOID),
                                new SqlParameter("@PONumber", getPONumber),
                                new SqlParameter("@MaterialID", getMaterialID),
                                new SqlParameter("@ColorID", getColorID),
                                new SqlParameter("@DetailQty", getQty),
                                new SqlParameter("@DetailPrice", getPrice),
                                new SqlParameter("@DetailTotal", setTotal),
                                new SqlParameter("@DetailStatus", setStatus)
                            });
                        db.SaveChangesAsync().Wait();

                        if (_bs == null)
                        {
                            _bs = new BindingSource();
                        }

                        foreach (var i in _bs.List.Cast<DetailPO>().Where(x => x.DetailPOID == setDetailPOID))
                        {
                            i.PONumber = getPONumber;
                            i.MaterialID = getMaterialID;
                            i.ColorID = getColorID;
                            i.DetailQty = getQty;
                            i.DetailPrice = getPrice;
                            i.DetailTotal = setTotal;
                            i.DetailStatus = setStatus;
                        }
                        _dv.DataSource = _bs;
                        _dv.EndEdit();
                        _dv.Refresh();
                        MetroFramework.MetroMessageBox.Show(this, "Success! This detail PO has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.Close();
            }
        }

        private void EditPOKain_Load(object sender, EventArgs e)
        {
            using (indomodaEntities entity = new indomodaEntities())
            {
                colorBindingSource.DataSource = entity.Colors.ToList();
                materialBindingSource.DataSource = entity.Materials.ToList();
            }

            list = _dpo;

            if (list != null && list.Count > 0)
            {
                cboMaterialCode.SelectedValue = list[0].MaterialID;
                txtAddMaterialName.Text = list[0].MaterialName;
                cboColorCode.SelectedValue = list[0].ColorID;
                txtAddColorName.Text = list[0].ColorName;
                txtAddQuantity.Text = list[0].DetailQty.ToString();
                txtAddPrice.Text = list[0].DetailPrice.ToString();
                //cboMaterialCode.Refresh();
            }
        }
    }
}
