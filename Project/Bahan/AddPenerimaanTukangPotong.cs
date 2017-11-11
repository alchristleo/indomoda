using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project.Helpers;
using Project.Models;

namespace Project
{
    public partial class AddPenerimaanTukangPotong : MetroFramework.Forms.MetroForm
    {
        private BindingSource _bs = null;
        private Form _form = null;
        private DataGridView _dv = null;
        private List<ListPTPModel> _dpo = null;
        public List<ListPTPModel> list = new List<ListPTPModel>();

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

        public void setDPO(ref List<ListPTPModel> dpo)
        {
            _dpo = dpo;
        }

        public AddPenerimaanTukangPotong()
        {
            InitializeComponent();
        }

        private void AddPenerimaanTukangPotong_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                colorBindingSource.DataSource = db.Colors.ToList();
            }
        }

        private void btnExitAddPenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnSaveAddPenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNoSeriTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "No. Seri can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoSeriTukangPotong.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtModelTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Model can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModelTukangPotong.Focus();
                return;
            }
            else if (cboWarna.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select warna!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboWarna.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtMerkTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Merk can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMerkTukangPotong.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtUkuranTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Ukuran can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUkuranTukangPotong.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtQtyTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Quantity can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtyTukangPotong.Focus();
                return;
            }
            else if (!IsDigitsOnly(txtQtyTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Quantity must be numeric!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtyTukangPotong.Clear();
                txtQtyTukangPotong.Focus();
                return;
            }
        }
    }
}
