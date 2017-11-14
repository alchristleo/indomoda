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
    public partial class AddEditWarna : MetroFramework.Forms.MetroForm
    {
        private MetroFramework.Controls.MetroTextBox lblColorName;
        private MetroFramework.Controls.MetroTextBox lblColorCode;
        private MetroFramework.Controls.MetroTextBox lblColorID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnClearColor;
        private MetroFramework.Controls.MetroButton btnSaveColor;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.ComponentModel.IContainer components;
        private BindingSource bindingSourceColor;
        private MetroFramework.Controls.MetroLabel metroLabel3;

        public AddEditWarna()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblColorName = new MetroFramework.Controls.MetroTextBox();
            this.bindingSourceColor = new System.Windows.Forms.BindingSource(this.components);
            this.lblColorCode = new MetroFramework.Controls.MetroTextBox();
            this.lblColorID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnClearColor = new MetroFramework.Controls.MetroButton();
            this.btnSaveColor = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceColor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColorName
            // 
            // 
            // 
            // 
            this.lblColorName.CustomButton.Image = null;
            this.lblColorName.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.lblColorName.CustomButton.Name = "";
            this.lblColorName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblColorName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblColorName.CustomButton.TabIndex = 1;
            this.lblColorName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblColorName.CustomButton.UseSelectable = true;
            this.lblColorName.CustomButton.Visible = false;
            this.lblColorName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceColor, "ColorName", true));
            this.lblColorName.Lines = new string[0];
            this.lblColorName.Location = new System.Drawing.Point(277, 194);
            this.lblColorName.MaxLength = 32767;
            this.lblColorName.Name = "lblColorName";
            this.lblColorName.PasswordChar = '\0';
            this.lblColorName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblColorName.SelectedText = "";
            this.lblColorName.SelectionLength = 0;
            this.lblColorName.SelectionStart = 0;
            this.lblColorName.ShortcutsEnabled = true;
            this.lblColorName.Size = new System.Drawing.Size(155, 23);
            this.lblColorName.TabIndex = 2;
            this.lblColorName.UseSelectable = true;
            this.lblColorName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblColorName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bindingSourceColor
            // 
            this.bindingSourceColor.DataSource = typeof(Project.Color);
            // 
            // lblColorCode
            // 
            // 
            // 
            // 
            this.lblColorCode.CustomButton.Image = null;
            this.lblColorCode.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.lblColorCode.CustomButton.Name = "";
            this.lblColorCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblColorCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblColorCode.CustomButton.TabIndex = 1;
            this.lblColorCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblColorCode.CustomButton.UseSelectable = true;
            this.lblColorCode.CustomButton.Visible = false;
            this.lblColorCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceColor, "ColorCode", true));
            this.lblColorCode.Lines = new string[0];
            this.lblColorCode.Location = new System.Drawing.Point(295, 144);
            this.lblColorCode.MaxLength = 32767;
            this.lblColorCode.Name = "lblColorCode";
            this.lblColorCode.PasswordChar = '\0';
            this.lblColorCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblColorCode.SelectedText = "";
            this.lblColorCode.SelectionLength = 0;
            this.lblColorCode.SelectionStart = 0;
            this.lblColorCode.ShortcutsEnabled = true;
            this.lblColorCode.Size = new System.Drawing.Size(137, 23);
            this.lblColorCode.TabIndex = 1;
            this.lblColorCode.UseSelectable = true;
            this.lblColorCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblColorCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblColorID
            // 
            // 
            // 
            // 
            this.lblColorID.CustomButton.Image = null;
            this.lblColorID.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.lblColorID.CustomButton.Name = "";
            this.lblColorID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblColorID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblColorID.CustomButton.TabIndex = 1;
            this.lblColorID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblColorID.CustomButton.UseSelectable = true;
            this.lblColorID.CustomButton.Visible = false;
            this.lblColorID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceColor, "ColorID", true));
            this.lblColorID.Lines = new string[0];
            this.lblColorID.Location = new System.Drawing.Point(277, 98);
            this.lblColorID.MaxLength = 32767;
            this.lblColorID.Name = "lblColorID";
            this.lblColorID.PasswordChar = '\0';
            this.lblColorID.ReadOnly = true;
            this.lblColorID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblColorID.SelectedText = "";
            this.lblColorID.SelectionLength = 0;
            this.lblColorID.SelectionStart = 0;
            this.lblColorID.ShortcutsEnabled = true;
            this.lblColorID.Size = new System.Drawing.Size(155, 23);
            this.lblColorID.TabIndex = 10;
            this.lblColorID.UseSelectable = true;
            this.lblColorID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblColorID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(149, 144);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Color Code";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(149, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Color ID";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(149, 194);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Color Name";
            // 
            // btnClearColor
            // 
            this.btnClearColor.Location = new System.Drawing.Point(149, 253);
            this.btnClearColor.Name = "btnClearColor";
            this.btnClearColor.Size = new System.Drawing.Size(98, 36);
            this.btnClearColor.TabIndex = 13;
            this.btnClearColor.Text = "CLEAR";
            this.btnClearColor.UseSelectable = true;
            this.btnClearColor.Click += new System.EventHandler(this.btnClearColor_Click);
            // 
            // btnSaveColor
            // 
            this.btnSaveColor.Location = new System.Drawing.Point(338, 253);
            this.btnSaveColor.Name = "btnSaveColor";
            this.btnSaveColor.Size = new System.Drawing.Size(94, 36);
            this.btnSaveColor.TabIndex = 3;
            this.btnSaveColor.Text = "SAVE";
            this.btnSaveColor.UseSelectable = true;
            this.btnSaveColor.Click += new System.EventHandler(this.btnSaveColor_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(277, 144);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(17, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "#";
            // 
            // AddEditWarna
            // 
            this.ClientSize = new System.Drawing.Size(608, 337);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnClearColor);
            this.Controls.Add(this.btnSaveColor);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblColorName);
            this.Controls.Add(this.lblColorCode);
            this.Controls.Add(this.lblColorID);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddEditWarna";
            this.Text = "Add and Edit Color";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        indomodaEntities db;

        public AddEditWarna(Color obj)
        {
            InitializeComponent();
            bindingSourceColor.DataSource = obj;
        }

        public Color ColorInfo { get { return bindingSourceColor.Current as Color; } }

        private void AddEditWarna_Load(object sender, EventArgs e)
        {
            db = new indomodaEntities();
        }

        private void btnClearColor_Click(object sender, EventArgs e)
        {
            lblColorCode.Clear();
            lblColorName.Clear();
            lblColorCode.Focus();
        }

        private void btnSaveColor_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lblColorCode.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter color code!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblColorCode.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lblColorName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter color name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblColorName.Focus();
                return;
            }

            bindingSourceColor.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
