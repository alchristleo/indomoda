using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project
{
    public partial class AddEditMaterial : MetroFramework.Forms.MetroForm
    {
        private MetroFramework.Controls.MetroButton btnClearMaterial;
        private MetroFramework.Controls.MetroButton btnSaveMaterial;
        private MetroFramework.Controls.MetroTextBox lblMaterialName;
        private MetroFramework.Controls.MetroTextBox lblMaterialCode;
        private MetroFramework.Controls.MetroTextBox lblMaterialID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private BindingSource bindingSourceMaterial;
        private IContainer components;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnClearMaterial = new MetroFramework.Controls.MetroButton();
            this.btnSaveMaterial = new MetroFramework.Controls.MetroButton();
            this.lblMaterialName = new MetroFramework.Controls.MetroTextBox();
            this.bindingSourceMaterial = new System.Windows.Forms.BindingSource(this.components);
            this.lblMaterialCode = new MetroFramework.Controls.MetroTextBox();
            this.lblMaterialID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearMaterial
            // 
            this.btnClearMaterial.Location = new System.Drawing.Point(174, 261);
            this.btnClearMaterial.Name = "btnClearMaterial";
            this.btnClearMaterial.Size = new System.Drawing.Size(98, 36);
            this.btnClearMaterial.TabIndex = 21;
            this.btnClearMaterial.Text = "CLEAR";
            this.btnClearMaterial.UseSelectable = true;
            this.btnClearMaterial.Click += new System.EventHandler(this.btnClearMaterial_Click);
            // 
            // btnSaveMaterial
            // 
            this.btnSaveMaterial.Location = new System.Drawing.Point(363, 261);
            this.btnSaveMaterial.Name = "btnSaveMaterial";
            this.btnSaveMaterial.Size = new System.Drawing.Size(94, 36);
            this.btnSaveMaterial.TabIndex = 3;
            this.btnSaveMaterial.Text = "SAVE";
            this.btnSaveMaterial.UseSelectable = true;
            this.btnSaveMaterial.Click += new System.EventHandler(this.btnSaveMaterial_Click);
            // 
            // lblMaterialName
            // 
            // 
            // 
            // 
            this.lblMaterialName.CustomButton.Image = null;
            this.lblMaterialName.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.lblMaterialName.CustomButton.Name = "";
            this.lblMaterialName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblMaterialName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblMaterialName.CustomButton.TabIndex = 1;
            this.lblMaterialName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblMaterialName.CustomButton.UseSelectable = true;
            this.lblMaterialName.CustomButton.Visible = false;
            this.lblMaterialName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMaterial, "MaterialName", true));
            this.lblMaterialName.Lines = new string[0];
            this.lblMaterialName.Location = new System.Drawing.Point(302, 202);
            this.lblMaterialName.MaxLength = 32767;
            this.lblMaterialName.Name = "lblMaterialName";
            this.lblMaterialName.PasswordChar = '\0';
            this.lblMaterialName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblMaterialName.SelectedText = "";
            this.lblMaterialName.SelectionLength = 0;
            this.lblMaterialName.SelectionStart = 0;
            this.lblMaterialName.ShortcutsEnabled = true;
            this.lblMaterialName.Size = new System.Drawing.Size(155, 23);
            this.lblMaterialName.TabIndex = 2;
            this.lblMaterialName.UseSelectable = true;
            this.lblMaterialName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblMaterialName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bindingSourceMaterial
            // 
            this.bindingSourceMaterial.DataSource = typeof(Project.Material);
            // 
            // lblMaterialCode
            // 
            // 
            // 
            // 
            this.lblMaterialCode.CustomButton.Image = null;
            this.lblMaterialCode.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.lblMaterialCode.CustomButton.Name = "";
            this.lblMaterialCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblMaterialCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblMaterialCode.CustomButton.TabIndex = 1;
            this.lblMaterialCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblMaterialCode.CustomButton.UseSelectable = true;
            this.lblMaterialCode.CustomButton.Visible = false;
            this.lblMaterialCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMaterial, "MaterialCode", true));
            this.lblMaterialCode.Lines = new string[0];
            this.lblMaterialCode.Location = new System.Drawing.Point(302, 152);
            this.lblMaterialCode.MaxLength = 32767;
            this.lblMaterialCode.Name = "lblMaterialCode";
            this.lblMaterialCode.PasswordChar = '\0';
            this.lblMaterialCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblMaterialCode.SelectedText = "";
            this.lblMaterialCode.SelectionLength = 0;
            this.lblMaterialCode.SelectionStart = 0;
            this.lblMaterialCode.ShortcutsEnabled = true;
            this.lblMaterialCode.Size = new System.Drawing.Size(155, 23);
            this.lblMaterialCode.TabIndex = 1;
            this.lblMaterialCode.UseSelectable = true;
            this.lblMaterialCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblMaterialCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMaterialID
            // 
            // 
            // 
            // 
            this.lblMaterialID.CustomButton.Image = null;
            this.lblMaterialID.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.lblMaterialID.CustomButton.Name = "";
            this.lblMaterialID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblMaterialID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblMaterialID.CustomButton.TabIndex = 1;
            this.lblMaterialID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblMaterialID.CustomButton.UseSelectable = true;
            this.lblMaterialID.CustomButton.Visible = false;
            this.lblMaterialID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMaterial, "MaterialID", true));
            this.lblMaterialID.Lines = new string[0];
            this.lblMaterialID.Location = new System.Drawing.Point(302, 106);
            this.lblMaterialID.MaxLength = 32767;
            this.lblMaterialID.Name = "lblMaterialID";
            this.lblMaterialID.PasswordChar = '\0';
            this.lblMaterialID.ReadOnly = true;
            this.lblMaterialID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblMaterialID.SelectedText = "";
            this.lblMaterialID.SelectionLength = 0;
            this.lblMaterialID.SelectionStart = 0;
            this.lblMaterialID.ShortcutsEnabled = true;
            this.lblMaterialID.Size = new System.Drawing.Size(155, 23);
            this.lblMaterialID.TabIndex = 1;
            this.lblMaterialID.UseSelectable = true;
            this.lblMaterialID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblMaterialID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(174, 152);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Material Code";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(174, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Material ID";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(174, 202);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Material Name";
            // 
            // AddEditMaterial
            // 
            this.ClientSize = new System.Drawing.Size(667, 361);
            this.Controls.Add(this.btnClearMaterial);
            this.Controls.Add(this.btnSaveMaterial);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblMaterialName);
            this.Controls.Add(this.lblMaterialCode);
            this.Controls.Add(this.lblMaterialID);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddEditMaterial";
            this.Text = "Add and Edit Material";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        indomodaEntities db;

        public AddEditMaterial(Material obj)
        {
            InitializeComponent();
            bindingSourceMaterial.DataSource = obj;
        }

        public Material MaterialInfo { get { return bindingSourceMaterial.Current as Material; } }

        private void AddEditMaterial_Load(object sender, EventArgs e)
        {
            db = new indomodaEntities();
        }

        private void btnClearMaterial_Click(object sender, EventArgs e)
        {
            lblMaterialCode.Clear();
            lblMaterialName.Clear();
            lblMaterialCode.Focus();
        }

        private void btnSaveMaterial_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lblMaterialCode.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter material code!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblMaterialCode.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lblMaterialName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter material name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblMaterialName.Focus();
                return;
            }

            bindingSourceMaterial.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
