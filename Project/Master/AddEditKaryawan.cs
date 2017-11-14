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
    public partial class AddEditKaryawan : MetroFramework.Forms.MetroForm
    {
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox lblEmployeeName;
        private MetroFramework.Controls.MetroTextBox lblEmployeePhone;
        private MetroFramework.Controls.MetroTextBox lblEmployeeEmail;
        private MetroFramework.Controls.MetroTextBox lblEmployeePosition;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnClear;
        private IContainer components;
        private MetroFramework.Controls.MetroTextBox lblEmployeeCode;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private BindingSource bindingSourceEmployee;
        private MetroFramework.Controls.MetroTextBox lblEmployeeID;

        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblEmployeeID = new MetroFramework.Controls.MetroTextBox();
            this.bindingSourceEmployee = new System.Windows.Forms.BindingSource(this.components);
            this.lblEmployeeName = new MetroFramework.Controls.MetroTextBox();
            this.lblEmployeePhone = new MetroFramework.Controls.MetroTextBox();
            this.lblEmployeeEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblEmployeePosition = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.lblEmployeeCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Employee ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(346, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(346, 140);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Email";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(346, 196);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Position";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(31, 196);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Phone";
            // 
            // lblEmployeeID
            // 
            // 
            // 
            // 
            this.lblEmployeeID.CustomButton.Image = null;
            this.lblEmployeeID.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.lblEmployeeID.CustomButton.Name = "";
            this.lblEmployeeID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblEmployeeID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblEmployeeID.CustomButton.TabIndex = 1;
            this.lblEmployeeID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblEmployeeID.CustomButton.UseSelectable = true;
            this.lblEmployeeID.CustomButton.Visible = false;
            this.lblEmployeeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmployee, "EmployeeID", true));
            this.lblEmployeeID.Lines = new string[0];
            this.lblEmployeeID.Location = new System.Drawing.Point(140, 90);
            this.lblEmployeeID.MaxLength = 32767;
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.PasswordChar = '\0';
            this.lblEmployeeID.ReadOnly = true;
            this.lblEmployeeID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblEmployeeID.SelectedText = "";
            this.lblEmployeeID.SelectionLength = 0;
            this.lblEmployeeID.SelectionStart = 0;
            this.lblEmployeeID.ShortcutsEnabled = true;
            this.lblEmployeeID.Size = new System.Drawing.Size(155, 23);
            this.lblEmployeeID.TabIndex = 5;
            this.lblEmployeeID.UseSelectable = true;
            this.lblEmployeeID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblEmployeeID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bindingSourceEmployee
            // 
            this.bindingSourceEmployee.DataSource = typeof(Project.Employee);
            // 
            // lblEmployeeName
            // 
            // 
            // 
            // 
            this.lblEmployeeName.CustomButton.Image = null;
            this.lblEmployeeName.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.lblEmployeeName.CustomButton.Name = "";
            this.lblEmployeeName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblEmployeeName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblEmployeeName.CustomButton.TabIndex = 1;
            this.lblEmployeeName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblEmployeeName.CustomButton.UseSelectable = true;
            this.lblEmployeeName.CustomButton.Visible = false;
            this.lblEmployeeName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmployee, "EmployeeName", true));
            this.lblEmployeeName.Lines = new string[0];
            this.lblEmployeeName.Location = new System.Drawing.Point(423, 90);
            this.lblEmployeeName.MaxLength = 32767;
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.PasswordChar = '\0';
            this.lblEmployeeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblEmployeeName.SelectedText = "";
            this.lblEmployeeName.SelectionLength = 0;
            this.lblEmployeeName.SelectionStart = 0;
            this.lblEmployeeName.ShortcutsEnabled = true;
            this.lblEmployeeName.Size = new System.Drawing.Size(172, 23);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.UseSelectable = true;
            this.lblEmployeeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblEmployeeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEmployeePhone
            // 
            // 
            // 
            // 
            this.lblEmployeePhone.CustomButton.Image = null;
            this.lblEmployeePhone.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.lblEmployeePhone.CustomButton.Name = "";
            this.lblEmployeePhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblEmployeePhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblEmployeePhone.CustomButton.TabIndex = 1;
            this.lblEmployeePhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblEmployeePhone.CustomButton.UseSelectable = true;
            this.lblEmployeePhone.CustomButton.Visible = false;
            this.lblEmployeePhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmployee, "EmployeePhone", true));
            this.lblEmployeePhone.Lines = new string[0];
            this.lblEmployeePhone.Location = new System.Drawing.Point(140, 196);
            this.lblEmployeePhone.MaxLength = 32767;
            this.lblEmployeePhone.Name = "lblEmployeePhone";
            this.lblEmployeePhone.PasswordChar = '\0';
            this.lblEmployeePhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblEmployeePhone.SelectedText = "";
            this.lblEmployeePhone.SelectionLength = 0;
            this.lblEmployeePhone.SelectionStart = 0;
            this.lblEmployeePhone.ShortcutsEnabled = true;
            this.lblEmployeePhone.Size = new System.Drawing.Size(155, 23);
            this.lblEmployeePhone.TabIndex = 4;
            this.lblEmployeePhone.UseSelectable = true;
            this.lblEmployeePhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblEmployeePhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEmployeeEmail
            // 
            // 
            // 
            // 
            this.lblEmployeeEmail.CustomButton.Image = null;
            this.lblEmployeeEmail.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.lblEmployeeEmail.CustomButton.Name = "";
            this.lblEmployeeEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblEmployeeEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblEmployeeEmail.CustomButton.TabIndex = 1;
            this.lblEmployeeEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblEmployeeEmail.CustomButton.UseSelectable = true;
            this.lblEmployeeEmail.CustomButton.Visible = false;
            this.lblEmployeeEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmployee, "EmployeeEmail", true));
            this.lblEmployeeEmail.Lines = new string[0];
            this.lblEmployeeEmail.Location = new System.Drawing.Point(423, 140);
            this.lblEmployeeEmail.MaxLength = 32767;
            this.lblEmployeeEmail.Name = "lblEmployeeEmail";
            this.lblEmployeeEmail.PasswordChar = '\0';
            this.lblEmployeeEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblEmployeeEmail.SelectedText = "";
            this.lblEmployeeEmail.SelectionLength = 0;
            this.lblEmployeeEmail.SelectionStart = 0;
            this.lblEmployeeEmail.ShortcutsEnabled = true;
            this.lblEmployeeEmail.Size = new System.Drawing.Size(172, 23);
            this.lblEmployeeEmail.TabIndex = 3;
            this.lblEmployeeEmail.UseSelectable = true;
            this.lblEmployeeEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblEmployeeEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEmployeePosition
            // 
            // 
            // 
            // 
            this.lblEmployeePosition.CustomButton.Image = null;
            this.lblEmployeePosition.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.lblEmployeePosition.CustomButton.Name = "";
            this.lblEmployeePosition.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblEmployeePosition.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblEmployeePosition.CustomButton.TabIndex = 1;
            this.lblEmployeePosition.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblEmployeePosition.CustomButton.UseSelectable = true;
            this.lblEmployeePosition.CustomButton.Visible = false;
            this.lblEmployeePosition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmployee, "EmployeePosition", true));
            this.lblEmployeePosition.Lines = new string[0];
            this.lblEmployeePosition.Location = new System.Drawing.Point(423, 196);
            this.lblEmployeePosition.MaxLength = 32767;
            this.lblEmployeePosition.Name = "lblEmployeePosition";
            this.lblEmployeePosition.PasswordChar = '\0';
            this.lblEmployeePosition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblEmployeePosition.SelectedText = "";
            this.lblEmployeePosition.SelectionLength = 0;
            this.lblEmployeePosition.SelectionStart = 0;
            this.lblEmployeePosition.ShortcutsEnabled = true;
            this.lblEmployeePosition.Size = new System.Drawing.Size(172, 23);
            this.lblEmployeePosition.TabIndex = 5;
            this.lblEmployeePosition.UseSelectable = true;
            this.lblEmployeePosition.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblEmployeePosition.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(346, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(165, 254);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 36);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblEmployeeCode
            // 
            // 
            // 
            // 
            this.lblEmployeeCode.CustomButton.Image = null;
            this.lblEmployeeCode.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.lblEmployeeCode.CustomButton.Name = "";
            this.lblEmployeeCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblEmployeeCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblEmployeeCode.CustomButton.TabIndex = 1;
            this.lblEmployeeCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblEmployeeCode.CustomButton.UseSelectable = true;
            this.lblEmployeeCode.CustomButton.Visible = false;
            this.lblEmployeeCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEmployee, "EmployeeCode", true));
            this.lblEmployeeCode.Lines = new string[0];
            this.lblEmployeeCode.Location = new System.Drawing.Point(140, 140);
            this.lblEmployeeCode.MaxLength = 32767;
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.PasswordChar = '\0';
            this.lblEmployeeCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblEmployeeCode.SelectedText = "";
            this.lblEmployeeCode.SelectionLength = 0;
            this.lblEmployeeCode.SelectionStart = 0;
            this.lblEmployeeCode.ShortcutsEnabled = true;
            this.lblEmployeeCode.Size = new System.Drawing.Size(155, 23);
            this.lblEmployeeCode.TabIndex = 2;
            this.lblEmployeeCode.UseSelectable = true;
            this.lblEmployeeCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblEmployeeCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(31, 140);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(103, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Employee Code";
            // 
            // AddEditKaryawan
            // 
            this.ClientSize = new System.Drawing.Size(644, 336);
            this.Controls.Add(this.lblEmployeeCode);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEmployeePosition);
            this.Controls.Add(this.lblEmployeeEmail);
            this.Controls.Add(this.lblEmployeePhone);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "AddEditKaryawan";
            this.Text = "Add and Edit Employee";
            this.Load += new System.EventHandler(this.AddEditKaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        indomodaEntities db;

        public AddEditKaryawan(Employee obj)
        {
            InitializeComponent();
            bindingSourceEmployee.DataSource = obj;
        }

        public Employee EmployeeInfo { get { return bindingSourceEmployee.Current as Employee; } }

        private void AddEditKaryawan_Load(object sender, EventArgs e)
        {
            db = new indomodaEntities();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblEmployeeName.Clear();
            lblEmployeeCode.Clear();
            lblEmployeeEmail.Clear();
            lblEmployeePhone.Clear();
            lblEmployeePosition.Clear();
            lblEmployeeName.Focus();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isEmail = Regex.IsMatch(lblEmployeeEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (String.IsNullOrEmpty(lblEmployeeName.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter employee name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEmployeeName.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lblEmployeeCode.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter employee code!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEmployeeCode.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lblEmployeeEmail.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter employee email!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEmployeeEmail.Focus();
                return;
            }
            else if (!isEmail)
            {
                MetroFramework.MetroMessageBox.Show(this, "Wrong email format! Ex: budi@gmail.com", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEmployeeEmail.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lblEmployeePhone.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter employee phone!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEmployeePhone.Focus();
                return;
            }
            else if (!IsDigitsOnly(lblEmployeePhone.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Employee phone must be numeric!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEmployeePhone.Clear();
                lblEmployeePhone.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lblEmployeePosition.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter employee position!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblEmployeePosition.Focus();
                return;
            }
            
                bindingSourceEmployee.EndEdit();
                DialogResult = DialogResult.OK;
            
        }
    }
}
