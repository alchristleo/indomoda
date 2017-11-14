using System;

namespace Project
{
    partial class AddEditEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblEmployeeCode = new MetroFramework.Controls.MetroTextBox();
            this.bindingSourceEmployee = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.lblEmployeePosition = new MetroFramework.Controls.MetroTextBox();
            this.lblEmployeeEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblEmployeePhone = new MetroFramework.Controls.MetroTextBox();
            this.lblEmployeeName = new MetroFramework.Controls.MetroTextBox();
            this.lblEmployeeID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmployee)).BeginInit();
            this.SuspendLayout();
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
            this.lblEmployeeCode.Location = new System.Drawing.Point(163, 163);
            this.lblEmployeeCode.MaxLength = 32767;
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.PasswordChar = '\0';
            this.lblEmployeeCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblEmployeeCode.SelectedText = "";
            this.lblEmployeeCode.SelectionLength = 0;
            this.lblEmployeeCode.SelectionStart = 0;
            this.lblEmployeeCode.ShortcutsEnabled = true;
            this.lblEmployeeCode.Size = new System.Drawing.Size(155, 23);
            this.lblEmployeeCode.TabIndex = 17;
            this.lblEmployeeCode.UseSelectable = true;
            this.lblEmployeeCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblEmployeeCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bindingSourceEmployee
            // 
            this.bindingSourceEmployee.DataSource = typeof(Project.Employee);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(54, 163);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(103, 19);
            this.metroLabel6.TabIndex = 27;
            this.metroLabel6.Text = "Employee Code";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(188, 277);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 36);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(369, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 36);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.lblEmployeePosition.Location = new System.Drawing.Point(446, 219);
            this.lblEmployeePosition.MaxLength = 32767;
            this.lblEmployeePosition.Name = "lblEmployeePosition";
            this.lblEmployeePosition.PasswordChar = '\0';
            this.lblEmployeePosition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblEmployeePosition.SelectedText = "";
            this.lblEmployeePosition.SelectionLength = 0;
            this.lblEmployeePosition.SelectionStart = 0;
            this.lblEmployeePosition.ShortcutsEnabled = true;
            this.lblEmployeePosition.Size = new System.Drawing.Size(172, 23);
            this.lblEmployeePosition.TabIndex = 23;
            this.lblEmployeePosition.UseSelectable = true;
            this.lblEmployeePosition.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblEmployeePosition.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.lblEmployeeEmail.Location = new System.Drawing.Point(446, 163);
            this.lblEmployeeEmail.MaxLength = 32767;
            this.lblEmployeeEmail.Name = "lblEmployeeEmail";
            this.lblEmployeeEmail.PasswordChar = '\0';
            this.lblEmployeeEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblEmployeeEmail.SelectedText = "";
            this.lblEmployeeEmail.SelectionLength = 0;
            this.lblEmployeeEmail.SelectionStart = 0;
            this.lblEmployeeEmail.ShortcutsEnabled = true;
            this.lblEmployeeEmail.Size = new System.Drawing.Size(172, 23);
            this.lblEmployeeEmail.TabIndex = 19;
            this.lblEmployeeEmail.UseSelectable = true;
            this.lblEmployeeEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblEmployeeEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.lblEmployeePhone.Location = new System.Drawing.Point(163, 219);
            this.lblEmployeePhone.MaxLength = 32767;
            this.lblEmployeePhone.Name = "lblEmployeePhone";
            this.lblEmployeePhone.PasswordChar = '\0';
            this.lblEmployeePhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblEmployeePhone.SelectedText = "";
            this.lblEmployeePhone.SelectionLength = 0;
            this.lblEmployeePhone.SelectionStart = 0;
            this.lblEmployeePhone.ShortcutsEnabled = true;
            this.lblEmployeePhone.Size = new System.Drawing.Size(155, 23);
            this.lblEmployeePhone.TabIndex = 21;
            this.lblEmployeePhone.UseSelectable = true;
            this.lblEmployeePhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblEmployeePhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.lblEmployeeName.Location = new System.Drawing.Point(446, 113);
            this.lblEmployeeName.MaxLength = 32767;
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.PasswordChar = '\0';
            this.lblEmployeeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblEmployeeName.SelectedText = "";
            this.lblEmployeeName.SelectionLength = 0;
            this.lblEmployeeName.SelectionStart = 0;
            this.lblEmployeeName.ShortcutsEnabled = true;
            this.lblEmployeeName.Size = new System.Drawing.Size(172, 23);
            this.lblEmployeeName.TabIndex = 15;
            this.lblEmployeeName.UseSelectable = true;
            this.lblEmployeeName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblEmployeeName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.lblEmployeeID.Location = new System.Drawing.Point(163, 113);
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
            this.lblEmployeeID.TabIndex = 24;
            this.lblEmployeeID.UseSelectable = true;
            this.lblEmployeeID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblEmployeeID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(54, 219);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Phone";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(369, 219);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Position";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(369, 163);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Email";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(369, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(54, 113);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Employee ID";
            // 
            // AddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 375);
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
            this.Name = "AddEditEmployee";
            this.Text = "Add and Edit Employee";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox lblEmployeeCode;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox lblEmployeePosition;
        private MetroFramework.Controls.MetroTextBox lblEmployeeEmail;
        private MetroFramework.Controls.MetroTextBox lblEmployeePhone;
        private MetroFramework.Controls.MetroTextBox lblEmployeeName;
        private MetroFramework.Controls.MetroTextBox lblEmployeeID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.BindingSource bindingSourceEmployee;
        private EventHandler btnClear_Click;
    }
}