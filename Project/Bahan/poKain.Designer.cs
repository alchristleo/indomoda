﻿using System.Globalization;

namespace Project
{
    partial class poKain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(poKain));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblSupplierName = new MetroFramework.Controls.MetroTextBox();
            this.indomodaSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblPONumber = new MetroFramework.Controls.MetroTextBox();
            this.bindingSourcePreOrderKain = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblSupplierAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblGrandTotal = new MetroFramework.Controls.MetroTextBox();
            this.btnExitPoKain = new MetroFramework.Controls.MetroButton();
            this.btnSavePoKain = new MetroFramework.Controls.MetroButton();
            this.btnDeletePoKain = new MetroFramework.Controls.MetroTile();
            this.btnEditPoKain = new MetroFramework.Controls.MetroTile();
            this.btnAddPoKain = new MetroFramework.Controls.MetroTile();
            this.cboSupplierCode = new MetroFramework.Controls.MetroComboBox();
            this.lblGrandTotalDB = new MetroFramework.Controls.MetroTextBox();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pONumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colorIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailPOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indomodaSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePreOrderKain)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NO,
            this.pONumberDataGridViewTextBoxColumn,
            this.materialIDDataGridViewComboBoxColumn,
            this.colorIDDataGridViewComboBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.detailPOIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.detailPOBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.Location = new System.Drawing.Point(62, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(699, 200);
            this.dataGridView1.TabIndex = 9;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(Project.Material);
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(Project.Color);
            // 
            // detailPOBindingSource
            // 
            this.detailPOBindingSource.DataSource = typeof(Project.DetailPO);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CausesValidation = false;
            this.metroDateTime1.Location = new System.Drawing.Point(507, 34);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 14;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(455, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(466, 123);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Supplier Code";
            // 
            // lblSupplierName
            // 
            // 
            // 
            // 
            this.lblSupplierName.CustomButton.Image = null;
            this.lblSupplierName.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.lblSupplierName.CustomButton.Name = "";
            this.lblSupplierName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblSupplierName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSupplierName.CustomButton.TabIndex = 1;
            this.lblSupplierName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSupplierName.CustomButton.UseSelectable = true;
            this.lblSupplierName.CustomButton.Visible = false;
            this.lblSupplierName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.indomodaSupplierBindingSource, "SupplierCode", true));
            this.lblSupplierName.Lines = new string[0];
            this.lblSupplierName.Location = new System.Drawing.Point(575, 123);
            this.lblSupplierName.MaxLength = 32767;
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.PasswordChar = '\0';
            this.lblSupplierName.ReadOnly = true;
            this.lblSupplierName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblSupplierName.SelectedText = "";
            this.lblSupplierName.SelectionLength = 0;
            this.lblSupplierName.SelectionStart = 0;
            this.lblSupplierName.ShortcutsEnabled = true;
            this.lblSupplierName.Size = new System.Drawing.Size(183, 23);
            this.lblSupplierName.TabIndex = 3;
            this.lblSupplierName.UseSelectable = true;
            this.lblSupplierName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblSupplierName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // indomodaSupplierBindingSource
            // 
            this.indomodaSupplierBindingSource.DataSource = typeof(Project.IndomodaSupplier);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(62, 80);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "No. PO";
            // 
            // lblPONumber
            // 
            // 
            // 
            // 
            this.lblPONumber.CustomButton.Image = null;
            this.lblPONumber.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.lblPONumber.CustomButton.Name = "";
            this.lblPONumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblPONumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPONumber.CustomButton.TabIndex = 1;
            this.lblPONumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblPONumber.CustomButton.UseSelectable = true;
            this.lblPONumber.CustomButton.Visible = false;
            this.lblPONumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePreOrderKain, "PONumber", true));
            this.lblPONumber.Lines = new string[0];
            this.lblPONumber.Location = new System.Drawing.Point(182, 80);
            this.lblPONumber.MaxLength = 32767;
            this.lblPONumber.Name = "lblPONumber";
            this.lblPONumber.PasswordChar = '\0';
            this.lblPONumber.ReadOnly = true;
            this.lblPONumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblPONumber.SelectedText = "";
            this.lblPONumber.SelectionLength = 0;
            this.lblPONumber.SelectionStart = 0;
            this.lblPONumber.ShortcutsEnabled = true;
            this.lblPONumber.Size = new System.Drawing.Size(183, 23);
            this.lblPONumber.TabIndex = 1;
            this.lblPONumber.UseSelectable = true;
            this.lblPONumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblPONumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bindingSourcePreOrderKain
            // 
            this.bindingSourcePreOrderKain.DataSource = typeof(Project.PreOrderKain);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(62, 123);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 19);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Supplier Name";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(62, 161);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(108, 19);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Supplier Address";
            // 
            // lblSupplierAddress
            // 
            // 
            // 
            // 
            this.lblSupplierAddress.CustomButton.Image = null;
            this.lblSupplierAddress.CustomButton.Location = new System.Drawing.Point(158, 2);
            this.lblSupplierAddress.CustomButton.Name = "";
            this.lblSupplierAddress.CustomButton.Size = new System.Drawing.Size(85, 85);
            this.lblSupplierAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSupplierAddress.CustomButton.TabIndex = 1;
            this.lblSupplierAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSupplierAddress.CustomButton.UseSelectable = true;
            this.lblSupplierAddress.CustomButton.Visible = false;
            this.lblSupplierAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.indomodaSupplierBindingSource, "SupplierAddress", true));
            this.lblSupplierAddress.Lines = new string[0];
            this.lblSupplierAddress.Location = new System.Drawing.Point(182, 161);
            this.lblSupplierAddress.MaxLength = 32767;
            this.lblSupplierAddress.Multiline = true;
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.PasswordChar = '\0';
            this.lblSupplierAddress.ReadOnly = true;
            this.lblSupplierAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblSupplierAddress.SelectedText = "";
            this.lblSupplierAddress.SelectionLength = 0;
            this.lblSupplierAddress.SelectionStart = 0;
            this.lblSupplierAddress.ShortcutsEnabled = true;
            this.lblSupplierAddress.Size = new System.Drawing.Size(246, 90);
            this.lblSupplierAddress.TabIndex = 4;
            this.lblSupplierAddress.UseSelectable = true;
            this.lblSupplierAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblSupplierAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(412, 491);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 19);
            this.metroLabel6.TabIndex = 24;
            this.metroLabel6.Text = "Grand Total";
            // 
            // lblGrandTotal
            // 
            // 
            // 
            // 
            this.lblGrandTotal.CustomButton.Image = null;
            this.lblGrandTotal.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.lblGrandTotal.CustomButton.Name = "";
            this.lblGrandTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblGrandTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblGrandTotal.CustomButton.TabIndex = 1;
            this.lblGrandTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblGrandTotal.CustomButton.UseSelectable = true;
            this.lblGrandTotal.CustomButton.Visible = false;
            this.lblGrandTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePreOrderKain, "GrandTotal", true));
            this.lblGrandTotal.Lines = new string[0];
            this.lblGrandTotal.Location = new System.Drawing.Point(521, 491);
            this.lblGrandTotal.MaxLength = 32767;
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.PasswordChar = '\0';
            this.lblGrandTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblGrandTotal.SelectedText = "";
            this.lblGrandTotal.SelectionLength = 0;
            this.lblGrandTotal.SelectionStart = 0;
            this.lblGrandTotal.ShortcutsEnabled = true;
            this.lblGrandTotal.Size = new System.Drawing.Size(183, 23);
            this.lblGrandTotal.TabIndex = 8;
            this.lblGrandTotal.UseSelectable = true;
            this.lblGrandTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblGrandTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnExitPoKain
            // 
            this.btnExitPoKain.Location = new System.Drawing.Point(194, 590);
            this.btnExitPoKain.Name = "btnExitPoKain";
            this.btnExitPoKain.Size = new System.Drawing.Size(110, 48);
            this.btnExitPoKain.TabIndex = 10;
            this.btnExitPoKain.Text = "EXIT";
            this.btnExitPoKain.UseSelectable = true;
            this.btnExitPoKain.Click += new System.EventHandler(this.btnExitPoKain_Click);
            // 
            // btnSavePoKain
            // 
            this.btnSavePoKain.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSavePoKain.Location = new System.Drawing.Point(449, 590);
            this.btnSavePoKain.Name = "btnSavePoKain";
            this.btnSavePoKain.Size = new System.Drawing.Size(110, 48);
            this.btnSavePoKain.TabIndex = 9;
            this.btnSavePoKain.Text = "SAVE";
            this.btnSavePoKain.UseSelectable = true;
            this.btnSavePoKain.Click += new System.EventHandler(this.btnSavePoKain_Click);
            // 
            // btnDeletePoKain
            // 
            this.btnDeletePoKain.ActiveControl = null;
            this.btnDeletePoKain.Location = new System.Drawing.Point(266, 478);
            this.btnDeletePoKain.Name = "btnDeletePoKain";
            this.btnDeletePoKain.Size = new System.Drawing.Size(87, 67);
            this.btnDeletePoKain.TabIndex = 7;
            this.btnDeletePoKain.Text = "DELETE";
            this.btnDeletePoKain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletePoKain.TileImage = global::Project.Properties.Resources.btn_delete;
            this.btnDeletePoKain.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletePoKain.UseSelectable = true;
            this.btnDeletePoKain.UseTileImage = true;
            this.btnDeletePoKain.Click += new System.EventHandler(this.btnDeletePoKain_Click);
            // 
            // btnEditPoKain
            // 
            this.btnEditPoKain.ActiveControl = null;
            this.btnEditPoKain.Location = new System.Drawing.Point(164, 478);
            this.btnEditPoKain.Name = "btnEditPoKain";
            this.btnEditPoKain.Size = new System.Drawing.Size(87, 67);
            this.btnEditPoKain.TabIndex = 6;
            this.btnEditPoKain.Text = "EDIT";
            this.btnEditPoKain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditPoKain.TileImage = global::Project.Properties.Resources.btn_pencil;
            this.btnEditPoKain.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditPoKain.UseSelectable = true;
            this.btnEditPoKain.UseTileImage = true;
            this.btnEditPoKain.Click += new System.EventHandler(this.btnEditPoKain_Click);
            // 
            // btnAddPoKain
            // 
            this.btnAddPoKain.ActiveControl = null;
            this.btnAddPoKain.Location = new System.Drawing.Point(62, 478);
            this.btnAddPoKain.Name = "btnAddPoKain";
            this.btnAddPoKain.Size = new System.Drawing.Size(85, 67);
            this.btnAddPoKain.TabIndex = 5;
            this.btnAddPoKain.Text = "ADD";
            this.btnAddPoKain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddPoKain.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddPoKain.TileImage")));
            this.btnAddPoKain.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddPoKain.UseSelectable = true;
            this.btnAddPoKain.UseTileImage = true;
            this.btnAddPoKain.Click += new System.EventHandler(this.btnAddPoKain_Click);
            // 
            // cboSupplierCode
            // 
            this.cboSupplierCode.DataSource = this.indomodaSupplierBindingSource;
            this.cboSupplierCode.DisplayMember = "SupplierName";
            this.cboSupplierCode.FormattingEnabled = true;
            this.cboSupplierCode.ItemHeight = 23;
            this.cboSupplierCode.Location = new System.Drawing.Point(182, 117);
            this.cboSupplierCode.Name = "cboSupplierCode";
            this.cboSupplierCode.Size = new System.Drawing.Size(183, 29);
            this.cboSupplierCode.TabIndex = 2;
            this.cboSupplierCode.UseSelectable = true;
            this.cboSupplierCode.ValueMember = "SupplierID";
            // 
            // lblGrandTotalDB
            // 
            // 
            // 
            // 
            this.lblGrandTotalDB.CustomButton.Image = null;
            this.lblGrandTotalDB.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.lblGrandTotalDB.CustomButton.Name = "";
            this.lblGrandTotalDB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblGrandTotalDB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblGrandTotalDB.CustomButton.TabIndex = 1;
            this.lblGrandTotalDB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblGrandTotalDB.CustomButton.UseSelectable = true;
            this.lblGrandTotalDB.CustomButton.Visible = false;
            this.lblGrandTotalDB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePreOrderKain, "GrandTotal", true));
            this.lblGrandTotalDB.Lines = new string[0];
            this.lblGrandTotalDB.Location = new System.Drawing.Point(521, 520);
            this.lblGrandTotalDB.MaxLength = 32767;
            this.lblGrandTotalDB.Name = "lblGrandTotalDB";
            this.lblGrandTotalDB.PasswordChar = '\0';
            this.lblGrandTotalDB.ReadOnly = true;
            this.lblGrandTotalDB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblGrandTotalDB.SelectedText = "";
            this.lblGrandTotalDB.SelectionLength = 0;
            this.lblGrandTotalDB.SelectionStart = 0;
            this.lblGrandTotalDB.ShortcutsEnabled = true;
            this.lblGrandTotalDB.Size = new System.Drawing.Size(183, 23);
            this.lblGrandTotalDB.TabIndex = 25;
            this.lblGrandTotalDB.UseSelectable = true;
            this.lblGrandTotalDB.Visible = false;
            this.lblGrandTotalDB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblGrandTotalDB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NO
            // 
            this.NO.HeaderText = "No.";
            this.NO.Name = "NO";
            this.NO.ReadOnly = true;
            this.NO.Width = 60;
            // 
            // pONumberDataGridViewTextBoxColumn
            // 
            this.pONumberDataGridViewTextBoxColumn.DataPropertyName = "PONumber";
            this.pONumberDataGridViewTextBoxColumn.HeaderText = "No. PO";
            this.pONumberDataGridViewTextBoxColumn.Name = "pONumberDataGridViewTextBoxColumn";
            this.pONumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.pONumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // materialIDDataGridViewComboBoxColumn
            // 
            this.materialIDDataGridViewComboBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewComboBoxColumn.DataSource = this.materialBindingSource;
            this.materialIDDataGridViewComboBoxColumn.DisplayMember = "MaterialName";
            this.materialIDDataGridViewComboBoxColumn.HeaderText = "Material";
            this.materialIDDataGridViewComboBoxColumn.Name = "materialIDDataGridViewComboBoxColumn";
            this.materialIDDataGridViewComboBoxColumn.ReadOnly = true;
            this.materialIDDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.materialIDDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.materialIDDataGridViewComboBoxColumn.ValueMember = "MaterialID";
            // 
            // colorIDDataGridViewComboBoxColumn
            // 
            this.colorIDDataGridViewComboBoxColumn.DataPropertyName = "ColorID";
            this.colorIDDataGridViewComboBoxColumn.DataSource = this.colorBindingSource;
            this.colorIDDataGridViewComboBoxColumn.DisplayMember = "ColorName";
            this.colorIDDataGridViewComboBoxColumn.HeaderText = "Color";
            this.colorIDDataGridViewComboBoxColumn.Name = "colorIDDataGridViewComboBoxColumn";
            this.colorIDDataGridViewComboBoxColumn.ReadOnly = true;
            this.colorIDDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colorIDDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colorIDDataGridViewComboBoxColumn.ValueMember = "ColorID";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "DetailQty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Quantity (kg)";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "DetailPrice";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "DetailTotal";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailPOIDDataGridViewTextBoxColumn
            // 
            this.detailPOIDDataGridViewTextBoxColumn.DataPropertyName = "DetailPOID";
            this.detailPOIDDataGridViewTextBoxColumn.HeaderText = "DetailPOID";
            this.detailPOIDDataGridViewTextBoxColumn.Name = "detailPOIDDataGridViewTextBoxColumn";
            this.detailPOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.detailPOIDDataGridViewTextBoxColumn.Visible = false;
            this.detailPOIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // poKain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 675);
            this.Controls.Add(this.lblGrandTotalDB);
            this.Controls.Add(this.cboSupplierCode);
            this.Controls.Add(this.btnDeletePoKain);
            this.Controls.Add(this.btnEditPoKain);
            this.Controls.Add(this.btnAddPoKain);
            this.Controls.Add(this.btnSavePoKain);
            this.Controls.Add(this.btnExitPoKain);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.lblSupplierAddress);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lblPONumber);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "poKain";
            this.Text = "PO Kain";
            this.Load += new System.EventHandler(this.poKain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indomodaSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePreOrderKain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox lblSupplierName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox lblSupplierAddress;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox lblGrandTotal;
        private MetroFramework.Controls.MetroButton btnExitPoKain;
        private MetroFramework.Controls.MetroButton btnSavePoKain;
        private MetroFramework.Controls.MetroTile btnDeletePoKain;
        private MetroFramework.Controls.MetroTile btnEditPoKain;
        private MetroFramework.Controls.MetroTile btnAddPoKain;
        private MetroFramework.Controls.MetroComboBox cboSupplierCode;
        private System.Windows.Forms.BindingSource indomodaSupplierBindingSource;
        private System.Windows.Forms.BindingSource bindingSourcePreOrderKain;
        private System.Windows.Forms.BindingSource detailPOBindingSource;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.BindingSource colorBindingSource;
        public MetroFramework.Controls.MetroTextBox lblPONumber;
        public System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox lblGrandTotalDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn pONumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn materialIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn colorIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailPOIDDataGridViewTextBoxColumn;
    }
}