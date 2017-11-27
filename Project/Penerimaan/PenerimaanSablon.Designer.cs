namespace Project
{
    partial class PenerimaanSablon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.merkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukuranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyRusak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyAkhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPKSablonStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPKBordirStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPKCMTStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusSPKSablonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusSPKBordirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusSPKCMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusNoSeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idListPTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listPenerimaanTukangPotongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtNoPenerimaanSablon = new MetroFramework.Controls.MetroTextBox();
            this.cboNoSpkSablonPenerimaan = new MetroFramework.Controls.MetroComboBox();
            this.detailSPKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboPicPenerimaanSablon = new MetroFramework.Controls.MetroComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPICCodePenerimaan = new MetroFramework.Controls.MetroTextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.btnExitPenerimaanSablon = new MetroFramework.Controls.MetroButton();
            this.btnSavePenerimaanSablon = new MetroFramework.Controls.MetroButton();
            this.btnUpdateStatusPemotongan = new MetroFramework.Controls.MetroTile();
            this.btnResetPenerimaanSablon = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPenerimaanTukangPotongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailSPKBindingSource)).BeginInit();
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
            this.qtyRusak,
            this.qtyBS,
            this.qtyAkhir,
            this.SPKSablonStatus,
            this.SPKBordirStatus,
            this.SPKCMTStatus,
            this.statusSPKSablonDataGridViewTextBoxColumn,
            this.statusSPKBordirDataGridViewTextBoxColumn,
            this.statusSPKCMTDataGridViewTextBoxColumn,
            this.statusNoSeriDataGridViewTextBoxColumn,
            this.idListPTPDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.listPenerimaanTukangPotongBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.Location = new System.Drawing.Point(23, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1306, 255);
            this.dataGridView1.TabIndex = 5;
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
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(Project.Color);
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
            this.ukuranDataGridViewTextBoxColumn.Width = 70;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity Awal (pcs)";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 130;
            // 
            // qtyRusak
            // 
            this.qtyRusak.HeaderText = "Barang Rusak (pcs)";
            this.qtyRusak.Name = "qtyRusak";
            this.qtyRusak.ReadOnly = true;
            this.qtyRusak.Width = 120;
            this.qtyRusak.DefaultCellStyle.BackColor = System.Drawing.Color.Pink;
            // 
            // qtyBS
            // 
            this.qtyBS.HeaderText = "Barang BS (pcs) ";
            this.qtyBS.Name = "qtyBS";
            this.qtyBS.ReadOnly = true;
            this.qtyBS.Width = 120;
            this.qtyBS.DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;
            // 
            // qtyAkhir
            // 
            this.qtyAkhir.HeaderText = "Quantity Akhir (pcs)";
            this.qtyAkhir.Name = "qtyAkhir";
            this.qtyAkhir.ReadOnly = true;
            this.qtyAkhir.Width = 120;
            this.qtyAkhir.DefaultCellStyle.BackColor = System.Drawing.Color.Plum;
            // 
            // SPKSablonStatus
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Thistle;
            this.SPKSablonStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.SPKSablonStatus.HeaderText = "SPK Sablon";
            this.SPKSablonStatus.Name = "SPKSablonStatus";
            this.SPKSablonStatus.ReadOnly = true;
            // 
            // SPKBordirStatus
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGreen;
            this.SPKBordirStatus.DefaultCellStyle = dataGridViewCellStyle3;
            this.SPKBordirStatus.HeaderText = "SPK Bordir";
            this.SPKBordirStatus.Name = "SPKBordirStatus";
            this.SPKBordirStatus.ReadOnly = true;
            // 
            // SPKCMTStatus
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SPKCMTStatus.DefaultCellStyle = dataGridViewCellStyle4;
            this.SPKCMTStatus.HeaderText = "SPK CMT";
            this.SPKCMTStatus.Name = "SPKCMTStatus";
            this.SPKCMTStatus.ReadOnly = true;
            // 
            // statusSPKSablonDataGridViewTextBoxColumn
            // 
            this.statusSPKSablonDataGridViewTextBoxColumn.DataPropertyName = "statusSPKSablon";
            this.statusSPKSablonDataGridViewTextBoxColumn.HeaderText = "statusSPKSablon";
            this.statusSPKSablonDataGridViewTextBoxColumn.Name = "statusSPKSablonDataGridViewTextBoxColumn";
            this.statusSPKSablonDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusSPKSablonDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusSPKBordirDataGridViewTextBoxColumn
            // 
            this.statusSPKBordirDataGridViewTextBoxColumn.DataPropertyName = "statusSPKBordir";
            this.statusSPKBordirDataGridViewTextBoxColumn.HeaderText = "statusSPKBordir";
            this.statusSPKBordirDataGridViewTextBoxColumn.Name = "statusSPKBordirDataGridViewTextBoxColumn";
            this.statusSPKBordirDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusSPKBordirDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusSPKCMTDataGridViewTextBoxColumn
            // 
            this.statusSPKCMTDataGridViewTextBoxColumn.DataPropertyName = "statusSPKCMT";
            this.statusSPKCMTDataGridViewTextBoxColumn.HeaderText = "statusSPKCMT";
            this.statusSPKCMTDataGridViewTextBoxColumn.Name = "statusSPKCMTDataGridViewTextBoxColumn";
            this.statusSPKCMTDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusSPKCMTDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusNoSeriDataGridViewTextBoxColumn
            // 
            this.statusNoSeriDataGridViewTextBoxColumn.DataPropertyName = "statusNoSeri";
            this.statusNoSeriDataGridViewTextBoxColumn.HeaderText = "statusNoSeri";
            this.statusNoSeriDataGridViewTextBoxColumn.Name = "statusNoSeriDataGridViewTextBoxColumn";
            this.statusNoSeriDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusNoSeriDataGridViewTextBoxColumn.Visible = false;
            // 
            // idListPTPDataGridViewTextBoxColumn
            // 
            this.idListPTPDataGridViewTextBoxColumn.DataPropertyName = "idListPTP";
            this.idListPTPDataGridViewTextBoxColumn.HeaderText = "idListPTP";
            this.idListPTPDataGridViewTextBoxColumn.Name = "idListPTPDataGridViewTextBoxColumn";
            this.idListPTPDataGridViewTextBoxColumn.ReadOnly = true;
            this.idListPTPDataGridViewTextBoxColumn.Visible = false;
            // 
            // listPenerimaanTukangPotongBindingSource
            // 
            this.listPenerimaanTukangPotongBindingSource.DataSource = typeof(Project.ListPenerimaanTukangPotong);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "No. Penerimaan Sablon";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "No. SPK Sablon";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 185);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "PIC Code";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 145);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(73, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "PIC Sablon";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(992, 47);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(36, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Date";
            // 
            // txtNoPenerimaanSablon
            // 
            // 
            // 
            // 
            this.txtNoPenerimaanSablon.CustomButton.Image = null;
            this.txtNoPenerimaanSablon.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtNoPenerimaanSablon.CustomButton.Name = "";
            this.txtNoPenerimaanSablon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNoPenerimaanSablon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNoPenerimaanSablon.CustomButton.TabIndex = 1;
            this.txtNoPenerimaanSablon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNoPenerimaanSablon.CustomButton.UseSelectable = true;
            this.txtNoPenerimaanSablon.CustomButton.Visible = false;
            this.txtNoPenerimaanSablon.Lines = new string[0];
            this.txtNoPenerimaanSablon.Location = new System.Drawing.Point(176, 74);
            this.txtNoPenerimaanSablon.MaxLength = 32767;
            this.txtNoPenerimaanSablon.Name = "txtNoPenerimaanSablon";
            this.txtNoPenerimaanSablon.PasswordChar = '\0';
            this.txtNoPenerimaanSablon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNoPenerimaanSablon.SelectedText = "";
            this.txtNoPenerimaanSablon.SelectionLength = 0;
            this.txtNoPenerimaanSablon.SelectionStart = 0;
            this.txtNoPenerimaanSablon.ShortcutsEnabled = true;
            this.txtNoPenerimaanSablon.Size = new System.Drawing.Size(170, 23);
            this.txtNoPenerimaanSablon.TabIndex = 12;
            this.txtNoPenerimaanSablon.UseSelectable = true;
            this.txtNoPenerimaanSablon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNoPenerimaanSablon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboNoSpkSablonPenerimaan
            // 
            this.cboNoSpkSablonPenerimaan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboNoSpkSablonPenerimaan.DataSource = this.detailSPKBindingSource;
            this.cboNoSpkSablonPenerimaan.DisplayMember = "noSPK";
            this.cboNoSpkSablonPenerimaan.FormattingEnabled = true;
            this.cboNoSpkSablonPenerimaan.ItemHeight = 23;
            this.cboNoSpkSablonPenerimaan.Location = new System.Drawing.Point(176, 107);
            this.cboNoSpkSablonPenerimaan.Name = "cboNoSpkSablonPenerimaan";
            this.cboNoSpkSablonPenerimaan.Size = new System.Drawing.Size(170, 29);
            this.cboNoSpkSablonPenerimaan.TabIndex = 13;
            this.cboNoSpkSablonPenerimaan.UseSelectable = true;
            this.cboNoSpkSablonPenerimaan.ValueMember = "idSPK";
            this.cboNoSpkSablonPenerimaan.SelectedIndexChanged += new System.EventHandler(this.cboNoSpkSablonPenerimaan_SelectedIndexChanged);
            // 
            // detailSPKBindingSource
            // 
            this.detailSPKBindingSource.DataSource = typeof(Project.DetailSPK);
            // 
            // cboPicPenerimaanSablon
            // 
            this.cboPicPenerimaanSablon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPicPenerimaanSablon.DataSource = this.employeeBindingSource;
            this.cboPicPenerimaanSablon.DisplayMember = "EmployeeName";
            this.cboPicPenerimaanSablon.FormattingEnabled = true;
            this.cboPicPenerimaanSablon.ItemHeight = 23;
            this.cboPicPenerimaanSablon.Location = new System.Drawing.Point(176, 145);
            this.cboPicPenerimaanSablon.Name = "cboPicPenerimaanSablon";
            this.cboPicPenerimaanSablon.Size = new System.Drawing.Size(170, 29);
            this.cboPicPenerimaanSablon.TabIndex = 14;
            this.cboPicPenerimaanSablon.UseSelectable = true;
            this.cboPicPenerimaanSablon.ValueMember = "EmployeeID";
            this.cboPicPenerimaanSablon.SelectedIndexChanged += new System.EventHandler(this.cboPicPenerimaanSablon_SelectedIndexChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Project.Employee);
            // 
            // txtPICCodePenerimaan
            // 
            // 
            // 
            // 
            this.txtPICCodePenerimaan.CustomButton.Image = null;
            this.txtPICCodePenerimaan.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtPICCodePenerimaan.CustomButton.Name = "";
            this.txtPICCodePenerimaan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPICCodePenerimaan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPICCodePenerimaan.CustomButton.TabIndex = 1;
            this.txtPICCodePenerimaan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPICCodePenerimaan.CustomButton.UseSelectable = true;
            this.txtPICCodePenerimaan.CustomButton.Visible = false;
            this.txtPICCodePenerimaan.Lines = new string[0];
            this.txtPICCodePenerimaan.Location = new System.Drawing.Point(176, 185);
            this.txtPICCodePenerimaan.MaxLength = 32767;
            this.txtPICCodePenerimaan.Name = "txtPICCodePenerimaan";
            this.txtPICCodePenerimaan.PasswordChar = '\0';
            this.txtPICCodePenerimaan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPICCodePenerimaan.SelectedText = "";
            this.txtPICCodePenerimaan.SelectionLength = 0;
            this.txtPICCodePenerimaan.SelectionStart = 0;
            this.txtPICCodePenerimaan.ShortcutsEnabled = true;
            this.txtPICCodePenerimaan.Size = new System.Drawing.Size(170, 23);
            this.txtPICCodePenerimaan.TabIndex = 15;
            this.txtPICCodePenerimaan.UseSelectable = true;
            this.txtPICCodePenerimaan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPICCodePenerimaan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(1047, 40);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(219, 29);
            this.metroDateTime1.TabIndex = 16;
            // 
            // btnExitPenerimaanSablon
            // 
            this.btnExitPenerimaanSablon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitPenerimaanSablon.Location = new System.Drawing.Point(514, 578);
            this.btnExitPenerimaanSablon.Name = "btnExitPenerimaanSablon";
            this.btnExitPenerimaanSablon.Size = new System.Drawing.Size(100, 43);
            this.btnExitPenerimaanSablon.TabIndex = 17;
            this.btnExitPenerimaanSablon.Text = "EXIT";
            this.btnExitPenerimaanSablon.UseSelectable = true;
            this.btnExitPenerimaanSablon.Click += new System.EventHandler(this.btnExitPenerimaanSablon_Click);
            // 
            // btnSavePenerimaanSablon
            // 
            this.btnSavePenerimaanSablon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePenerimaanSablon.Location = new System.Drawing.Point(756, 578);
            this.btnSavePenerimaanSablon.Name = "btnSavePenerimaanSablon";
            this.btnSavePenerimaanSablon.Size = new System.Drawing.Size(96, 43);
            this.btnSavePenerimaanSablon.TabIndex = 18;
            this.btnSavePenerimaanSablon.Text = "SAVE";
            this.btnSavePenerimaanSablon.UseSelectable = true;
            this.btnSavePenerimaanSablon.Click += new System.EventHandler(this.btnSavePenerimaanSablon_Click);
            // 
            // btnUpdateStatusPemotongan
            // 
            this.btnUpdateStatusPemotongan.ActiveControl = null;
            this.btnUpdateStatusPemotongan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateStatusPemotongan.Location = new System.Drawing.Point(23, 488);
            this.btnUpdateStatusPemotongan.Name = "btnUpdateStatusPemotongan";
            this.btnUpdateStatusPemotongan.Size = new System.Drawing.Size(217, 67);
            this.btnUpdateStatusPemotongan.TabIndex = 42;
            this.btnUpdateStatusPemotongan.Text = "UPDATE QUANTITY BARANG";
            this.btnUpdateStatusPemotongan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateStatusPemotongan.TileImage = global::Project.Properties.Resources.btn_save;
            this.btnUpdateStatusPemotongan.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateStatusPemotongan.UseSelectable = true;
            this.btnUpdateStatusPemotongan.UseTileImage = true;
            this.btnUpdateStatusPemotongan.Click += new System.EventHandler(this.btnUpdateStatusPemotongan_Click);
            // 
            // btnResetPenerimaanSablon
            // 
            this.btnResetPenerimaanSablon.ActiveControl = null;
            this.btnResetPenerimaanSablon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPenerimaanSablon.Location = new System.Drawing.Point(256, 488);
            this.btnResetPenerimaanSablon.Name = "btnResetPenerimaanSablon";
            this.btnResetPenerimaanSablon.Size = new System.Drawing.Size(100, 67);
            this.btnResetPenerimaanSablon.TabIndex = 43;
            this.btnResetPenerimaanSablon.Text = "RESET DATA";
            this.btnResetPenerimaanSablon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResetPenerimaanSablon.TileImage = global::Project.Properties.Resources.btn_reset;
            this.btnResetPenerimaanSablon.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnResetPenerimaanSablon.UseSelectable = true;
            this.btnResetPenerimaanSablon.UseTileImage = true;
            this.btnResetPenerimaanSablon.Click += new System.EventHandler(this.btnResetPenerimaanSablon_Click);
            // 
            // PenerimaanSablon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 644);
            this.Controls.Add(this.btnResetPenerimaanSablon);
            this.Controls.Add(this.btnUpdateStatusPemotongan);
            this.Controls.Add(this.btnSavePenerimaanSablon);
            this.Controls.Add(this.btnExitPenerimaanSablon);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.txtPICCodePenerimaan);
            this.Controls.Add(this.cboPicPenerimaanSablon);
            this.Controls.Add(this.cboNoSpkSablonPenerimaan);
            this.Controls.Add(this.txtNoPenerimaanSablon);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PenerimaanSablon";
            this.Text = "Penerimaan Sablon";
            this.Load += new System.EventHandler(this.PenerimaanSablon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPenerimaanTukangPotongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailSPKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtNoPenerimaanSablon;
        private MetroFramework.Controls.MetroComboBox cboNoSpkSablonPenerimaan;
        private MetroFramework.Controls.MetroComboBox cboPicPenerimaanSablon;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private MetroFramework.Controls.MetroTextBox txtPICCodePenerimaan;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.BindingSource detailSPKBindingSource;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private System.Windows.Forms.BindingSource listPenerimaanTukangPotongBindingSource;
        private MetroFramework.Controls.MetroButton btnExitPenerimaanSablon;
        private MetroFramework.Controls.MetroButton btnSavePenerimaanSablon;
        private MetroFramework.Controls.MetroTile btnUpdateStatusPemotongan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn colorIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukuranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyRusak;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyAkhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPKSablonStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPKBordirStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPKCMTStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusSPKSablonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusSPKBordirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusSPKCMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusNoSeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idListPTPDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile btnResetPenerimaanSablon;
    }
}