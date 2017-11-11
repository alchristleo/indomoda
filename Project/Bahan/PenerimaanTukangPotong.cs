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
    public partial class PenerimaanTukangPotong : MetroFramework.Forms.MetroForm
    {
        private BindingSource _bs = null;
        private DataGridView _dv = null;
        private Form _form = null;
        public static int idPenerimaanTukangPotong;
        private List<ListPTPModel> _dpo = null;
        public List<ListPTPModel> listPO = new List<ListPTPModel>();

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

        public void setDPO(List<ListPTPModel> dpo)
        {
            _dpo = dpo;
        }

        public PenerimaanTukangPotong()
        {
            InitializeComponent();
        }

        private void btnExitPenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboNoPemotonganKain_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNoPemotonganKain.Items.Count > 0 && cboNoPemotonganKain.Text != "")
                {
                    cboNoPemotonganKain.Refresh();
                    string noPemotonganKain = cboNoPemotonganKain.SelectedValue.ToString();
                    var db = GenericQuery.SqlQuerySingle<PemotonganKainModel>("select pk.idPemotonganKain, pk.noPemotonganKain, pk.NoFaktur, pk.PONumber, pk.EmployeeID, pk.status, e.EmployeeCode, e.EmployeeName from DetailPemotonganKain pk JOIN Employees e on pk.EmployeeID = e.EmployeeID WHERE pk.status = '" + 0 + "' AND pk.noPemotonganKain = '" + noPemotonganKain + "'");
                    txtPICCode.Text = db.EmployeeCode.ToString();
                    txtPICName.Text = db.EmployeeName.ToString();
                }
            }
            catch (NullReferenceException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            idPenerimaanTukangPotong = Convert.ToInt32(txtIDPenerimaanTukangPotong.Text.ToString());
            AddPenerimaanTukangPotong addPenerimaanTukangPotong = new AddPenerimaanTukangPotong();
            addPenerimaanTukangPotong.setDGV(ref dataGridView1);
            addPenerimaanTukangPotong.setBS(ref listPenerimaanTukangPotongBindingSource);
            addPenerimaanTukangPotong.Show();
        }

        private void btnEditPenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add list penerimaan tukang potong first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletePenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You need to add detail PO first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to delete this data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    using (indomodaEntities db = new indomodaEntities())
                    {
                        try
                        {
                            int currentRow = dataGridView1.CurrentRow.Index;
                            int currentIDPTP = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                            int b = GenericQuery.ExecSQLCommand("DELETE FROM ListPenerimaanTukangPotong WHERE idListPTP = '" + currentIDPTP + "'");
                            db.SaveChangesAsync().Wait();
                            dataGridView1.Rows.RemoveAt(currentRow);
                            dataGridView1.Refresh();
                            listPenerimaanTukangPotongBindingSource.EndEdit();

                            MetroFramework.MetroMessageBox.Show(this, "Success! This Detail PO has been deleted to the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void PenerimaanTukangPotong_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                int setID = db.DetailPenerimaanTukangPotongs.AsEnumerable().LastOrDefault() == null ? 1 : db.DetailPenerimaanTukangPotongs.AsEnumerable().LastOrDefault().idPenerimaanTukangPotong + 1;
                txtIDPenerimaanTukangPotong.Text = setID.ToString();
                List<PemotonganKainModel> cboPK = GenericQuery.SqlQuery<PemotonganKainModel>("select pk.idPemotonganKain, pk.noPemotonganKain, pk.NoFaktur, pk.PONumber, pk.EmployeeID, pk.status, e.EmployeeCode, e.EmployeeName from DetailPemotonganKain pk JOIN Employees e on pk.EmployeeID = e.EmployeeID WHERE pk.status = '" + 0 + "'");
                detailPemotonganKainBindingSourceCbo.DataSource = cboPK.ToList();
            }
        }

        private void btnSavePenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            if (txtNoPenerimaanTukangPotong.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "No penerimaan tukang potong must be filled!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoPenerimaanTukangPotong.Focus();
            }
            else if (cboNoPemotonganKain.Items.Count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Pemotongan kain List is empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboNoPemotonganKain.Items.Count > 0 && txtPICCode.Text == "" && txtPICName.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select No pemotongan kain first!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNoPemotonganKain.Focus();
            }
            else
            {
                try
                {

                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
