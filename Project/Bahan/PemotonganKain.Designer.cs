﻿namespace Project
{
    partial class PemotonganKain
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.txtNoPemotonganKain = new MetroFramework.Controls.MetroTextBox();
            this.cboFakturPenerimaanKain = new MetroFramework.Controls.MetroComboBox();
            this.txtSupplierName = new MetroFramework.Controls.MetroTextBox();
            this.cboPICCode = new MetroFramework.Controls.MetroComboBox();
            this.txtPICName = new MetroFramework.Controls.MetroTextBox();
            this.btnSavePemotonganKain = new MetroFramework.Controls.MetroButton();
            this.btnExitPemotonganKain = new MetroFramework.Controls.MetroButton();
            this.txtSupplierCode = new MetroFramework.Controls.MetroTextBox();
            this.detailFakturBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailFakturBindingSourceCbo = new System.Windows.Forms.BindingSource(this.components);
            this.idFakturDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noFakturDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pONumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailFakturBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailFakturBindingSourceCbo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFakturDataGridViewTextBoxColumn,
            this.noFakturDataGridViewTextBoxColumn,
            this.pONumberDataGridViewTextBoxColumn,
            this.datetimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.detailFakturBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(721, 241);
            this.dataGridView1.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(137, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "No. Pemotongan Kain";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(45, 119);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(170, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "No. Faktur Penerimaan Kain";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(485, 50);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(36, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Date";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(423, 228);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(69, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "PIC Name";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(45, 195);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(97, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Supplier Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(45, 160);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Supplier Code";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(45, 228);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(65, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "PIC Code";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(543, 40);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(211, 29);
            this.metroDateTime1.TabIndex = 15;
            // 
            // txtNoPemotonganKain
            // 
            // 
            // 
            // 
            this.txtNoPemotonganKain.CustomButton.Image = null;
            this.txtNoPemotonganKain.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtNoPemotonganKain.CustomButton.Name = "";
            this.txtNoPemotonganKain.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNoPemotonganKain.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNoPemotonganKain.CustomButton.TabIndex = 1;
            this.txtNoPemotonganKain.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNoPemotonganKain.CustomButton.UseSelectable = true;
            this.txtNoPemotonganKain.CustomButton.Visible = false;
            this.txtNoPemotonganKain.Lines = new string[0];
            this.txtNoPemotonganKain.Location = new System.Drawing.Point(228, 88);
            this.txtNoPemotonganKain.MaxLength = 32767;
            this.txtNoPemotonganKain.Name = "txtNoPemotonganKain";
            this.txtNoPemotonganKain.PasswordChar = '\0';
            this.txtNoPemotonganKain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNoPemotonganKain.SelectedText = "";
            this.txtNoPemotonganKain.SelectionLength = 0;
            this.txtNoPemotonganKain.SelectionStart = 0;
            this.txtNoPemotonganKain.ShortcutsEnabled = true;
            this.txtNoPemotonganKain.Size = new System.Drawing.Size(170, 23);
            this.txtNoPemotonganKain.TabIndex = 16;
            this.txtNoPemotonganKain.UseSelectable = true;
            this.txtNoPemotonganKain.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNoPemotonganKain.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboFakturPenerimaanKain
            // 
            this.cboFakturPenerimaanKain.DataSource = this.detailFakturBindingSourceCbo;
            this.cboFakturPenerimaanKain.DisplayMember = "NoFaktur";
            this.cboFakturPenerimaanKain.FormattingEnabled = true;
            this.cboFakturPenerimaanKain.ItemHeight = 23;
            this.cboFakturPenerimaanKain.Location = new System.Drawing.Point(228, 119);
            this.cboFakturPenerimaanKain.Name = "cboFakturPenerimaanKain";
            this.cboFakturPenerimaanKain.Size = new System.Drawing.Size(170, 29);
            this.cboFakturPenerimaanKain.TabIndex = 17;
            this.cboFakturPenerimaanKain.UseSelectable = true;
            this.cboFakturPenerimaanKain.ValueMember = "NoFaktur";
            this.cboFakturPenerimaanKain.SelectedIndexChanged += new System.EventHandler(this.cboFakturPenerimaanKain_SelectedIndexChanged);
            // 
            // txtSupplierName
            // 
            // 
            // 
            // 
            this.txtSupplierName.CustomButton.Image = null;
            this.txtSupplierName.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtSupplierName.CustomButton.Name = "";
            this.txtSupplierName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSupplierName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierName.CustomButton.TabIndex = 1;
            this.txtSupplierName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplierName.CustomButton.UseSelectable = true;
            this.txtSupplierName.CustomButton.Visible = false;
            this.txtSupplierName.Lines = new string[0];
            this.txtSupplierName.Location = new System.Drawing.Point(228, 195);
            this.txtSupplierName.MaxLength = 32767;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.PasswordChar = '\0';
            this.txtSupplierName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplierName.SelectedText = "";
            this.txtSupplierName.SelectionLength = 0;
            this.txtSupplierName.SelectionStart = 0;
            this.txtSupplierName.ShortcutsEnabled = true;
            this.txtSupplierName.Size = new System.Drawing.Size(170, 23);
            this.txtSupplierName.TabIndex = 19;
            this.txtSupplierName.UseSelectable = true;
            this.txtSupplierName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplierName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboPICCode
            // 
            this.cboPICCode.DataSource = this.employeeBindingSource;
            this.cboPICCode.DisplayMember = "EmployeeCode";
            this.cboPICCode.FormattingEnabled = true;
            this.cboPICCode.ItemHeight = 23;
            this.cboPICCode.Location = new System.Drawing.Point(228, 228);
            this.cboPICCode.Name = "cboPICCode";
            this.cboPICCode.Size = new System.Drawing.Size(170, 29);
            this.cboPICCode.TabIndex = 20;
            this.cboPICCode.UseSelectable = true;
            this.cboPICCode.ValueMember = "EmployeeID";
            // 
            // txtPICName
            // 
            // 
            // 
            // 
            this.txtPICName.CustomButton.Image = null;
            this.txtPICName.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtPICName.CustomButton.Name = "";
            this.txtPICName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPICName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPICName.CustomButton.TabIndex = 1;
            this.txtPICName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPICName.CustomButton.UseSelectable = true;
            this.txtPICName.CustomButton.Visible = false;
            this.txtPICName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeName", true));
            this.txtPICName.Lines = new string[0];
            this.txtPICName.Location = new System.Drawing.Point(498, 228);
            this.txtPICName.MaxLength = 32767;
            this.txtPICName.Name = "txtPICName";
            this.txtPICName.PasswordChar = '\0';
            this.txtPICName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPICName.SelectedText = "";
            this.txtPICName.SelectionLength = 0;
            this.txtPICName.SelectionStart = 0;
            this.txtPICName.ShortcutsEnabled = true;
            this.txtPICName.Size = new System.Drawing.Size(169, 23);
            this.txtPICName.TabIndex = 21;
            this.txtPICName.UseSelectable = true;
            this.txtPICName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPICName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSavePemotonganKain
            // 
            this.btnSavePemotonganKain.Location = new System.Drawing.Point(443, 568);
            this.btnSavePemotonganKain.Name = "btnSavePemotonganKain";
            this.btnSavePemotonganKain.Size = new System.Drawing.Size(110, 48);
            this.btnSavePemotonganKain.TabIndex = 37;
            this.btnSavePemotonganKain.Text = "SAVE";
            this.btnSavePemotonganKain.UseSelectable = true;
            // 
            // btnExitPemotonganKain
            // 
            this.btnExitPemotonganKain.Location = new System.Drawing.Point(275, 568);
            this.btnExitPemotonganKain.Name = "btnExitPemotonganKain";
            this.btnExitPemotonganKain.Size = new System.Drawing.Size(110, 48);
            this.btnExitPemotonganKain.TabIndex = 36;
            this.btnExitPemotonganKain.Text = "EXIT";
            this.btnExitPemotonganKain.UseSelectable = true;
            // 
            // txtSupplierCode
            // 
            // 
            // 
            // 
            this.txtSupplierCode.CustomButton.Image = null;
            this.txtSupplierCode.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtSupplierCode.CustomButton.Name = "";
            this.txtSupplierCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSupplierCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierCode.CustomButton.TabIndex = 1;
            this.txtSupplierCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplierCode.CustomButton.UseSelectable = true;
            this.txtSupplierCode.CustomButton.Visible = false;
            this.txtSupplierCode.Lines = new string[0];
            this.txtSupplierCode.Location = new System.Drawing.Point(228, 160);
            this.txtSupplierCode.MaxLength = 32767;
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.PasswordChar = '\0';
            this.txtSupplierCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplierCode.SelectedText = "";
            this.txtSupplierCode.SelectionLength = 0;
            this.txtSupplierCode.SelectionStart = 0;
            this.txtSupplierCode.ShortcutsEnabled = true;
            this.txtSupplierCode.Size = new System.Drawing.Size(170, 23);
            this.txtSupplierCode.TabIndex = 38;
            this.txtSupplierCode.UseSelectable = true;
            this.txtSupplierCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplierCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // detailFakturBindingSource
            // 
            this.detailFakturBindingSource.DataSource = typeof(Project.DetailFaktur);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Project.Employee);
            // 
            // detailFakturBindingSourceCbo
            // 
            this.detailFakturBindingSourceCbo.DataSource = typeof(Project.DetailFaktur);
            // 
            // idFakturDataGridViewTextBoxColumn
            // 
            this.idFakturDataGridViewTextBoxColumn.DataPropertyName = "idFaktur";
            this.idFakturDataGridViewTextBoxColumn.HeaderText = "No";
            this.idFakturDataGridViewTextBoxColumn.Name = "idFakturDataGridViewTextBoxColumn";
            this.idFakturDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFakturDataGridViewTextBoxColumn.Width = 40;
            // 
            // noFakturDataGridViewTextBoxColumn
            // 
            this.noFakturDataGridViewTextBoxColumn.DataPropertyName = "NoFaktur";
            this.noFakturDataGridViewTextBoxColumn.HeaderText = "No. Faktur";
            this.noFakturDataGridViewTextBoxColumn.Name = "noFakturDataGridViewTextBoxColumn";
            this.noFakturDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pONumberDataGridViewTextBoxColumn
            // 
            this.pONumberDataGridViewTextBoxColumn.DataPropertyName = "PONumber";
            this.pONumberDataGridViewTextBoxColumn.HeaderText = "No. PO";
            this.pONumberDataGridViewTextBoxColumn.Name = "pONumberDataGridViewTextBoxColumn";
            this.pONumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "Date_time";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            this.datetimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PemotonganKain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 665);
            this.Controls.Add(this.txtSupplierCode);
            this.Controls.Add(this.btnSavePemotonganKain);
            this.Controls.Add(this.btnExitPemotonganKain);
            this.Controls.Add(this.txtPICName);
            this.Controls.Add(this.cboPICCode);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.cboFakturPenerimaanKain);
            this.Controls.Add(this.txtNoPemotonganKain);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PemotonganKain";
            this.Text = "Pemotongan Kain";
            this.Load += new System.EventHandler(this.PemotonganKain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailFakturBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailFakturBindingSourceCbo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTextBox txtNoPemotonganKain;
        private MetroFramework.Controls.MetroComboBox cboFakturPenerimaanKain;
        private MetroFramework.Controls.MetroTextBox txtSupplierName;
        private MetroFramework.Controls.MetroComboBox cboPICCode;
        private MetroFramework.Controls.MetroTextBox txtPICName;
        private MetroFramework.Controls.MetroButton btnSavePemotonganKain;
        private MetroFramework.Controls.MetroButton btnExitPemotonganKain;
        private MetroFramework.Controls.MetroTextBox txtSupplierCode;
        private System.Windows.Forms.BindingSource detailFakturBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource detailFakturBindingSourceCbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFakturDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noFakturDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pONumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
    }
}