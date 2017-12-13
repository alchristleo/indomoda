namespace Project
{
    partial class PenjualanBaju
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PenjualanBaju));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCountGTPB = new MetroFramework.Controls.MetroTile();
            this.lblGrandTotalDB = new MetroFramework.Controls.MetroTextBox();
            this.cboCustomerName = new MetroFramework.Controls.MetroComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeletePB = new MetroFramework.Controls.MetroTile();
            this.btnEditPB = new MetroFramework.Controls.MetroTile();
            this.btnAddPB = new MetroFramework.Controls.MetroTile();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.lblGrandTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblCustomerAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtNOTransaksi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblCustomerCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listPenjualanBajuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.merkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukuranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyLPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceLPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalLPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusLPBDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idLPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPenjualanBajuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCountGTPB
            // 
            this.btnCountGTPB.ActiveControl = null;
            this.btnCountGTPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCountGTPB.Location = new System.Drawing.Point(344, 522);
            this.btnCountGTPB.Name = "btnCountGTPB";
            this.btnCountGTPB.Size = new System.Drawing.Size(87, 67);
            this.btnCountGTPB.TabIndex = 44;
            this.btnCountGTPB.Text = "COUNT";
            this.btnCountGTPB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCountGTPB.TileImage = global::Project.Properties.Resources.btn_calculator;
            this.btnCountGTPB.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCountGTPB.UseSelectable = true;
            this.btnCountGTPB.UseTileImage = true;
            this.btnCountGTPB.Click += new System.EventHandler(this.btnCountGTPB_Click);
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
            this.lblGrandTotalDB.Lines = new string[0];
            this.lblGrandTotalDB.Location = new System.Drawing.Point(699, 562);
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
            this.lblGrandTotalDB.TabIndex = 43;
            this.lblGrandTotalDB.UseSelectable = true;
            this.lblGrandTotalDB.Visible = false;
            this.lblGrandTotalDB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblGrandTotalDB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCustomerName.DataSource = this.customerBindingSource;
            this.cboCustomerName.DisplayMember = "CustomerName";
            this.cboCustomerName.FormattingEnabled = true;
            this.cboCustomerName.ItemHeight = 23;
            this.cboCustomerName.Location = new System.Drawing.Point(172, 119);
            this.cboCustomerName.Name = "cboCustomerName";
            this.cboCustomerName.Size = new System.Drawing.Size(183, 29);
            this.cboCustomerName.TabIndex = 2;
            this.cboCustomerName.UseSelectable = true;
            this.cboCustomerName.ValueMember = "CustomerID";
            this.cboCustomerName.SelectedIndexChanged += new System.EventHandler(this.cboCustomerName_SelectedIndexChanged);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Project.Customer);
            // 
            // btnDeletePB
            // 
            this.btnDeletePB.ActiveControl = null;
            this.btnDeletePB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePB.Location = new System.Drawing.Point(242, 522);
            this.btnDeletePB.Name = "btnDeletePB";
            this.btnDeletePB.Size = new System.Drawing.Size(87, 67);
            this.btnDeletePB.TabIndex = 33;
            this.btnDeletePB.Text = "DELETE";
            this.btnDeletePB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletePB.TileImage = global::Project.Properties.Resources.btn_delete;
            this.btnDeletePB.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletePB.UseSelectable = true;
            this.btnDeletePB.UseTileImage = true;
            this.btnDeletePB.Click += new System.EventHandler(this.btnDeletePB_Click);
            // 
            // btnEditPB
            // 
            this.btnEditPB.ActiveControl = null;
            this.btnEditPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPB.Location = new System.Drawing.Point(140, 522);
            this.btnEditPB.Name = "btnEditPB";
            this.btnEditPB.Size = new System.Drawing.Size(87, 67);
            this.btnEditPB.TabIndex = 32;
            this.btnEditPB.Text = "EDIT";
            this.btnEditPB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditPB.TileImage = global::Project.Properties.Resources.btn_pencil;
            this.btnEditPB.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditPB.UseSelectable = true;
            this.btnEditPB.UseTileImage = true;
            this.btnEditPB.Click += new System.EventHandler(this.btnEditPB_Click);
            // 
            // btnAddPB
            // 
            this.btnAddPB.ActiveControl = null;
            this.btnAddPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPB.Location = new System.Drawing.Point(38, 522);
            this.btnAddPB.Name = "btnAddPB";
            this.btnAddPB.Size = new System.Drawing.Size(85, 67);
            this.btnAddPB.TabIndex = 31;
            this.btnAddPB.Text = "ADD";
            this.btnAddPB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddPB.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddPB.TileImage")));
            this.btnAddPB.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddPB.UseSelectable = true;
            this.btnAddPB.UseTileImage = true;
            this.btnAddPB.Click += new System.EventHandler(this.btnAddPB_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(514, 635);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 48);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(290, 635);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 48);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.lblGrandTotal.Lines = new string[0];
            this.lblGrandTotal.Location = new System.Drawing.Point(699, 533);
            this.lblGrandTotal.MaxLength = 32767;
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.PasswordChar = '\0';
            this.lblGrandTotal.ReadOnly = true;
            this.lblGrandTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblGrandTotal.SelectedText = "";
            this.lblGrandTotal.SelectionLength = 0;
            this.lblGrandTotal.SelectionStart = 0;
            this.lblGrandTotal.ShortcutsEnabled = true;
            this.lblGrandTotal.Size = new System.Drawing.Size(183, 23);
            this.lblGrandTotal.TabIndex = 34;
            this.lblGrandTotal.UseSelectable = true;
            this.lblGrandTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblGrandTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(607, 533);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 19);
            this.metroLabel6.TabIndex = 42;
            this.metroLabel6.Text = "Grand Total";
            // 
            // lblCustomerAddress
            // 
            // 
            // 
            // 
            this.lblCustomerAddress.CustomButton.Image = null;
            this.lblCustomerAddress.CustomButton.Location = new System.Drawing.Point(158, 2);
            this.lblCustomerAddress.CustomButton.Name = "";
            this.lblCustomerAddress.CustomButton.Size = new System.Drawing.Size(85, 85);
            this.lblCustomerAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCustomerAddress.CustomButton.TabIndex = 1;
            this.lblCustomerAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCustomerAddress.CustomButton.UseSelectable = true;
            this.lblCustomerAddress.CustomButton.Visible = false;
            this.lblCustomerAddress.Lines = new string[0];
            this.lblCustomerAddress.Location = new System.Drawing.Point(172, 163);
            this.lblCustomerAddress.MaxLength = 32767;
            this.lblCustomerAddress.Multiline = true;
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.PasswordChar = '\0';
            this.lblCustomerAddress.ReadOnly = true;
            this.lblCustomerAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblCustomerAddress.SelectedText = "";
            this.lblCustomerAddress.SelectionLength = 0;
            this.lblCustomerAddress.SelectionStart = 0;
            this.lblCustomerAddress.ShortcutsEnabled = true;
            this.lblCustomerAddress.Size = new System.Drawing.Size(246, 90);
            this.lblCustomerAddress.TabIndex = 30;
            this.lblCustomerAddress.UseSelectable = true;
            this.lblCustomerAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblCustomerAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(39, 163);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(117, 19);
            this.metroLabel5.TabIndex = 41;
            this.metroLabel5.Text = "Customer Address";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(39, 125);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(106, 19);
            this.metroLabel4.TabIndex = 40;
            this.metroLabel4.Text = "Customer Name";
            // 
            // txtNOTransaksi
            // 
            // 
            // 
            // 
            this.txtNOTransaksi.CustomButton.Image = null;
            this.txtNOTransaksi.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.txtNOTransaksi.CustomButton.Name = "";
            this.txtNOTransaksi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNOTransaksi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNOTransaksi.CustomButton.TabIndex = 1;
            this.txtNOTransaksi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNOTransaksi.CustomButton.UseSelectable = true;
            this.txtNOTransaksi.CustomButton.Visible = false;
            this.txtNOTransaksi.Lines = new string[0];
            this.txtNOTransaksi.Location = new System.Drawing.Point(172, 82);
            this.txtNOTransaksi.MaxLength = 32767;
            this.txtNOTransaksi.Name = "txtNOTransaksi";
            this.txtNOTransaksi.PasswordChar = '\0';
            this.txtNOTransaksi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNOTransaksi.SelectedText = "";
            this.txtNOTransaksi.SelectionLength = 0;
            this.txtNOTransaksi.SelectionStart = 0;
            this.txtNOTransaksi.ShortcutsEnabled = true;
            this.txtNOTransaksi.Size = new System.Drawing.Size(183, 23);
            this.txtNOTransaksi.TabIndex = 1;
            this.txtNOTransaksi.UseSelectable = true;
            this.txtNOTransaksi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNOTransaksi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(39, 82);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 19);
            this.metroLabel3.TabIndex = 39;
            this.metroLabel3.Text = "No. Transaksi";
            // 
            // lblCustomerCode
            // 
            // 
            // 
            // 
            this.lblCustomerCode.CustomButton.Image = null;
            this.lblCustomerCode.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.lblCustomerCode.CustomButton.Name = "";
            this.lblCustomerCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblCustomerCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCustomerCode.CustomButton.TabIndex = 1;
            this.lblCustomerCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCustomerCode.CustomButton.UseSelectable = true;
            this.lblCustomerCode.CustomButton.Visible = false;
            this.lblCustomerCode.Lines = new string[0];
            this.lblCustomerCode.Location = new System.Drawing.Point(568, 125);
            this.lblCustomerCode.MaxLength = 32767;
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.PasswordChar = '\0';
            this.lblCustomerCode.ReadOnly = true;
            this.lblCustomerCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblCustomerCode.SelectedText = "";
            this.lblCustomerCode.SelectionLength = 0;
            this.lblCustomerCode.SelectionStart = 0;
            this.lblCustomerCode.ShortcutsEnabled = true;
            this.lblCustomerCode.Size = new System.Drawing.Size(183, 23);
            this.lblCustomerCode.TabIndex = 29;
            this.lblCustomerCode.UseSelectable = true;
            this.lblCustomerCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblCustomerCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(459, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 19);
            this.metroLabel2.TabIndex = 38;
            this.metroLabel2.Text = "Customer Code";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NO,
            this.noSeriDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.colorIDDataGridViewComboBoxColumn,
            this.merkDataGridViewTextBoxColumn,
            this.ukuranDataGridViewTextBoxColumn,
            this.qtyLPBDataGridViewTextBoxColumn,
            this.priceLPBDataGridViewTextBoxColumn,
            this.totalLPBDataGridViewTextBoxColumn,
            this.statusLPBDataGridViewCheckBoxColumn,
            this.idLPBDataGridViewTextBoxColumn,
            this.idDPBDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.listPenjualanBajuBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.Location = new System.Drawing.Point(39, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(846, 242);
            this.dataGridView1.TabIndex = 35;
            // 
            // listPenjualanBajuBindingSource
            // 
            this.listPenjualanBajuBindingSource.DataSource = typeof(Project.ListPenjualanBaju);
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(Project.Color);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(635, 49);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 46;
            this.metroLabel1.Text = "Date";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CausesValidation = false;
            this.metroDateTime1.Location = new System.Drawing.Point(672, 45);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(213, 29);
            this.metroDateTime1.TabIndex = 45;
            // 
            // NO
            // 
            this.NO.HeaderText = "No.";
            this.NO.Name = "NO";
            this.NO.ReadOnly = true;
            this.NO.Width = 40;
            // 
            // noSeriDataGridViewTextBoxColumn
            // 
            this.noSeriDataGridViewTextBoxColumn.DataPropertyName = "noSeri";
            this.noSeriDataGridViewTextBoxColumn.HeaderText = "No. Seri";
            this.noSeriDataGridViewTextBoxColumn.Name = "noSeriDataGridViewTextBoxColumn";
            this.noSeriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorIDDataGridViewComboBoxColumn
            // 
            this.colorIDDataGridViewComboBoxColumn.DataPropertyName = "ColorID";
            this.colorIDDataGridViewComboBoxColumn.DataSource = this.colorBindingSource;
            this.colorIDDataGridViewComboBoxColumn.DisplayMember = "ColorName";
            this.colorIDDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colorIDDataGridViewComboBoxColumn.HeaderText = "Color Name";
            this.colorIDDataGridViewComboBoxColumn.Name = "colorIDDataGridViewComboBoxColumn";
            this.colorIDDataGridViewComboBoxColumn.ReadOnly = true;
            this.colorIDDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colorIDDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colorIDDataGridViewComboBoxColumn.ValueMember = "ColorID";
            // 
            // merkDataGridViewTextBoxColumn
            // 
            this.merkDataGridViewTextBoxColumn.DataPropertyName = "merk";
            this.merkDataGridViewTextBoxColumn.HeaderText = "Merk";
            this.merkDataGridViewTextBoxColumn.Name = "merkDataGridViewTextBoxColumn";
            this.merkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ukuranDataGridViewTextBoxColumn
            // 
            this.ukuranDataGridViewTextBoxColumn.DataPropertyName = "ukuran";
            this.ukuranDataGridViewTextBoxColumn.HeaderText = "Ukuran";
            this.ukuranDataGridViewTextBoxColumn.Name = "ukuranDataGridViewTextBoxColumn";
            this.ukuranDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyLPBDataGridViewTextBoxColumn
            // 
            this.qtyLPBDataGridViewTextBoxColumn.DataPropertyName = "qtyLPB";
            this.qtyLPBDataGridViewTextBoxColumn.HeaderText = "Quantity (pcs) ";
            this.qtyLPBDataGridViewTextBoxColumn.Name = "qtyLPBDataGridViewTextBoxColumn";
            this.qtyLPBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceLPBDataGridViewTextBoxColumn
            // 
            this.priceLPBDataGridViewTextBoxColumn.DataPropertyName = "priceLPB";
            this.priceLPBDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.priceLPBDataGridViewTextBoxColumn.Name = "priceLPBDataGridViewTextBoxColumn";
            this.priceLPBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalLPBDataGridViewTextBoxColumn
            // 
            this.totalLPBDataGridViewTextBoxColumn.DataPropertyName = "totalLPB";
            this.totalLPBDataGridViewTextBoxColumn.HeaderText = "Total Harga";
            this.totalLPBDataGridViewTextBoxColumn.Name = "totalLPBDataGridViewTextBoxColumn";
            this.totalLPBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusLPBDataGridViewCheckBoxColumn
            // 
            this.statusLPBDataGridViewCheckBoxColumn.DataPropertyName = "statusLPB";
            this.statusLPBDataGridViewCheckBoxColumn.HeaderText = "statusLPB";
            this.statusLPBDataGridViewCheckBoxColumn.Name = "statusLPBDataGridViewCheckBoxColumn";
            this.statusLPBDataGridViewCheckBoxColumn.ReadOnly = true;
            this.statusLPBDataGridViewCheckBoxColumn.Visible = false;
            // 
            // idLPBDataGridViewTextBoxColumn
            // 
            this.idLPBDataGridViewTextBoxColumn.DataPropertyName = "idLPB";
            this.idLPBDataGridViewTextBoxColumn.HeaderText = "idLPB";
            this.idLPBDataGridViewTextBoxColumn.Name = "idLPBDataGridViewTextBoxColumn";
            this.idLPBDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLPBDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDPBDataGridViewTextBoxColumn
            // 
            this.idDPBDataGridViewTextBoxColumn.DataPropertyName = "idDPB";
            this.idDPBDataGridViewTextBoxColumn.HeaderText = "idDPB";
            this.idDPBDataGridViewTextBoxColumn.Name = "idDPBDataGridViewTextBoxColumn";
            this.idDPBDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDPBDataGridViewTextBoxColumn.Visible = false;
            // 
            // PenjualanBaju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 715);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.btnCountGTPB);
            this.Controls.Add(this.lblGrandTotalDB);
            this.Controls.Add(this.cboCustomerName);
            this.Controls.Add(this.btnDeletePB);
            this.Controls.Add(this.btnEditPB);
            this.Controls.Add(this.btnAddPB);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtNOTransaksi);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblCustomerCode);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PenjualanBaju";
            this.Text = "Penjualan Baju";
            this.Load += new System.EventHandler(this.PenjualanBaju_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPenjualanBajuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MetroFramework.Controls.MetroTile btnCountGTPB;
        private MetroFramework.Controls.MetroTextBox lblGrandTotalDB;
        private MetroFramework.Controls.MetroComboBox cboCustomerName;
        private MetroFramework.Controls.MetroTile btnDeletePB;
        private MetroFramework.Controls.MetroTile btnEditPB;
        private MetroFramework.Controls.MetroTile btnAddPB;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroTextBox lblGrandTotal;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox lblCustomerAddress;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroTextBox txtNOTransaksi;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox lblCustomerCode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private System.Windows.Forms.BindingSource listPenjualanBajuBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn colorIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukuranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyLPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceLPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalLPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusLPBDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDPBDataGridViewTextBoxColumn;
    }
}