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
using System.Data.SqlClient;

namespace Project
{
    public partial class EditPenerimaanTukangPotong : MetroFramework.Forms.MetroForm
    {
        private BindingSource _bs = null;
        private Form _form = null;
        private DataGridView _dv = null;
        private List<ListPTPModel> _dpo = null;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtQtyTukangPotong;
        private MetroFramework.Controls.MetroTextBox txtUkuranTukangPotong;
        private MetroFramework.Controls.MetroTextBox txtMerkTukangPotong;
        private MetroFramework.Controls.MetroComboBox cboWarna;
        private MetroFramework.Controls.MetroTextBox txtModelTukangPotong;
        private MetroFramework.Controls.MetroTextBox txtNoSeriTukangPotong;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnExitEditPenerimaanTukangPotong;
        private MetroFramework.Controls.MetroButton btnSaveAddPenerimaanTukangPotong;
        private BindingSource colorBindingSource;
        private IContainer components;
        private MetroFramework.Controls.MetroButton btnSaveEditPenrimaanTukangPotong;
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

        public EditPenerimaanTukangPotong()
        {
            InitializeComponent();
        }

        private void EditPenerimaanTukangPotong_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                colorBindingSource.DataSource = db.Colors.ToList();
            }
        }

        private void btnExitEditPenerimaanTukangPotong_Click(object sender, EventArgs e)
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

        private void btnSaveEditPenerimaanTukangPotong_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNoSeriTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "No. Seri can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoSeriTukangPotong.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtModelTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Model can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModelTukangPotong.Focus();
                return;
            }
            else if (cboWarna.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "You must select warna!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboWarna.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtMerkTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Merk can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMerkTukangPotong.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtUkuranTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Ukuran can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUkuranTukangPotong.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(txtQtyTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Quantity can't be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtyTukangPotong.Focus();
                return;
            }
            else if (!IsDigitsOnly(txtQtyTukangPotong.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Quantity must be numeric!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtyTukangPotong.Clear();
                txtQtyTukangPotong.Focus();
                return;
            }
            using (indomodaEntities db = new indomodaEntities())
            {
                list = _dpo;
                int setIDListPTP = list[0].idListPTP;
                int getIDPTP = Convert.ToInt32(PenerimaanTukangPotong.idPenerimaanTukangPotong);
                string getNoSeri = txtNoSeriTukangPotong.Text;
                string getModel = txtModelTukangPotong.Text;
                int getColorID = Convert.ToInt32(cboWarna.SelectedValue.ToString());
                string getMerk = txtMerkTukangPotong.Text;
                string getUkuran = txtUkuranTukangPotong.Text;
                int getQty = Convert.ToInt32(txtQtyTukangPotong.Text.ToString());

                if (MetroFramework.MetroMessageBox.Show(this, "Do you want to save this List penerimaan tukang potong to database?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int a = GenericQuery.ExecSQLCommand("UPDATE ListPenerimaanTukangPotong SET idListPTP = @idListPTP, idPenerimaanTukangPotong = @idPenerimaanTukangPotong, noSeri = @noSeri, model = @model, ColorID = @ColorID, merk = @merk, ukuran = @ukuran, quantity = @quantity WHERE idListPTP = '"+setIDListPTP+"'", new[] {
                                new SqlParameter("@idListPTP", setIDListPTP),
                                new SqlParameter("@idPenerimaanTukangPotong", getIDPTP),
                                new SqlParameter("@noSeri", getNoSeri),
                                new SqlParameter("@model", getModel),
                                new SqlParameter("@ColorID", getColorID),
                                new SqlParameter("@merk", getMerk),
                                new SqlParameter("@ukuran", getUkuran),
                                new SqlParameter("@quantity", getQty)
                            });
                        db.SaveChangesAsync().Wait();

                        if (_bs == null)
                        {
                            _bs = new BindingSource();
                        }

                        foreach (var i in _bs.List.Cast<ListPenerimaanTukangPotong>().Where(x => x.idListPTP == setIDListPTP))
                        {
                            i.idPenerimaanTukangPotong = getIDPTP;
                            i.noSeri = getNoSeri;
                            i.model = getModel;
                            i.ColorID = getColorID;
                            i.merk = getMerk;
                            i.ukuran = getUkuran;
                            i.quantity = getQty;
                        }
                        _dv.DataSource = _bs;
                        _dv.EndEdit();
                        _dv.Refresh();
                        MetroFramework.MetroMessageBox.Show(this, "Success! This list penerimaan tukang potong has been updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.Close();
            }
        }

        private void EditPenerimaanTukangPotong_Load_1(object sender, EventArgs e)
        {
            using (indomodaEntities entity = new indomodaEntities())
            {
                colorBindingSource.DataSource = entity.Colors.ToList();
            }

            list = _dpo;

            if (list != null && list.Count > 0)
            {
                cboWarna.SelectedValue = list[0].ColorID;
                txtNoSeriTukangPotong.Text = list[0].noSeri.ToString();
                txtModelTukangPotong.Text = list[0].model.ToString();
                txtMerkTukangPotong.Text = list[0].merk.ToString();
                txtUkuranTukangPotong.Text = list[0].ukuran.ToString();
                txtQtyTukangPotong.Text = list[0].quantity.ToString();
                //cboMaterialCode.Refresh();
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtQtyTukangPotong = new MetroFramework.Controls.MetroTextBox();
            this.txtUkuranTukangPotong = new MetroFramework.Controls.MetroTextBox();
            this.txtMerkTukangPotong = new MetroFramework.Controls.MetroTextBox();
            this.cboWarna = new MetroFramework.Controls.MetroComboBox();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtModelTukangPotong = new MetroFramework.Controls.MetroTextBox();
            this.txtNoSeriTukangPotong = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnExitEditPenerimaanTukangPotong = new MetroFramework.Controls.MetroButton();
            this.btnSaveAddPenerimaanTukangPotong = new MetroFramework.Controls.MetroButton();
            this.btnSaveEditPenrimaanTukangPotong = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(295, 261);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(28, 19);
            this.metroLabel7.TabIndex = 33;
            this.metroLabel7.Text = "pcs";
            // 
            // txtQtyTukangPotong
            // 
            // 
            // 
            // 
            this.txtQtyTukangPotong.CustomButton.Image = null;
            this.txtQtyTukangPotong.CustomButton.Location = new System.Drawing.Point(30, 1);
            this.txtQtyTukangPotong.CustomButton.Name = "";
            this.txtQtyTukangPotong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQtyTukangPotong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQtyTukangPotong.CustomButton.TabIndex = 1;
            this.txtQtyTukangPotong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQtyTukangPotong.CustomButton.UseSelectable = true;
            this.txtQtyTukangPotong.CustomButton.Visible = false;
            this.txtQtyTukangPotong.Lines = new string[0];
            this.txtQtyTukangPotong.Location = new System.Drawing.Point(241, 257);
            this.txtQtyTukangPotong.MaxLength = 32767;
            this.txtQtyTukangPotong.Name = "txtQtyTukangPotong";
            this.txtQtyTukangPotong.PasswordChar = '\0';
            this.txtQtyTukangPotong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQtyTukangPotong.SelectedText = "";
            this.txtQtyTukangPotong.SelectionLength = 0;
            this.txtQtyTukangPotong.SelectionStart = 0;
            this.txtQtyTukangPotong.ShortcutsEnabled = true;
            this.txtQtyTukangPotong.Size = new System.Drawing.Size(52, 23);
            this.txtQtyTukangPotong.TabIndex = 24;
            this.txtQtyTukangPotong.UseSelectable = true;
            this.txtQtyTukangPotong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQtyTukangPotong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUkuranTukangPotong
            // 
            // 
            // 
            // 
            this.txtUkuranTukangPotong.CustomButton.Image = null;
            this.txtUkuranTukangPotong.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtUkuranTukangPotong.CustomButton.Name = "";
            this.txtUkuranTukangPotong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUkuranTukangPotong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUkuranTukangPotong.CustomButton.TabIndex = 1;
            this.txtUkuranTukangPotong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUkuranTukangPotong.CustomButton.UseSelectable = true;
            this.txtUkuranTukangPotong.CustomButton.Visible = false;
            this.txtUkuranTukangPotong.Lines = new string[0];
            this.txtUkuranTukangPotong.Location = new System.Drawing.Point(241, 227);
            this.txtUkuranTukangPotong.MaxLength = 32767;
            this.txtUkuranTukangPotong.Name = "txtUkuranTukangPotong";
            this.txtUkuranTukangPotong.PasswordChar = '\0';
            this.txtUkuranTukangPotong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUkuranTukangPotong.SelectedText = "";
            this.txtUkuranTukangPotong.SelectionLength = 0;
            this.txtUkuranTukangPotong.SelectionStart = 0;
            this.txtUkuranTukangPotong.ShortcutsEnabled = true;
            this.txtUkuranTukangPotong.Size = new System.Drawing.Size(147, 23);
            this.txtUkuranTukangPotong.TabIndex = 23;
            this.txtUkuranTukangPotong.UseSelectable = true;
            this.txtUkuranTukangPotong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUkuranTukangPotong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMerkTukangPotong
            // 
            // 
            // 
            // 
            this.txtMerkTukangPotong.CustomButton.Image = null;
            this.txtMerkTukangPotong.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtMerkTukangPotong.CustomButton.Name = "";
            this.txtMerkTukangPotong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMerkTukangPotong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMerkTukangPotong.CustomButton.TabIndex = 1;
            this.txtMerkTukangPotong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMerkTukangPotong.CustomButton.UseSelectable = true;
            this.txtMerkTukangPotong.CustomButton.Visible = false;
            this.txtMerkTukangPotong.Lines = new string[0];
            this.txtMerkTukangPotong.Location = new System.Drawing.Point(241, 198);
            this.txtMerkTukangPotong.MaxLength = 32767;
            this.txtMerkTukangPotong.Name = "txtMerkTukangPotong";
            this.txtMerkTukangPotong.PasswordChar = '\0';
            this.txtMerkTukangPotong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMerkTukangPotong.SelectedText = "";
            this.txtMerkTukangPotong.SelectionLength = 0;
            this.txtMerkTukangPotong.SelectionStart = 0;
            this.txtMerkTukangPotong.ShortcutsEnabled = true;
            this.txtMerkTukangPotong.Size = new System.Drawing.Size(147, 23);
            this.txtMerkTukangPotong.TabIndex = 22;
            this.txtMerkTukangPotong.UseSelectable = true;
            this.txtMerkTukangPotong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMerkTukangPotong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboWarna
            // 
            this.cboWarna.DataSource = this.colorBindingSource;
            this.cboWarna.DisplayMember = "ColorName";
            this.cboWarna.FormattingEnabled = true;
            this.cboWarna.ItemHeight = 23;
            this.cboWarna.Location = new System.Drawing.Point(241, 162);
            this.cboWarna.Name = "cboWarna";
            this.cboWarna.Size = new System.Drawing.Size(147, 29);
            this.cboWarna.TabIndex = 21;
            this.cboWarna.UseSelectable = true;
            this.cboWarna.ValueMember = "ColorID";
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(Project.Color);
            // 
            // txtModelTukangPotong
            // 
            // 
            // 
            // 
            this.txtModelTukangPotong.CustomButton.Image = null;
            this.txtModelTukangPotong.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtModelTukangPotong.CustomButton.Name = "";
            this.txtModelTukangPotong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtModelTukangPotong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtModelTukangPotong.CustomButton.TabIndex = 1;
            this.txtModelTukangPotong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtModelTukangPotong.CustomButton.UseSelectable = true;
            this.txtModelTukangPotong.CustomButton.Visible = false;
            this.txtModelTukangPotong.Lines = new string[0];
            this.txtModelTukangPotong.Location = new System.Drawing.Point(241, 133);
            this.txtModelTukangPotong.MaxLength = 32767;
            this.txtModelTukangPotong.Name = "txtModelTukangPotong";
            this.txtModelTukangPotong.PasswordChar = '\0';
            this.txtModelTukangPotong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModelTukangPotong.SelectedText = "";
            this.txtModelTukangPotong.SelectionLength = 0;
            this.txtModelTukangPotong.SelectionStart = 0;
            this.txtModelTukangPotong.ShortcutsEnabled = true;
            this.txtModelTukangPotong.Size = new System.Drawing.Size(147, 23);
            this.txtModelTukangPotong.TabIndex = 20;
            this.txtModelTukangPotong.UseSelectable = true;
            this.txtModelTukangPotong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtModelTukangPotong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNoSeriTukangPotong
            // 
            // 
            // 
            // 
            this.txtNoSeriTukangPotong.CustomButton.Image = null;
            this.txtNoSeriTukangPotong.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtNoSeriTukangPotong.CustomButton.Name = "";
            this.txtNoSeriTukangPotong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNoSeriTukangPotong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNoSeriTukangPotong.CustomButton.TabIndex = 1;
            this.txtNoSeriTukangPotong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNoSeriTukangPotong.CustomButton.UseSelectable = true;
            this.txtNoSeriTukangPotong.CustomButton.Visible = false;
            this.txtNoSeriTukangPotong.Lines = new string[0];
            this.txtNoSeriTukangPotong.Location = new System.Drawing.Point(241, 105);
            this.txtNoSeriTukangPotong.MaxLength = 32767;
            this.txtNoSeriTukangPotong.Name = "txtNoSeriTukangPotong";
            this.txtNoSeriTukangPotong.PasswordChar = '\0';
            this.txtNoSeriTukangPotong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNoSeriTukangPotong.SelectedText = "";
            this.txtNoSeriTukangPotong.SelectionLength = 0;
            this.txtNoSeriTukangPotong.SelectionStart = 0;
            this.txtNoSeriTukangPotong.ShortcutsEnabled = true;
            this.txtNoSeriTukangPotong.Size = new System.Drawing.Size(147, 23);
            this.txtNoSeriTukangPotong.TabIndex = 19;
            this.txtNoSeriTukangPotong.UseSelectable = true;
            this.txtNoSeriTukangPotong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNoSeriTukangPotong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(137, 257);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Quantity";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(137, 227);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "Ukuran";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(137, 198);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Merk";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(137, 162);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "Warna";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(137, 133);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Model";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(137, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "No. Seri";
            // 
            // btnExitEditPenerimaanTukangPotong
            // 
            this.btnExitEditPenerimaanTukangPotong.Location = new System.Drawing.Point(137, 310);
            this.btnExitEditPenerimaanTukangPotong.Name = "btnExitEditPenerimaanTukangPotong";
            this.btnExitEditPenerimaanTukangPotong.Size = new System.Drawing.Size(93, 47);
            this.btnExitEditPenerimaanTukangPotong.TabIndex = 26;
            this.btnExitEditPenerimaanTukangPotong.Text = "EXIT";
            this.btnExitEditPenerimaanTukangPotong.UseSelectable = true;
            this.btnExitEditPenerimaanTukangPotong.Click += new System.EventHandler(this.btnExitEditPenerimaanTukangPotong_Click);
            // 
            // btnSaveAddPenerimaanTukangPotong
            // 
            this.btnSaveAddPenerimaanTukangPotong.Location = new System.Drawing.Point(0, 0);
            this.btnSaveAddPenerimaanTukangPotong.Name = "btnSaveAddPenerimaanTukangPotong";
            this.btnSaveAddPenerimaanTukangPotong.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAddPenerimaanTukangPotong.TabIndex = 0;
            this.btnSaveAddPenerimaanTukangPotong.UseSelectable = true;
            // 
            // btnSaveEditPenrimaanTukangPotong
            // 
            this.btnSaveEditPenrimaanTukangPotong.Location = new System.Drawing.Point(295, 310);
            this.btnSaveEditPenrimaanTukangPotong.Name = "btnSaveEditPenrimaanTukangPotong";
            this.btnSaveEditPenrimaanTukangPotong.Size = new System.Drawing.Size(93, 47);
            this.btnSaveEditPenrimaanTukangPotong.TabIndex = 34;
            this.btnSaveEditPenrimaanTukangPotong.Text = "SAVE";
            this.btnSaveEditPenrimaanTukangPotong.UseSelectable = true;
            this.btnSaveEditPenrimaanTukangPotong.Click += new System.EventHandler(this.btnSaveEditPenerimaanTukangPotong_Click);
            // 
            // EditPenerimaanTukangPotong
            // 
            this.ClientSize = new System.Drawing.Size(539, 415);
            this.Controls.Add(this.btnSaveEditPenrimaanTukangPotong);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtQtyTukangPotong);
            this.Controls.Add(this.txtUkuranTukangPotong);
            this.Controls.Add(this.txtMerkTukangPotong);
            this.Controls.Add(this.cboWarna);
            this.Controls.Add(this.txtModelTukangPotong);
            this.Controls.Add(this.txtNoSeriTukangPotong);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnExitEditPenerimaanTukangPotong);
            this.Name = "EditPenerimaanTukangPotong";
            this.Text = "Edit Penerimaan Tukang Potong";
            this.Load += new System.EventHandler(this.EditPenerimaanTukangPotong_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
