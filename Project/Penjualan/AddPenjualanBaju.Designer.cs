namespace Project
{
    partial class AddPenjualanBaju
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
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.merkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukuranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBajuJadiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboWarna = new MetroFramework.Controls.MetroComboBox();
            this.txtQtyInput = new MetroFramework.Controls.MetroTextBox();
            this.txtMerk = new MetroFramework.Controls.MetroTextBox();
            this.txtModel = new MetroFramework.Controls.MetroTextBox();
            this.txtNoSeri = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtUkuran = new MetroFramework.Controls.MetroTextBox();
            this.txtHargaInput = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBajuJadiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 75);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(91, 19);
            this.metroLabel7.TabIndex = 62;
            this.metroLabel7.Text = "Select No Seri";
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
            this.stockDataGridViewTextBoxColumn,
            this.idBJDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.listBajuJadiBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.Location = new System.Drawing.Point(23, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(768, 258);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.noSeriDataGridViewTextBoxColumn.Width = 120;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 120;
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
            this.colorIDDataGridViewComboBoxColumn.Width = 120;
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
            this.merkDataGridViewTextBoxColumn.Width = 120;
            // 
            // ukuranDataGridViewTextBoxColumn
            // 
            this.ukuranDataGridViewTextBoxColumn.DataPropertyName = "ukuran";
            this.ukuranDataGridViewTextBoxColumn.HeaderText = "Ukuran";
            this.ukuranDataGridViewTextBoxColumn.Name = "ukuranDataGridViewTextBoxColumn";
            this.ukuranDataGridViewTextBoxColumn.ReadOnly = true;
            this.ukuranDataGridViewTextBoxColumn.Width = 120;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock Baju (pcs)";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockDataGridViewTextBoxColumn.Width = 120;
            // 
            // idBJDataGridViewTextBoxColumn
            // 
            this.idBJDataGridViewTextBoxColumn.DataPropertyName = "idBJ";
            this.idBJDataGridViewTextBoxColumn.HeaderText = "idBJ";
            this.idBJDataGridViewTextBoxColumn.Name = "idBJDataGridViewTextBoxColumn";
            this.idBJDataGridViewTextBoxColumn.ReadOnly = true;
            this.idBJDataGridViewTextBoxColumn.Visible = false;
            // 
            // listBajuJadiBindingSource
            // 
            this.listBajuJadiBindingSource.DataSource = typeof(Project.ListBajuJadi);
            // 
            // cboWarna
            // 
            this.cboWarna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboWarna.DataSource = this.colorBindingSource;
            this.cboWarna.DisplayMember = "ColorName";
            this.cboWarna.Enabled = false;
            this.cboWarna.FormattingEnabled = true;
            this.cboWarna.ItemHeight = 23;
            this.cboWarna.Location = new System.Drawing.Point(95, 464);
            this.cboWarna.Name = "cboWarna";
            this.cboWarna.Size = new System.Drawing.Size(184, 29);
            this.cboWarna.TabIndex = 53;
            this.cboWarna.UseSelectable = true;
            this.cboWarna.ValueMember = "ColorID";
            // 
            // txtQtyInput
            // 
            // 
            // 
            // 
            this.txtQtyInput.CustomButton.Image = null;
            this.txtQtyInput.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.txtQtyInput.CustomButton.Name = "";
            this.txtQtyInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQtyInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQtyInput.CustomButton.TabIndex = 1;
            this.txtQtyInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQtyInput.CustomButton.UseSelectable = true;
            this.txtQtyInput.CustomButton.Visible = false;
            this.txtQtyInput.Lines = new string[0];
            this.txtQtyInput.Location = new System.Drawing.Point(611, 405);
            this.txtQtyInput.MaxLength = 32767;
            this.txtQtyInput.Name = "txtQtyInput";
            this.txtQtyInput.PasswordChar = '\0';
            this.txtQtyInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQtyInput.SelectedText = "";
            this.txtQtyInput.SelectionLength = 0;
            this.txtQtyInput.SelectionStart = 0;
            this.txtQtyInput.ShortcutsEnabled = true;
            this.txtQtyInput.Size = new System.Drawing.Size(60, 23);
            this.txtQtyInput.TabIndex = 1;
            this.txtQtyInput.UseSelectable = true;
            this.txtQtyInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQtyInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMerk
            // 
            // 
            // 
            // 
            this.txtMerk.CustomButton.Image = null;
            this.txtMerk.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtMerk.CustomButton.Name = "";
            this.txtMerk.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMerk.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMerk.CustomButton.TabIndex = 1;
            this.txtMerk.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMerk.CustomButton.UseSelectable = true;
            this.txtMerk.CustomButton.Visible = false;
            this.txtMerk.Lines = new string[0];
            this.txtMerk.Location = new System.Drawing.Point(350, 405);
            this.txtMerk.MaxLength = 32767;
            this.txtMerk.Name = "txtMerk";
            this.txtMerk.PasswordChar = '\0';
            this.txtMerk.ReadOnly = true;
            this.txtMerk.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMerk.SelectedText = "";
            this.txtMerk.SelectionLength = 0;
            this.txtMerk.SelectionStart = 0;
            this.txtMerk.ShortcutsEnabled = true;
            this.txtMerk.Size = new System.Drawing.Size(171, 23);
            this.txtMerk.TabIndex = 54;
            this.txtMerk.UseSelectable = true;
            this.txtMerk.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMerk.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtModel
            // 
            // 
            // 
            // 
            this.txtModel.CustomButton.Image = null;
            this.txtModel.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtModel.CustomButton.Name = "";
            this.txtModel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtModel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtModel.CustomButton.TabIndex = 1;
            this.txtModel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtModel.CustomButton.UseSelectable = true;
            this.txtModel.CustomButton.Visible = false;
            this.txtModel.Lines = new string[0];
            this.txtModel.Location = new System.Drawing.Point(95, 429);
            this.txtModel.MaxLength = 32767;
            this.txtModel.Name = "txtModel";
            this.txtModel.PasswordChar = '\0';
            this.txtModel.ReadOnly = true;
            this.txtModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModel.SelectedText = "";
            this.txtModel.SelectionLength = 0;
            this.txtModel.SelectionStart = 0;
            this.txtModel.ShortcutsEnabled = true;
            this.txtModel.Size = new System.Drawing.Size(184, 23);
            this.txtModel.TabIndex = 52;
            this.txtModel.UseSelectable = true;
            this.txtModel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtModel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNoSeri
            // 
            // 
            // 
            // 
            this.txtNoSeri.CustomButton.Image = null;
            this.txtNoSeri.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtNoSeri.CustomButton.Name = "";
            this.txtNoSeri.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNoSeri.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNoSeri.CustomButton.TabIndex = 1;
            this.txtNoSeri.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNoSeri.CustomButton.UseSelectable = true;
            this.txtNoSeri.CustomButton.Visible = false;
            this.txtNoSeri.Lines = new string[0];
            this.txtNoSeri.Location = new System.Drawing.Point(95, 400);
            this.txtNoSeri.MaxLength = 32767;
            this.txtNoSeri.Name = "txtNoSeri";
            this.txtNoSeri.PasswordChar = '\0';
            this.txtNoSeri.ReadOnly = true;
            this.txtNoSeri.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNoSeri.SelectedText = "";
            this.txtNoSeri.SelectionLength = 0;
            this.txtNoSeri.SelectionStart = 0;
            this.txtNoSeri.ShortcutsEnabled = true;
            this.txtNoSeri.Size = new System.Drawing.Size(184, 23);
            this.txtNoSeri.TabIndex = 51;
            this.txtNoSeri.UseSelectable = true;
            this.txtNoSeri.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNoSeri.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(543, 405);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 60;
            this.metroLabel6.Text = "Quantity";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(294, 405);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 59;
            this.metroLabel4.Text = "Merk";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(33, 464);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.TabIndex = 58;
            this.metroLabel3.Text = "Warna";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(33, 429);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.TabIndex = 57;
            this.metroLabel2.Text = "Model";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 400);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 56;
            this.metroLabel1.Text = "No. Seri";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(463, 525);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 52);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(245, 525);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 52);
            this.btnExit.TabIndex = 64;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(294, 434);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 65;
            this.metroLabel5.Text = "Ukuran";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(543, 434);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(45, 19);
            this.metroLabel8.TabIndex = 66;
            this.metroLabel8.Text = "Harga";
            // 
            // txtUkuran
            // 
            // 
            // 
            // 
            this.txtUkuran.CustomButton.Image = null;
            this.txtUkuran.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.txtUkuran.CustomButton.Name = "";
            this.txtUkuran.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUkuran.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUkuran.CustomButton.TabIndex = 1;
            this.txtUkuran.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUkuran.CustomButton.UseSelectable = true;
            this.txtUkuran.CustomButton.Visible = false;
            this.txtUkuran.Lines = new string[0];
            this.txtUkuran.Location = new System.Drawing.Point(350, 434);
            this.txtUkuran.MaxLength = 32767;
            this.txtUkuran.Name = "txtUkuran";
            this.txtUkuran.PasswordChar = '\0';
            this.txtUkuran.ReadOnly = true;
            this.txtUkuran.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUkuran.SelectedText = "";
            this.txtUkuran.SelectionLength = 0;
            this.txtUkuran.SelectionStart = 0;
            this.txtUkuran.ShortcutsEnabled = true;
            this.txtUkuran.Size = new System.Drawing.Size(171, 23);
            this.txtUkuran.TabIndex = 67;
            this.txtUkuran.UseSelectable = true;
            this.txtUkuran.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUkuran.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtHargaInput
            // 
            // 
            // 
            // 
            this.txtHargaInput.CustomButton.Image = null;
            this.txtHargaInput.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtHargaInput.CustomButton.Name = "";
            this.txtHargaInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHargaInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHargaInput.CustomButton.TabIndex = 1;
            this.txtHargaInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHargaInput.CustomButton.UseSelectable = true;
            this.txtHargaInput.CustomButton.Visible = false;
            this.txtHargaInput.Lines = new string[0];
            this.txtHargaInput.Location = new System.Drawing.Point(611, 434);
            this.txtHargaInput.MaxLength = 32767;
            this.txtHargaInput.Name = "txtHargaInput";
            this.txtHargaInput.PasswordChar = '\0';
            this.txtHargaInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHargaInput.SelectedText = "";
            this.txtHargaInput.SelectionLength = 0;
            this.txtHargaInput.SelectionStart = 0;
            this.txtHargaInput.ShortcutsEnabled = true;
            this.txtHargaInput.Size = new System.Drawing.Size(161, 23);
            this.txtHargaInput.TabIndex = 2;
            this.txtHargaInput.UseSelectable = true;
            this.txtHargaInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHargaInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(674, 406);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(28, 19);
            this.metroLabel9.TabIndex = 69;
            this.metroLabel9.Text = "pcs";
            // 
            // AddPenjualanBaju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 600);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtHargaInput);
            this.Controls.Add(this.txtUkuran);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboWarna);
            this.Controls.Add(this.txtQtyInput);
            this.Controls.Add(this.txtMerk);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtNoSeri);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddPenjualanBaju";
            this.Text = "Add Penjualan Baju";
            this.Load += new System.EventHandler(this.AddPenjualanBaju_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBajuJadiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroComboBox cboWarna;
        private MetroFramework.Controls.MetroTextBox txtQtyInput;
        private MetroFramework.Controls.MetroTextBox txtMerk;
        private MetroFramework.Controls.MetroTextBox txtModel;
        private MetroFramework.Controls.MetroTextBox txtNoSeri;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtUkuran;
        private MetroFramework.Controls.MetroTextBox txtHargaInput;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn colorIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn merkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukuranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBJDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listBajuJadiBindingSource;
    }
}