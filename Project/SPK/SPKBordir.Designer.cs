namespace Project
{
    partial class SPKBordir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPKBordir));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listPenerimaanTukangPotongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNoSpkBordir = new MetroFramework.Controls.MetroTextBox();
            this.cboPICBordir = new MetroFramework.Controls.MetroComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPicCodeBordir = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.btnSaveSPKBordir = new MetroFramework.Controls.MetroButton();
            this.btnExitSPKBordir = new MetroFramework.Controls.MetroButton();
            this.btnDeleteSPKBordir = new MetroFramework.Controls.MetroTile();
            this.btnAddSPKBordir = new MetroFramework.Controls.MetroTile();
            this.txtIDSPK = new MetroFramework.Controls.MetroTextBox();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.merkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukuranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPKSablonStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPKBordirStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPKCMTStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusSPKSablonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusSPKBordirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusSPKCMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSPKSablon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSPKBordir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSPKCMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPenerimaanTukangPotong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idListPTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPenerimaanTukangPotongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
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
            this.quantityDataGridViewTextBoxColumn,
            this.SPKSablonStatus,
            this.SPKBordirStatus,
            this.SPKCMTStatus,
            this.statusSPKSablonDataGridViewTextBoxColumn,
            this.statusSPKBordirDataGridViewTextBoxColumn,
            this.statusSPKCMTDataGridViewTextBoxColumn,
            this.idSPKSablon,
            this.idSPKBordir,
            this.idSPKCMT,
            this.idPenerimaanTukangPotong,
            this.idListPTPDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.listPenerimaanTukangPotongBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.Location = new System.Drawing.Point(34, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 308);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(Project.Color);
            // 
            // listPenerimaanTukangPotongBindingSource
            // 
            this.listPenerimaanTukangPotongBindingSource.DataSource = typeof(Project.ListPenerimaanTukangPotong);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "No. SPK Bordir";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(34, 117);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "PIC Bordir";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(34, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "PIC Code";
            // 
            // txtNoSpkBordir
            // 
            // 
            // 
            // 
            this.txtNoSpkBordir.CustomButton.Image = null;
            this.txtNoSpkBordir.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtNoSpkBordir.CustomButton.Name = "";
            this.txtNoSpkBordir.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNoSpkBordir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNoSpkBordir.CustomButton.TabIndex = 1;
            this.txtNoSpkBordir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNoSpkBordir.CustomButton.UseSelectable = true;
            this.txtNoSpkBordir.CustomButton.Visible = false;
            this.txtNoSpkBordir.Lines = new string[0];
            this.txtNoSpkBordir.Location = new System.Drawing.Point(157, 81);
            this.txtNoSpkBordir.MaxLength = 32767;
            this.txtNoSpkBordir.Name = "txtNoSpkBordir";
            this.txtNoSpkBordir.PasswordChar = '\0';
            this.txtNoSpkBordir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNoSpkBordir.SelectedText = "";
            this.txtNoSpkBordir.SelectionLength = 0;
            this.txtNoSpkBordir.SelectionStart = 0;
            this.txtNoSpkBordir.ShortcutsEnabled = true;
            this.txtNoSpkBordir.Size = new System.Drawing.Size(181, 23);
            this.txtNoSpkBordir.TabIndex = 25;
            this.txtNoSpkBordir.UseSelectable = true;
            this.txtNoSpkBordir.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNoSpkBordir.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboPICBordir
            // 
            this.cboPICBordir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPICBordir.DataSource = this.employeeBindingSource;
            this.cboPICBordir.DisplayMember = "EmployeeName";
            this.cboPICBordir.FormattingEnabled = true;
            this.cboPICBordir.ItemHeight = 23;
            this.cboPICBordir.Location = new System.Drawing.Point(157, 115);
            this.cboPICBordir.Name = "cboPICBordir";
            this.cboPICBordir.Size = new System.Drawing.Size(181, 29);
            this.cboPICBordir.TabIndex = 26;
            this.cboPICBordir.UseSelectable = true;
            this.cboPICBordir.ValueMember = "EmployeeID";
            this.cboPICBordir.SelectedIndexChanged += new System.EventHandler(this.cboPICBordir_SelectedIndexChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Project.Employee);
            // 
            // txtPicCodeBordir
            // 
            // 
            // 
            // 
            this.txtPicCodeBordir.CustomButton.Image = null;
            this.txtPicCodeBordir.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtPicCodeBordir.CustomButton.Name = "";
            this.txtPicCodeBordir.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPicCodeBordir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPicCodeBordir.CustomButton.TabIndex = 1;
            this.txtPicCodeBordir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPicCodeBordir.CustomButton.UseSelectable = true;
            this.txtPicCodeBordir.CustomButton.Visible = false;
            this.txtPicCodeBordir.Lines = new string[0];
            this.txtPicCodeBordir.Location = new System.Drawing.Point(157, 154);
            this.txtPicCodeBordir.MaxLength = 32767;
            this.txtPicCodeBordir.Name = "txtPicCodeBordir";
            this.txtPicCodeBordir.PasswordChar = '\0';
            this.txtPicCodeBordir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPicCodeBordir.SelectedText = "";
            this.txtPicCodeBordir.SelectionLength = 0;
            this.txtPicCodeBordir.SelectionStart = 0;
            this.txtPicCodeBordir.ShortcutsEnabled = true;
            this.txtPicCodeBordir.Size = new System.Drawing.Size(181, 23);
            this.txtPicCodeBordir.TabIndex = 27;
            this.txtPicCodeBordir.UseSelectable = true;
            this.txtPicCodeBordir.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPicCodeBordir.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(774, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(36, 19);
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "Date";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(828, 60);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(236, 29);
            this.metroDateTime1.TabIndex = 29;
            // 
            // btnSaveSPKBordir
            // 
            this.btnSaveSPKBordir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSPKBordir.Location = new System.Drawing.Point(575, 596);
            this.btnSaveSPKBordir.Name = "btnSaveSPKBordir";
            this.btnSaveSPKBordir.Size = new System.Drawing.Size(116, 50);
            this.btnSaveSPKBordir.TabIndex = 30;
            this.btnSaveSPKBordir.Text = "SAVE";
            this.btnSaveSPKBordir.UseSelectable = true;
            this.btnSaveSPKBordir.Click += new System.EventHandler(this.btnSaveSPKBordir_Click);
            // 
            // btnExitSPKBordir
            // 
            this.btnExitSPKBordir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitSPKBordir.Location = new System.Drawing.Point(432, 596);
            this.btnExitSPKBordir.Name = "btnExitSPKBordir";
            this.btnExitSPKBordir.Size = new System.Drawing.Size(107, 50);
            this.btnExitSPKBordir.TabIndex = 31;
            this.btnExitSPKBordir.Text = "EXIT";
            this.btnExitSPKBordir.UseSelectable = true;
            this.btnExitSPKBordir.Click += new System.EventHandler(this.btnExitSPKBordir_Click);
            // 
            // btnDeleteSPKBordir
            // 
            this.btnDeleteSPKBordir.ActiveControl = null;
            this.btnDeleteSPKBordir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSPKBordir.Location = new System.Drawing.Point(142, 506);
            this.btnDeleteSPKBordir.Name = "btnDeleteSPKBordir";
            this.btnDeleteSPKBordir.Size = new System.Drawing.Size(87, 67);
            this.btnDeleteSPKBordir.TabIndex = 33;
            this.btnDeleteSPKBordir.Text = "DELETE";
            this.btnDeleteSPKBordir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteSPKBordir.TileImage = global::Project.Properties.Resources.btn_delete;
            this.btnDeleteSPKBordir.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteSPKBordir.UseSelectable = true;
            this.btnDeleteSPKBordir.UseTileImage = true;
            this.btnDeleteSPKBordir.Click += new System.EventHandler(this.btnDeleteSPKBordir_Click);
            // 
            // btnAddSPKBordir
            // 
            this.btnAddSPKBordir.ActiveControl = null;
            this.btnAddSPKBordir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSPKBordir.Location = new System.Drawing.Point(34, 506);
            this.btnAddSPKBordir.Name = "btnAddSPKBordir";
            this.btnAddSPKBordir.Size = new System.Drawing.Size(89, 67);
            this.btnAddSPKBordir.TabIndex = 32;
            this.btnAddSPKBordir.Text = "ADD";
            this.btnAddSPKBordir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSPKBordir.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddSPKBordir.TileImage")));
            this.btnAddSPKBordir.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSPKBordir.UseSelectable = true;
            this.btnAddSPKBordir.UseTileImage = true;
            this.btnAddSPKBordir.Click += new System.EventHandler(this.btnAddSPKBordir_Click);
            // 
            // txtIDSPK
            // 
            // 
            // 
            // 
            this.txtIDSPK.CustomButton.Image = null;
            this.txtIDSPK.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtIDSPK.CustomButton.Name = "";
            this.txtIDSPK.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIDSPK.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDSPK.CustomButton.TabIndex = 1;
            this.txtIDSPK.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDSPK.CustomButton.UseSelectable = true;
            this.txtIDSPK.CustomButton.Visible = false;
            this.txtIDSPK.Lines = new string[0];
            this.txtIDSPK.Location = new System.Drawing.Point(389, 76);
            this.txtIDSPK.MaxLength = 32767;
            this.txtIDSPK.Name = "txtIDSPK";
            this.txtIDSPK.PasswordChar = '\0';
            this.txtIDSPK.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDSPK.SelectedText = "";
            this.txtIDSPK.SelectionLength = 0;
            this.txtIDSPK.SelectionStart = 0;
            this.txtIDSPK.ShortcutsEnabled = true;
            this.txtIDSPK.Size = new System.Drawing.Size(168, 23);
            this.txtIDSPK.TabIndex = 34;
            this.txtIDSPK.UseSelectable = true;
            this.txtIDSPK.Visible = false;
            this.txtIDSPK.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDSPK.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.noSeriDataGridViewTextBoxColumn.HeaderText = "No Seri";
            this.noSeriDataGridViewTextBoxColumn.Name = "noSeriDataGridViewTextBoxColumn";
            this.noSeriDataGridViewTextBoxColumn.ReadOnly = true;
            this.noSeriDataGridViewTextBoxColumn.Width = 120;
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
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity (pcs)";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SPKSablonStatus
            // 
            this.SPKSablonStatus.HeaderText = "SPK Sablon";
            this.SPKSablonStatus.Name = "SPKSablonStatus";
            this.SPKSablonStatus.ReadOnly = true;
            this.SPKSablonStatus.Width = 120;
            this.SPKSablonStatus.DefaultCellStyle.BackColor = System.Drawing.Color.Thistle;
            // 
            // SPKBordirStatus
            // 
            this.SPKBordirStatus.HeaderText = "SPK Bordir";
            this.SPKBordirStatus.Name = "SPKBordirStatus";
            this.SPKBordirStatus.ReadOnly = true;
            this.SPKBordirStatus.Width = 120;
            this.SPKBordirStatus.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            // 
            // SPKCMTStatus
            // 
            this.SPKCMTStatus.HeaderText = "SPK CMT";
            this.SPKCMTStatus.Name = "SPKCMTStatus";
            this.SPKCMTStatus.ReadOnly = true;
            this.SPKCMTStatus.Width = 120;
            this.SPKCMTStatus.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // statusSPKSablonDataGridViewTextBoxColumn
            // 
            this.statusSPKSablonDataGridViewTextBoxColumn.DataPropertyName = "statusSPKSablon";
            this.statusSPKSablonDataGridViewTextBoxColumn.HeaderText = "statusSPKSablon";
            this.statusSPKSablonDataGridViewTextBoxColumn.Name = "statusSPKSablonDataGridViewTextBoxColumn";
            this.statusSPKSablonDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusSPKSablonDataGridViewTextBoxColumn.Visible = false;
            this.statusSPKSablonDataGridViewTextBoxColumn.Width = 120;
            // 
            // statusSPKBordirDataGridViewTextBoxColumn
            // 
            this.statusSPKBordirDataGridViewTextBoxColumn.DataPropertyName = "statusSPKBordir";
            this.statusSPKBordirDataGridViewTextBoxColumn.HeaderText = "statusSPKBordir";
            this.statusSPKBordirDataGridViewTextBoxColumn.Name = "statusSPKBordirDataGridViewTextBoxColumn";
            this.statusSPKBordirDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusSPKBordirDataGridViewTextBoxColumn.Visible = false;
            this.statusSPKBordirDataGridViewTextBoxColumn.Width = 120;
            // 
            // statusSPKCMTDataGridViewTextBoxColumn
            // 
            this.statusSPKCMTDataGridViewTextBoxColumn.DataPropertyName = "statusSPKCMT";
            this.statusSPKCMTDataGridViewTextBoxColumn.HeaderText = "statusSPKCMT";
            this.statusSPKCMTDataGridViewTextBoxColumn.Name = "statusSPKCMTDataGridViewTextBoxColumn";
            this.statusSPKCMTDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusSPKCMTDataGridViewTextBoxColumn.Visible = false;
            this.statusSPKCMTDataGridViewTextBoxColumn.Width = 120;
            // 
            // idSPKSablon
            // 
            this.idSPKSablon.DataPropertyName = "idSPKSablon";
            this.idSPKSablon.HeaderText = "idSPKSablon";
            this.idSPKSablon.Name = "idSPKSablon";
            this.idSPKSablon.ReadOnly = true;
            this.idSPKSablon.Visible = false;
            // 
            // idSPKBordir
            // 
            this.idSPKBordir.DataPropertyName = "idSPKBordir";
            this.idSPKBordir.HeaderText = "idSPKBordir";
            this.idSPKBordir.Name = "idSPKBordir";
            this.idSPKBordir.ReadOnly = true;
            this.idSPKBordir.Visible = false;
            // 
            // idSPKCMT
            // 
            this.idSPKCMT.DataPropertyName = "idSPKCMT";
            this.idSPKCMT.HeaderText = "idSPKCMT";
            this.idSPKCMT.Name = "idSPKCMT";
            this.idSPKCMT.ReadOnly = true;
            this.idSPKCMT.Visible = false;
            // 
            // idPenerimaanTukangPotong
            // 
            this.idPenerimaanTukangPotong.DataPropertyName = "idPenerimaanTukangPotong";
            this.idPenerimaanTukangPotong.HeaderText = "idPenerimaanTukangPotong";
            this.idPenerimaanTukangPotong.Name = "idPenerimaanTukangPotong";
            this.idPenerimaanTukangPotong.ReadOnly = true;
            this.idPenerimaanTukangPotong.Visible = false;
            // 
            // idListPTPDataGridViewTextBoxColumn
            // 
            this.idListPTPDataGridViewTextBoxColumn.DataPropertyName = "idListPTP";
            this.idListPTPDataGridViewTextBoxColumn.HeaderText = "idListPTP";
            this.idListPTPDataGridViewTextBoxColumn.Name = "idListPTPDataGridViewTextBoxColumn";
            this.idListPTPDataGridViewTextBoxColumn.ReadOnly = true;
            this.idListPTPDataGridViewTextBoxColumn.Visible = false;
            // 
            // SPKBordir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 680);
            this.Controls.Add(this.txtIDSPK);
            this.Controls.Add(this.btnDeleteSPKBordir);
            this.Controls.Add(this.btnAddSPKBordir);
            this.Controls.Add(this.btnExitSPKBordir);
            this.Controls.Add(this.btnSaveSPKBordir);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtPicCodeBordir);
            this.Controls.Add(this.cboPICBordir);
            this.Controls.Add(this.txtNoSpkBordir);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SPKBordir";
            this.Text = " SPK Bordir";
            this.Load += new System.EventHandler(this.SPKBordir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPenerimaanTukangPotongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNoSpkBordir;
        private MetroFramework.Controls.MetroComboBox cboPICBordir;
        private MetroFramework.Controls.MetroTextBox txtPicCodeBordir;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroButton btnSaveSPKBordir;
        private MetroFramework.Controls.MetroButton btnExitSPKBordir;
        private MetroFramework.Controls.MetroTile btnDeleteSPKBordir;
        private MetroFramework.Controls.MetroTile btnAddSPKBordir;
        private System.Windows.Forms.BindingSource listPenerimaanTukangPotongBindingSource;
        private MetroFramework.Controls.MetroTextBox txtIDSPK;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn colorIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukuranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPKSablonStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPKBordirStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPKCMTStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusSPKSablonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusSPKBordirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusSPKCMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSPKSablon;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSPKBordir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSPKCMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPenerimaanTukangPotong;
        private System.Windows.Forms.DataGridViewTextBoxColumn idListPTPDataGridViewTextBoxColumn;
    }
}