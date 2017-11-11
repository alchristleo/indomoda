namespace Project
{
    partial class PenerimaanTukangPotong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PenerimaanTukangPotong));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listPenerimaanTukangPotongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExitPenerimaanTukangPotong = new MetroFramework.Controls.MetroButton();
            this.btnSavePenerimaanTukangPotong = new MetroFramework.Controls.MetroButton();
            this.btnDeletePenerimaanTukangPotong = new MetroFramework.Controls.MetroTile();
            this.btnEditPenerimaanTukangPotong = new MetroFramework.Controls.MetroTile();
            this.btnAddPenerimaanTukangPotong = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtNoPenerimaanTukangPotong = new MetroFramework.Controls.MetroTextBox();
            this.txtPICName = new MetroFramework.Controls.MetroTextBox();
            this.cboNoPemotonganKain = new MetroFramework.Controls.MetroComboBox();
            this.detailPemotonganKainBindingSourceCbo = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.txtPICCode = new MetroFramework.Controls.MetroTextBox();
            this.txtIDPenerimaanTukangPotong = new MetroFramework.Controls.MetroTextBox();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idListPTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.merkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukuranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPenerimaanTukangPotongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPemotonganKainBindingSourceCbo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idListPTPDataGridViewTextBoxColumn,
            this.noSeriDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.colorIDDataGridViewComboBoxColumn,
            this.merkDataGridViewTextBoxColumn,
            this.ukuranDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listPenerimaanTukangPotongBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(52, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(738, 216);
            this.dataGridView1.TabIndex = 8;
            // 
            // listPenerimaanTukangPotongBindingSource
            // 
            this.listPenerimaanTukangPotongBindingSource.DataSource = typeof(Project.ListPenerimaanTukangPotong);
            // 
            // btnExitPenerimaanTukangPotong
            // 
            this.btnExitPenerimaanTukangPotong.Location = new System.Drawing.Point(290, 615);
            this.btnExitPenerimaanTukangPotong.Name = "btnExitPenerimaanTukangPotong";
            this.btnExitPenerimaanTukangPotong.Size = new System.Drawing.Size(93, 47);
            this.btnExitPenerimaanTukangPotong.TabIndex = 9;
            this.btnExitPenerimaanTukangPotong.Text = "EXIT";
            this.btnExitPenerimaanTukangPotong.UseSelectable = true;
            this.btnExitPenerimaanTukangPotong.Click += new System.EventHandler(this.btnExitPenerimaanTukangPotong_Click);
            // 
            // btnSavePenerimaanTukangPotong
            // 
            this.btnSavePenerimaanTukangPotong.Location = new System.Drawing.Point(464, 615);
            this.btnSavePenerimaanTukangPotong.Name = "btnSavePenerimaanTukangPotong";
            this.btnSavePenerimaanTukangPotong.Size = new System.Drawing.Size(93, 47);
            this.btnSavePenerimaanTukangPotong.TabIndex = 8;
            this.btnSavePenerimaanTukangPotong.Text = "SAVE";
            this.btnSavePenerimaanTukangPotong.UseSelectable = true;
            this.btnSavePenerimaanTukangPotong.Click += new System.EventHandler(this.btnSavePenerimaanTukangPotong_Click);
            // 
            // btnDeletePenerimaanTukangPotong
            // 
            this.btnDeletePenerimaanTukangPotong.ActiveControl = null;
            this.btnDeletePenerimaanTukangPotong.Location = new System.Drawing.Point(256, 515);
            this.btnDeletePenerimaanTukangPotong.Name = "btnDeletePenerimaanTukangPotong";
            this.btnDeletePenerimaanTukangPotong.Size = new System.Drawing.Size(87, 67);
            this.btnDeletePenerimaanTukangPotong.TabIndex = 7;
            this.btnDeletePenerimaanTukangPotong.Text = "DELETE";
            this.btnDeletePenerimaanTukangPotong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletePenerimaanTukangPotong.TileImage = global::Project.Properties.Resources.btn_delete;
            this.btnDeletePenerimaanTukangPotong.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletePenerimaanTukangPotong.UseSelectable = true;
            this.btnDeletePenerimaanTukangPotong.UseTileImage = true;
            this.btnDeletePenerimaanTukangPotong.Click += new System.EventHandler(this.btnDeletePenerimaanTukangPotong_Click);
            // 
            // btnEditPenerimaanTukangPotong
            // 
            this.btnEditPenerimaanTukangPotong.ActiveControl = null;
            this.btnEditPenerimaanTukangPotong.Location = new System.Drawing.Point(154, 515);
            this.btnEditPenerimaanTukangPotong.Name = "btnEditPenerimaanTukangPotong";
            this.btnEditPenerimaanTukangPotong.Size = new System.Drawing.Size(87, 67);
            this.btnEditPenerimaanTukangPotong.TabIndex = 6;
            this.btnEditPenerimaanTukangPotong.Text = "EDIT";
            this.btnEditPenerimaanTukangPotong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditPenerimaanTukangPotong.TileImage = global::Project.Properties.Resources.btn_pencil;
            this.btnEditPenerimaanTukangPotong.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditPenerimaanTukangPotong.UseSelectable = true;
            this.btnEditPenerimaanTukangPotong.UseTileImage = true;
            this.btnEditPenerimaanTukangPotong.Click += new System.EventHandler(this.btnEditPenerimaanTukangPotong_Click);
            // 
            // btnAddPenerimaanTukangPotong
            // 
            this.btnAddPenerimaanTukangPotong.ActiveControl = null;
            this.btnAddPenerimaanTukangPotong.Location = new System.Drawing.Point(52, 515);
            this.btnAddPenerimaanTukangPotong.Name = "btnAddPenerimaanTukangPotong";
            this.btnAddPenerimaanTukangPotong.Size = new System.Drawing.Size(85, 67);
            this.btnAddPenerimaanTukangPotong.TabIndex = 5;
            this.btnAddPenerimaanTukangPotong.Text = "ADD";
            this.btnAddPenerimaanTukangPotong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddPenerimaanTukangPotong.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddPenerimaanTukangPotong.TileImage")));
            this.btnAddPenerimaanTukangPotong.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddPenerimaanTukangPotong.UseSelectable = true;
            this.btnAddPenerimaanTukangPotong.UseTileImage = true;
            this.btnAddPenerimaanTukangPotong.Click += new System.EventHandler(this.btnAddPenerimaanTukangPotong_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(63, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(193, 19);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "No. Penerimaan Tukang Potong";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(63, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(137, 19);
            this.metroLabel2.TabIndex = 38;
            this.metroLabel2.Text = "No. Pemotongan Kain";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(63, 188);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 39;
            this.metroLabel3.Text = "PIC Code";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(63, 237);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 40;
            this.metroLabel4.Text = "PIC Name";
            // 
            // txtNoPenerimaanTukangPotong
            // 
            // 
            // 
            // 
            this.txtNoPenerimaanTukangPotong.CustomButton.Image = null;
            this.txtNoPenerimaanTukangPotong.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtNoPenerimaanTukangPotong.CustomButton.Name = "";
            this.txtNoPenerimaanTukangPotong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNoPenerimaanTukangPotong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNoPenerimaanTukangPotong.CustomButton.TabIndex = 1;
            this.txtNoPenerimaanTukangPotong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNoPenerimaanTukangPotong.CustomButton.UseSelectable = true;
            this.txtNoPenerimaanTukangPotong.CustomButton.Visible = false;
            this.txtNoPenerimaanTukangPotong.Lines = new string[0];
            this.txtNoPenerimaanTukangPotong.Location = new System.Drawing.Point(275, 105);
            this.txtNoPenerimaanTukangPotong.MaxLength = 32767;
            this.txtNoPenerimaanTukangPotong.Name = "txtNoPenerimaanTukangPotong";
            this.txtNoPenerimaanTukangPotong.PasswordChar = '\0';
            this.txtNoPenerimaanTukangPotong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNoPenerimaanTukangPotong.SelectedText = "";
            this.txtNoPenerimaanTukangPotong.SelectionLength = 0;
            this.txtNoPenerimaanTukangPotong.SelectionStart = 0;
            this.txtNoPenerimaanTukangPotong.ShortcutsEnabled = true;
            this.txtNoPenerimaanTukangPotong.Size = new System.Drawing.Size(156, 23);
            this.txtNoPenerimaanTukangPotong.TabIndex = 1;
            this.txtNoPenerimaanTukangPotong.UseSelectable = true;
            this.txtNoPenerimaanTukangPotong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNoPenerimaanTukangPotong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPICName
            // 
            // 
            // 
            // 
            this.txtPICName.CustomButton.Image = null;
            this.txtPICName.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtPICName.CustomButton.Name = "";
            this.txtPICName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPICName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPICName.CustomButton.TabIndex = 1;
            this.txtPICName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPICName.CustomButton.UseSelectable = true;
            this.txtPICName.CustomButton.Visible = false;
            this.txtPICName.Lines = new string[0];
            this.txtPICName.Location = new System.Drawing.Point(275, 233);
            this.txtPICName.MaxLength = 32767;
            this.txtPICName.Name = "txtPICName";
            this.txtPICName.PasswordChar = '\0';
            this.txtPICName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPICName.SelectedText = "";
            this.txtPICName.SelectionLength = 0;
            this.txtPICName.SelectionStart = 0;
            this.txtPICName.ShortcutsEnabled = true;
            this.txtPICName.Size = new System.Drawing.Size(156, 23);
            this.txtPICName.TabIndex = 4;
            this.txtPICName.UseSelectable = true;
            this.txtPICName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPICName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboNoPemotonganKain
            // 
            this.cboNoPemotonganKain.DataSource = this.detailPemotonganKainBindingSourceCbo;
            this.cboNoPemotonganKain.DisplayMember = "noPemotonganKain";
            this.cboNoPemotonganKain.FormattingEnabled = true;
            this.cboNoPemotonganKain.ItemHeight = 23;
            this.cboNoPemotonganKain.Location = new System.Drawing.Point(275, 146);
            this.cboNoPemotonganKain.Name = "cboNoPemotonganKain";
            this.cboNoPemotonganKain.Size = new System.Drawing.Size(156, 29);
            this.cboNoPemotonganKain.TabIndex = 2;
            this.cboNoPemotonganKain.UseSelectable = true;
            this.cboNoPemotonganKain.ValueMember = "noPemotonganKain";
            this.cboNoPemotonganKain.SelectedIndexChanged += new System.EventHandler(this.cboNoPemotonganKain_SelectedIndexChanged);
            // 
            // detailPemotonganKainBindingSourceCbo
            // 
            this.detailPemotonganKainBindingSourceCbo.DataSource = typeof(Project.DetailPemotonganKain);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(539, 60);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(36, 19);
            this.metroLabel5.TabIndex = 45;
            this.metroLabel5.Text = "Date";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(589, 60);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 46;
            // 
            // txtPICCode
            // 
            // 
            // 
            // 
            this.txtPICCode.CustomButton.Image = null;
            this.txtPICCode.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtPICCode.CustomButton.Name = "";
            this.txtPICCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPICCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPICCode.CustomButton.TabIndex = 1;
            this.txtPICCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPICCode.CustomButton.UseSelectable = true;
            this.txtPICCode.CustomButton.Visible = false;
            this.txtPICCode.Lines = new string[0];
            this.txtPICCode.Location = new System.Drawing.Point(275, 188);
            this.txtPICCode.MaxLength = 32767;
            this.txtPICCode.Name = "txtPICCode";
            this.txtPICCode.PasswordChar = '\0';
            this.txtPICCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPICCode.SelectedText = "";
            this.txtPICCode.SelectionLength = 0;
            this.txtPICCode.SelectionStart = 0;
            this.txtPICCode.ShortcutsEnabled = true;
            this.txtPICCode.Size = new System.Drawing.Size(156, 23);
            this.txtPICCode.TabIndex = 47;
            this.txtPICCode.UseSelectable = true;
            this.txtPICCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPICCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIDPenerimaanTukangPotong
            // 
            // 
            // 
            // 
            this.txtIDPenerimaanTukangPotong.CustomButton.Image = null;
            this.txtIDPenerimaanTukangPotong.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtIDPenerimaanTukangPotong.CustomButton.Name = "";
            this.txtIDPenerimaanTukangPotong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIDPenerimaanTukangPotong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDPenerimaanTukangPotong.CustomButton.TabIndex = 1;
            this.txtIDPenerimaanTukangPotong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDPenerimaanTukangPotong.CustomButton.UseSelectable = true;
            this.txtIDPenerimaanTukangPotong.CustomButton.Visible = false;
            this.txtIDPenerimaanTukangPotong.Lines = new string[0];
            this.txtIDPenerimaanTukangPotong.Location = new System.Drawing.Point(455, 105);
            this.txtIDPenerimaanTukangPotong.MaxLength = 32767;
            this.txtIDPenerimaanTukangPotong.Name = "txtIDPenerimaanTukangPotong";
            this.txtIDPenerimaanTukangPotong.PasswordChar = '\0';
            this.txtIDPenerimaanTukangPotong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDPenerimaanTukangPotong.SelectedText = "";
            this.txtIDPenerimaanTukangPotong.SelectionLength = 0;
            this.txtIDPenerimaanTukangPotong.SelectionStart = 0;
            this.txtIDPenerimaanTukangPotong.ShortcutsEnabled = true;
            this.txtIDPenerimaanTukangPotong.Size = new System.Drawing.Size(156, 23);
            this.txtIDPenerimaanTukangPotong.TabIndex = 48;
            this.txtIDPenerimaanTukangPotong.UseSelectable = true;
            this.txtIDPenerimaanTukangPotong.Visible = false;
            this.txtIDPenerimaanTukangPotong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDPenerimaanTukangPotong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(Project.Color);
            // 
            // idListPTPDataGridViewTextBoxColumn
            // 
            this.idListPTPDataGridViewTextBoxColumn.DataPropertyName = "idListPTP";
            this.idListPTPDataGridViewTextBoxColumn.HeaderText = "No.";
            this.idListPTPDataGridViewTextBoxColumn.Name = "idListPTPDataGridViewTextBoxColumn";
            this.idListPTPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noSeriDataGridViewTextBoxColumn
            // 
            this.noSeriDataGridViewTextBoxColumn.DataPropertyName = "noSeri";
            this.noSeriDataGridViewTextBoxColumn.HeaderText = "No Seri";
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
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PenerimaanTukangPotong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 704);
            this.Controls.Add(this.txtIDPenerimaanTukangPotong);
            this.Controls.Add(this.txtPICCode);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cboNoPemotonganKain);
            this.Controls.Add(this.txtPICName);
            this.Controls.Add(this.txtNoPenerimaanTukangPotong);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnDeletePenerimaanTukangPotong);
            this.Controls.Add(this.btnEditPenerimaanTukangPotong);
            this.Controls.Add(this.btnAddPenerimaanTukangPotong);
            this.Controls.Add(this.btnExitPenerimaanTukangPotong);
            this.Controls.Add(this.btnSavePenerimaanTukangPotong);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PenerimaanTukangPotong";
            this.Text = "Penerimaan Tukang Potong";
            this.Load += new System.EventHandler(this.PenerimaanTukangPotong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPenerimaanTukangPotongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPemotonganKainBindingSourceCbo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnExitPenerimaanTukangPotong;
        private MetroFramework.Controls.MetroButton btnSavePenerimaanTukangPotong;
        private MetroFramework.Controls.MetroTile btnDeletePenerimaanTukangPotong;
        private MetroFramework.Controls.MetroTile btnEditPenerimaanTukangPotong;
        private MetroFramework.Controls.MetroTile btnAddPenerimaanTukangPotong;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtNoPenerimaanTukangPotong;
        private MetroFramework.Controls.MetroTextBox txtPICName;
        private MetroFramework.Controls.MetroComboBox cboNoPemotonganKain;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTextBox txtPICCode;
        private MetroFramework.Controls.MetroTextBox txtIDPenerimaanTukangPotong;
        private System.Windows.Forms.BindingSource detailPemotonganKainBindingSourceCbo;
        private System.Windows.Forms.BindingSource listPenerimaanTukangPotongBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idListPTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn colorIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn merkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukuranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}