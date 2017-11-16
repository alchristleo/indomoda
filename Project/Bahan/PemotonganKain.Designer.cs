namespace Project
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pONumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusFakturDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.detailPOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.detailFakturBindingSourceCbo = new System.Windows.Forms.BindingSource(this.components);
            this.txtSupplierName = new MetroFramework.Controls.MetroTextBox();
            this.cboPICName = new MetroFramework.Controls.MetroComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPICCode = new MetroFramework.Controls.MetroTextBox();
            this.btnSavePemotonganKain = new MetroFramework.Controls.MetroButton();
            this.btnExitPemotonganKain = new MetroFramework.Controls.MetroButton();
            this.txtSupplierCode = new MetroFramework.Controls.MetroTextBox();
            this.txtPONumber = new MetroFramework.Controls.MetroTextBox();
            this.btnUpdateStatusPemotongan = new MetroFramework.Controls.MetroTile();
            this.btnDeleteFaktur = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailFakturBindingSourceCbo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NO,
            this.pONumberDataGridViewTextBoxColumn,
            this.materialIDDataGridViewComboBoxColumn,
            this.colorIDDataGridViewComboBoxColumn,
            this.detailQtyDataGridViewTextBoxColumn,
            this.statusFakturDataGridViewCheckBoxColumn,
            this.detailPOIDDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.detailPOBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.Location = new System.Drawing.Point(33, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(721, 240);
            this.dataGridView1.TabIndex = 4;
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
            this.pONumberDataGridViewTextBoxColumn.HeaderText = "PONumber";
            this.pONumberDataGridViewTextBoxColumn.Name = "pONumberDataGridViewTextBoxColumn";
            this.pONumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.pONumberDataGridViewTextBoxColumn.Width = 130;
            // 
            // materialIDDataGridViewComboBoxColumn
            // 
            this.materialIDDataGridViewComboBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewComboBoxColumn.DataSource = this.materialBindingSource;
            this.materialIDDataGridViewComboBoxColumn.DisplayMember = "MaterialName";
            this.materialIDDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.materialIDDataGridViewComboBoxColumn.HeaderText = "Material Name";
            this.materialIDDataGridViewComboBoxColumn.Name = "materialIDDataGridViewComboBoxColumn";
            this.materialIDDataGridViewComboBoxColumn.ReadOnly = true;
            this.materialIDDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.materialIDDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.materialIDDataGridViewComboBoxColumn.ValueMember = "MaterialID";
            this.materialIDDataGridViewComboBoxColumn.Width = 130;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(Project.Material);
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
            this.colorIDDataGridViewComboBoxColumn.Width = 135;
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(Project.Color);
            // 
            // detailQtyDataGridViewTextBoxColumn
            // 
            this.detailQtyDataGridViewTextBoxColumn.DataPropertyName = "DetailQty";
            this.detailQtyDataGridViewTextBoxColumn.HeaderText = "Quantity (kg)";
            this.detailQtyDataGridViewTextBoxColumn.Name = "detailQtyDataGridViewTextBoxColumn";
            this.detailQtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.detailQtyDataGridViewTextBoxColumn.Width = 120;
            // 
            // statusFakturDataGridViewCheckBoxColumn
            // 
            this.statusFakturDataGridViewCheckBoxColumn.DataPropertyName = "statusFaktur";
            this.statusFakturDataGridViewCheckBoxColumn.FalseValue = "false";
            this.statusFakturDataGridViewCheckBoxColumn.HeaderText = "Status Pemotongan";
            this.statusFakturDataGridViewCheckBoxColumn.Name = "statusFakturDataGridViewCheckBoxColumn";
            this.statusFakturDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusFakturDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusFakturDataGridViewCheckBoxColumn.TrueValue = "true";
            this.statusFakturDataGridViewCheckBoxColumn.Width = 140;
            // 
            // detailPOIDDataGridViewTextBoxColumn
            // 
            this.detailPOIDDataGridViewTextBoxColumn.DataPropertyName = "DetailPOID";
            this.detailPOIDDataGridViewTextBoxColumn.HeaderText = "DetailPOID";
            this.detailPOIDDataGridViewTextBoxColumn.Name = "detailPOIDDataGridViewTextBoxColumn";
            this.detailPOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.detailPOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // detailPOBindingSource
            // 
            this.detailPOBindingSource.DataSource = typeof(Project.DetailPO);
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
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "PIC Code";
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
            this.metroLabel7.Size = new System.Drawing.Size(69, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "PIC Name";
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
            this.cboFakturPenerimaanKain.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // detailFakturBindingSourceCbo
            // 
            this.detailFakturBindingSourceCbo.DataSource = typeof(Project.DetailFaktur);
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
            this.txtSupplierName.ReadOnly = true;
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
            // cboPICName
            // 
            this.cboPICName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPICName.DataSource = this.employeeBindingSource;
            this.cboPICName.DisplayMember = "EmployeeName";
            this.cboPICName.FormattingEnabled = true;
            this.cboPICName.ItemHeight = 23;
            this.cboPICName.Location = new System.Drawing.Point(228, 228);
            this.cboPICName.Name = "cboPICName";
            this.cboPICName.Size = new System.Drawing.Size(170, 29);
            this.cboPICName.TabIndex = 20;
            this.cboPICName.UseSelectable = true;
            this.cboPICName.ValueMember = "EmployeeID";
            this.cboPICName.SelectedIndexChanged += new System.EventHandler(this.cboPICName_SelectedIndexChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Project.Employee);
            // 
            // txtPICCode
            // 
            // 
            // 
            // 
            this.txtPICCode.CustomButton.Image = null;
            this.txtPICCode.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtPICCode.CustomButton.Name = "";
            this.txtPICCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPICCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPICCode.CustomButton.TabIndex = 1;
            this.txtPICCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPICCode.CustomButton.UseSelectable = true;
            this.txtPICCode.CustomButton.Visible = false;
            this.txtPICCode.Lines = new string[0];
            this.txtPICCode.Location = new System.Drawing.Point(498, 228);
            this.txtPICCode.MaxLength = 32767;
            this.txtPICCode.Name = "txtPICCode";
            this.txtPICCode.PasswordChar = '\0';
            this.txtPICCode.ReadOnly = true;
            this.txtPICCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPICCode.SelectedText = "";
            this.txtPICCode.SelectionLength = 0;
            this.txtPICCode.SelectionStart = 0;
            this.txtPICCode.ShortcutsEnabled = true;
            this.txtPICCode.Size = new System.Drawing.Size(169, 23);
            this.txtPICCode.TabIndex = 21;
            this.txtPICCode.UseSelectable = true;
            this.txtPICCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPICCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSavePemotonganKain
            // 
            this.btnSavePemotonganKain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePemotonganKain.Location = new System.Drawing.Point(424, 627);
            this.btnSavePemotonganKain.Name = "btnSavePemotonganKain";
            this.btnSavePemotonganKain.Size = new System.Drawing.Size(110, 48);
            this.btnSavePemotonganKain.TabIndex = 37;
            this.btnSavePemotonganKain.Text = "SAVE";
            this.btnSavePemotonganKain.UseSelectable = true;
            this.btnSavePemotonganKain.Click += new System.EventHandler(this.btnSavePemotonganKain_Click);
            // 
            // btnExitPemotonganKain
            // 
            this.btnExitPemotonganKain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitPemotonganKain.Location = new System.Drawing.Point(256, 627);
            this.btnExitPemotonganKain.Name = "btnExitPemotonganKain";
            this.btnExitPemotonganKain.Size = new System.Drawing.Size(110, 48);
            this.btnExitPemotonganKain.TabIndex = 36;
            this.btnExitPemotonganKain.Text = "EXIT";
            this.btnExitPemotonganKain.UseSelectable = true;
            this.btnExitPemotonganKain.Click += new System.EventHandler(this.btnExitPemotonganKain_Click_1);
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
            this.txtSupplierCode.ReadOnly = true;
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
            // txtPONumber
            // 
            // 
            // 
            // 
            this.txtPONumber.CustomButton.Image = null;
            this.txtPONumber.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtPONumber.CustomButton.Name = "";
            this.txtPONumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPONumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPONumber.CustomButton.TabIndex = 1;
            this.txtPONumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPONumber.CustomButton.UseSelectable = true;
            this.txtPONumber.CustomButton.Visible = false;
            this.txtPONumber.Lines = new string[0];
            this.txtPONumber.Location = new System.Drawing.Point(443, 119);
            this.txtPONumber.MaxLength = 32767;
            this.txtPONumber.Name = "txtPONumber";
            this.txtPONumber.PasswordChar = '\0';
            this.txtPONumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPONumber.SelectedText = "";
            this.txtPONumber.SelectionLength = 0;
            this.txtPONumber.SelectionStart = 0;
            this.txtPONumber.ShortcutsEnabled = true;
            this.txtPONumber.Size = new System.Drawing.Size(170, 23);
            this.txtPONumber.TabIndex = 39;
            this.txtPONumber.UseSelectable = true;
            this.txtPONumber.Visible = false;
            this.txtPONumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPONumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnUpdateStatusPemotongan
            // 
            this.btnUpdateStatusPemotongan.ActiveControl = null;
            this.btnUpdateStatusPemotongan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStatusPemotongan.Location = new System.Drawing.Point(162, 520);
            this.btnUpdateStatusPemotongan.Name = "btnUpdateStatusPemotongan";
            this.btnUpdateStatusPemotongan.Size = new System.Drawing.Size(217, 67);
            this.btnUpdateStatusPemotongan.TabIndex = 41;
            this.btnUpdateStatusPemotongan.Text = "UPDATE STATUS PEMOTONGAN";
            this.btnUpdateStatusPemotongan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateStatusPemotongan.TileImage = global::Project.Properties.Resources.btn_save;
            this.btnUpdateStatusPemotongan.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateStatusPemotongan.UseSelectable = true;
            this.btnUpdateStatusPemotongan.UseTileImage = true;
            this.btnUpdateStatusPemotongan.Click += new System.EventHandler(this.btnUpdateStatusPemotongan_Click);
            // 
            // btnDeleteFaktur
            // 
            this.btnDeleteFaktur.ActiveControl = null;
            this.btnDeleteFaktur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteFaktur.Location = new System.Drawing.Point(33, 520);
            this.btnDeleteFaktur.Name = "btnDeleteFaktur";
            this.btnDeleteFaktur.Size = new System.Drawing.Size(123, 67);
            this.btnDeleteFaktur.TabIndex = 40;
            this.btnDeleteFaktur.Text = "DELETE FAKTUR";
            this.btnDeleteFaktur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteFaktur.TileImage = global::Project.Properties.Resources.btn_delete;
            this.btnDeleteFaktur.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteFaktur.UseSelectable = true;
            this.btnDeleteFaktur.UseTileImage = true;
            this.btnDeleteFaktur.Click += new System.EventHandler(this.btnDeleteFaktur_Click);
            // 
            // PemotonganKain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 715);
            this.Controls.Add(this.btnUpdateStatusPemotongan);
            this.Controls.Add(this.btnDeleteFaktur);
            this.Controls.Add(this.txtPONumber);
            this.Controls.Add(this.txtSupplierCode);
            this.Controls.Add(this.btnSavePemotonganKain);
            this.Controls.Add(this.btnExitPemotonganKain);
            this.Controls.Add(this.txtPICCode);
            this.Controls.Add(this.cboPICName);
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
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailFakturBindingSourceCbo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
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
        private MetroFramework.Controls.MetroComboBox cboPICName;
        private MetroFramework.Controls.MetroTextBox txtPICCode;
        private MetroFramework.Controls.MetroButton btnSavePemotonganKain;
        private MetroFramework.Controls.MetroButton btnExitPemotonganKain;
        private MetroFramework.Controls.MetroTextBox txtSupplierCode;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource detailFakturBindingSourceCbo;
        private MetroFramework.Controls.MetroTextBox txtPONumber;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private System.Windows.Forms.BindingSource detailPOBindingSource;
        private MetroFramework.Controls.MetroTile btnUpdateStatusPemotongan;
        private MetroFramework.Controls.MetroTile btnDeleteFaktur;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn pONumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn materialIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn colorIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusFakturDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailPOIDDataGridViewTextBoxColumn;
    }
}