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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPKBordir));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNoSpkBordir = new MetroFramework.Controls.MetroTextBox();
            this.cboPICBordir = new MetroFramework.Controls.MetroComboBox();
            this.txtPicCodeBordir = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.btnSaveSPKBordir = new MetroFramework.Controls.MetroButton();
            this.btnExitSPKBordir = new MetroFramework.Controls.MetroButton();
            this.btnDeleteSPKBordir = new MetroFramework.Controls.MetroTile();
            this.btnAddSPKBordir = new MetroFramework.Controls.MetroTile();
            this.listPenerimaanTukangPotongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idListPTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPenerimaanTukangPotongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukuranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusSPKSablonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusSPKBordirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusSPKCMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusNoSeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSPKSablonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSPKBordirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSPKCMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPenerimaanTukangPotongBindingSource)).BeginInit();
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
            this.idPenerimaanTukangPotongDataGridViewTextBoxColumn,
            this.noSeriDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.colorIDDataGridViewTextBoxColumn,
            this.merkDataGridViewTextBoxColumn,
            this.ukuranDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.statusSPKSablonDataGridViewTextBoxColumn,
            this.statusSPKBordirDataGridViewTextBoxColumn,
            this.statusSPKCMTDataGridViewTextBoxColumn,
            this.statusNoSeriDataGridViewTextBoxColumn,
            this.idSPKSablonDataGridViewTextBoxColumn,
            this.idSPKBordirDataGridViewTextBoxColumn,
            this.idSPKCMTDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.listPenerimaanTukangPotongBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(651, 217);
            this.dataGridView1.TabIndex = 15;
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
            this.cboPICBordir.FormattingEnabled = true;
            this.cboPICBordir.ItemHeight = 23;
            this.cboPICBordir.Location = new System.Drawing.Point(157, 115);
            this.cboPICBordir.Name = "cboPICBordir";
            this.cboPICBordir.Size = new System.Drawing.Size(181, 29);
            this.cboPICBordir.TabIndex = 26;
            this.cboPICBordir.UseSelectable = true;
            this.cboPICBordir.SelectedIndexChanged += new System.EventHandler(this.cboPICBordir_SelectedIndexChanged);
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
            this.metroLabel4.Location = new System.Drawing.Point(395, 52);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(36, 19);
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "Date";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(449, 52);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(236, 29);
            this.metroDateTime1.TabIndex = 29;
            // 
            // btnSaveSPKBordir
            // 
            this.btnSaveSPKBordir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSPKBordir.Location = new System.Drawing.Point(374, 506);
            this.btnSaveSPKBordir.Name = "btnSaveSPKBordir";
            this.btnSaveSPKBordir.Size = new System.Drawing.Size(116, 50);
            this.btnSaveSPKBordir.TabIndex = 30;
            this.btnSaveSPKBordir.Text = "SAVE";
            this.btnSaveSPKBordir.UseSelectable = true;
            // 
            // btnExitSPKBordir
            // 
            this.btnExitSPKBordir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitSPKBordir.Location = new System.Drawing.Point(231, 506);
            this.btnExitSPKBordir.Name = "btnExitSPKBordir";
            this.btnExitSPKBordir.Size = new System.Drawing.Size(107, 50);
            this.btnExitSPKBordir.TabIndex = 31;
            this.btnExitSPKBordir.Text = "EXIT";
            this.btnExitSPKBordir.UseSelectable = true;
            // 
            // btnDeleteSPKBordir
            // 
            this.btnDeleteSPKBordir.ActiveControl = null;
            this.btnDeleteSPKBordir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSPKBordir.Location = new System.Drawing.Point(134, 418);
            this.btnDeleteSPKBordir.Name = "btnDeleteSPKBordir";
            this.btnDeleteSPKBordir.Size = new System.Drawing.Size(87, 67);
            this.btnDeleteSPKBordir.TabIndex = 33;
            this.btnDeleteSPKBordir.Text = "DELETE";
            this.btnDeleteSPKBordir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteSPKBordir.TileImage = global::Project.Properties.Resources.btn_delete;
            this.btnDeleteSPKBordir.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteSPKBordir.UseSelectable = true;
            this.btnDeleteSPKBordir.UseTileImage = true;
            // 
            // btnAddSPKBordir
            // 
            this.btnAddSPKBordir.ActiveControl = null;
            this.btnAddSPKBordir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSPKBordir.Location = new System.Drawing.Point(34, 418);
            this.btnAddSPKBordir.Name = "btnAddSPKBordir";
            this.btnAddSPKBordir.Size = new System.Drawing.Size(85, 67);
            this.btnAddSPKBordir.TabIndex = 32;
            this.btnAddSPKBordir.Text = "ADD";
            this.btnAddSPKBordir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSPKBordir.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddSPKBordir.TileImage")));
            this.btnAddSPKBordir.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSPKBordir.UseSelectable = true;
            this.btnAddSPKBordir.UseTileImage = true;
            // 
            // listPenerimaanTukangPotongBindingSource
            // 
            this.listPenerimaanTukangPotongBindingSource.DataSource = typeof(Project.ListPenerimaanTukangPotong);
            // 
            // idListPTPDataGridViewTextBoxColumn
            // 
            this.idListPTPDataGridViewTextBoxColumn.DataPropertyName = "idListPTP";
            this.idListPTPDataGridViewTextBoxColumn.HeaderText = "idListPTP";
            this.idListPTPDataGridViewTextBoxColumn.Name = "idListPTPDataGridViewTextBoxColumn";
            this.idListPTPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPenerimaanTukangPotongDataGridViewTextBoxColumn
            // 
            this.idPenerimaanTukangPotongDataGridViewTextBoxColumn.DataPropertyName = "idPenerimaanTukangPotong";
            this.idPenerimaanTukangPotongDataGridViewTextBoxColumn.HeaderText = "idPenerimaanTukangPotong";
            this.idPenerimaanTukangPotongDataGridViewTextBoxColumn.Name = "idPenerimaanTukangPotongDataGridViewTextBoxColumn";
            this.idPenerimaanTukangPotongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noSeriDataGridViewTextBoxColumn
            // 
            this.noSeriDataGridViewTextBoxColumn.DataPropertyName = "noSeri";
            this.noSeriDataGridViewTextBoxColumn.HeaderText = "noSeri";
            this.noSeriDataGridViewTextBoxColumn.Name = "noSeriDataGridViewTextBoxColumn";
            this.noSeriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorIDDataGridViewTextBoxColumn
            // 
            this.colorIDDataGridViewTextBoxColumn.DataPropertyName = "ColorID";
            this.colorIDDataGridViewTextBoxColumn.HeaderText = "ColorID";
            this.colorIDDataGridViewTextBoxColumn.Name = "colorIDDataGridViewTextBoxColumn";
            this.colorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // merkDataGridViewTextBoxColumn
            // 
            this.merkDataGridViewTextBoxColumn.DataPropertyName = "merk";
            this.merkDataGridViewTextBoxColumn.HeaderText = "merk";
            this.merkDataGridViewTextBoxColumn.Name = "merkDataGridViewTextBoxColumn";
            this.merkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ukuranDataGridViewTextBoxColumn
            // 
            this.ukuranDataGridViewTextBoxColumn.DataPropertyName = "ukuran";
            this.ukuranDataGridViewTextBoxColumn.HeaderText = "ukuran";
            this.ukuranDataGridViewTextBoxColumn.Name = "ukuranDataGridViewTextBoxColumn";
            this.ukuranDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusSPKSablonDataGridViewTextBoxColumn
            // 
            this.statusSPKSablonDataGridViewTextBoxColumn.DataPropertyName = "statusSPKSablon";
            this.statusSPKSablonDataGridViewTextBoxColumn.HeaderText = "statusSPKSablon";
            this.statusSPKSablonDataGridViewTextBoxColumn.Name = "statusSPKSablonDataGridViewTextBoxColumn";
            this.statusSPKSablonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusSPKBordirDataGridViewTextBoxColumn
            // 
            this.statusSPKBordirDataGridViewTextBoxColumn.DataPropertyName = "statusSPKBordir";
            this.statusSPKBordirDataGridViewTextBoxColumn.HeaderText = "statusSPKBordir";
            this.statusSPKBordirDataGridViewTextBoxColumn.Name = "statusSPKBordirDataGridViewTextBoxColumn";
            this.statusSPKBordirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusSPKCMTDataGridViewTextBoxColumn
            // 
            this.statusSPKCMTDataGridViewTextBoxColumn.DataPropertyName = "statusSPKCMT";
            this.statusSPKCMTDataGridViewTextBoxColumn.HeaderText = "statusSPKCMT";
            this.statusSPKCMTDataGridViewTextBoxColumn.Name = "statusSPKCMTDataGridViewTextBoxColumn";
            this.statusSPKCMTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusNoSeriDataGridViewTextBoxColumn
            // 
            this.statusNoSeriDataGridViewTextBoxColumn.DataPropertyName = "statusNoSeri";
            this.statusNoSeriDataGridViewTextBoxColumn.HeaderText = "statusNoSeri";
            this.statusNoSeriDataGridViewTextBoxColumn.Name = "statusNoSeriDataGridViewTextBoxColumn";
            this.statusNoSeriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSPKSablonDataGridViewTextBoxColumn
            // 
            this.idSPKSablonDataGridViewTextBoxColumn.DataPropertyName = "idSPKSablon";
            this.idSPKSablonDataGridViewTextBoxColumn.HeaderText = "idSPKSablon";
            this.idSPKSablonDataGridViewTextBoxColumn.Name = "idSPKSablonDataGridViewTextBoxColumn";
            this.idSPKSablonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSPKBordirDataGridViewTextBoxColumn
            // 
            this.idSPKBordirDataGridViewTextBoxColumn.DataPropertyName = "idSPKBordir";
            this.idSPKBordirDataGridViewTextBoxColumn.HeaderText = "idSPKBordir";
            this.idSPKBordirDataGridViewTextBoxColumn.Name = "idSPKBordirDataGridViewTextBoxColumn";
            this.idSPKBordirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSPKCMTDataGridViewTextBoxColumn
            // 
            this.idSPKCMTDataGridViewTextBoxColumn.DataPropertyName = "idSPKCMT";
            this.idSPKCMTDataGridViewTextBoxColumn.HeaderText = "idSPKCMT";
            this.idSPKCMTDataGridViewTextBoxColumn.Name = "idSPKCMTDataGridViewTextBoxColumn";
            this.idSPKCMTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SPKBordir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 579);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPenerimaanTukangPotongBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idListPTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPenerimaanTukangPotongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukuranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusSPKSablonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusSPKBordirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusSPKCMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusNoSeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSPKSablonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSPKBordirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSPKCMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listPenerimaanTukangPotongBindingSource;
    }
}