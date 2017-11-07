namespace Project
{
    partial class PenerimaanKain
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
            this.detailPOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pONumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.detailPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtNoFaktur = new MetroFramework.Controls.MetroTextBox();
            this.cboNoPOKain = new MetroFramework.Controls.MetroComboBox();
            this.preOrderKainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSupplierName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnDeletePenerimaanKain = new MetroFramework.Controls.MetroTile();
            this.btnExitPenerimaanKain = new MetroFramework.Controls.MetroButton();
            this.btnUpdateStatus = new MetroFramework.Controls.MetroTile();
            this.txtSupplierCode = new MetroFramework.Controls.MetroTextBox();
            this.btnSaveUpdateStatus = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preOrderKainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detailPOIDDataGridViewTextBoxColumn,
            this.pONumberDataGridViewTextBoxColumn,
            this.materialIDDataGridViewComboBoxColumn,
            this.colorIDDataGridViewComboBoxColumn,
            this.detailQtyDataGridViewTextBoxColumn,
            this.detailPriceDataGridViewTextBoxColumn,
            this.detailStatusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.detailPOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 177);
            this.dataGridView1.TabIndex = 1;
            // 
            // detailPOIDDataGridViewTextBoxColumn
            // 
            this.detailPOIDDataGridViewTextBoxColumn.DataPropertyName = "DetailPOID";
            this.detailPOIDDataGridViewTextBoxColumn.HeaderText = "No.";
            this.detailPOIDDataGridViewTextBoxColumn.Name = "detailPOIDDataGridViewTextBoxColumn";
            this.detailPOIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // pONumberDataGridViewTextBoxColumn
            // 
            this.pONumberDataGridViewTextBoxColumn.DataPropertyName = "PONumber";
            this.pONumberDataGridViewTextBoxColumn.HeaderText = "No. PO";
            this.pONumberDataGridViewTextBoxColumn.Name = "pONumberDataGridViewTextBoxColumn";
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
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(Project.Material);
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
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(Project.Color);
            // 
            // detailQtyDataGridViewTextBoxColumn
            // 
            this.detailQtyDataGridViewTextBoxColumn.DataPropertyName = "DetailQty";
            this.detailQtyDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.detailQtyDataGridViewTextBoxColumn.Name = "detailQtyDataGridViewTextBoxColumn";
            this.detailQtyDataGridViewTextBoxColumn.Width = 80;
            // 
            // detailPriceDataGridViewTextBoxColumn
            // 
            this.detailPriceDataGridViewTextBoxColumn.DataPropertyName = "DetailPrice";
            this.detailPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.detailPriceDataGridViewTextBoxColumn.Name = "detailPriceDataGridViewTextBoxColumn";
            this.detailPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailStatusDataGridViewCheckBoxColumn
            // 
            this.detailStatusDataGridViewCheckBoxColumn.DataPropertyName = "DetailStatus";
            this.detailStatusDataGridViewCheckBoxColumn.FalseValue = "false";
            this.detailStatusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.detailStatusDataGridViewCheckBoxColumn.IndeterminateValue = "";
            this.detailStatusDataGridViewCheckBoxColumn.Name = "detailStatusDataGridViewCheckBoxColumn";
            this.detailStatusDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detailStatusDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.detailStatusDataGridViewCheckBoxColumn.TrueValue = "true";
            this.detailStatusDataGridViewCheckBoxColumn.Width = 60;
            // 
            // detailPOBindingSource
            // 
            this.detailPOBindingSource.DataSource = typeof(Project.DetailPO);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(467, 48);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(213, 29);
            this.metroDateTime1.TabIndex = 14;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "No. Faktur";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "No. PO";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(37, 173);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Supplier Code";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(37, 217);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Supplier Name";
            // 
            // txtNoFaktur
            // 
            // 
            // 
            // 
            this.txtNoFaktur.CustomButton.Image = null;
            this.txtNoFaktur.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtNoFaktur.CustomButton.Name = "";
            this.txtNoFaktur.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNoFaktur.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNoFaktur.CustomButton.TabIndex = 1;
            this.txtNoFaktur.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNoFaktur.CustomButton.UseSelectable = true;
            this.txtNoFaktur.CustomButton.Visible = false;
            this.txtNoFaktur.Lines = new string[0];
            this.txtNoFaktur.Location = new System.Drawing.Point(163, 89);
            this.txtNoFaktur.MaxLength = 32767;
            this.txtNoFaktur.Name = "txtNoFaktur";
            this.txtNoFaktur.PasswordChar = '\0';
            this.txtNoFaktur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNoFaktur.SelectedText = "";
            this.txtNoFaktur.SelectionLength = 0;
            this.txtNoFaktur.SelectionStart = 0;
            this.txtNoFaktur.ShortcutsEnabled = true;
            this.txtNoFaktur.Size = new System.Drawing.Size(174, 23);
            this.txtNoFaktur.TabIndex = 1;
            this.txtNoFaktur.UseSelectable = true;
            this.txtNoFaktur.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNoFaktur.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboNoPOKain
            // 
            this.cboNoPOKain.DataSource = this.preOrderKainBindingSource;
            this.cboNoPOKain.DisplayMember = "PONumber";
            this.cboNoPOKain.FormattingEnabled = true;
            this.cboNoPOKain.ItemHeight = 23;
            this.cboNoPOKain.Location = new System.Drawing.Point(163, 125);
            this.cboNoPOKain.Name = "cboNoPOKain";
            this.cboNoPOKain.Size = new System.Drawing.Size(174, 29);
            this.cboNoPOKain.TabIndex = 2;
            this.cboNoPOKain.UseSelectable = true;
            this.cboNoPOKain.ValueMember = "PONumber";
            this.cboNoPOKain.SelectedIndexChanged += new System.EventHandler(this.cboNoPOKain_SelectedIndexChanged);
            // 
            // preOrderKainBindingSource
            // 
            // 
            // txtSupplierName
            // 
            // 
            // 
            // 
            this.txtSupplierName.CustomButton.Image = null;
            this.txtSupplierName.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtSupplierName.CustomButton.Name = "";
            this.txtSupplierName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSupplierName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierName.CustomButton.TabIndex = 1;
            this.txtSupplierName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplierName.CustomButton.UseSelectable = true;
            this.txtSupplierName.CustomButton.Visible = false;
            this.txtSupplierName.Lines = new string[0];
            this.txtSupplierName.Location = new System.Drawing.Point(163, 217);
            this.txtSupplierName.MaxLength = 32767;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.PasswordChar = '\0';
            this.txtSupplierName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplierName.SelectedText = "";
            this.txtSupplierName.SelectionLength = 0;
            this.txtSupplierName.SelectionStart = 0;
            this.txtSupplierName.ShortcutsEnabled = true;
            this.txtSupplierName.Size = new System.Drawing.Size(174, 23);
            this.txtSupplierName.TabIndex = 4;
            this.txtSupplierName.UseSelectable = true;
            this.txtSupplierName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplierName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(414, 48);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(36, 19);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Date";
            // 
            // btnDeletePenerimaanKain
            // 
            this.btnDeletePenerimaanKain.ActiveControl = null;
            this.btnDeletePenerimaanKain.Location = new System.Drawing.Point(37, 448);
            this.btnDeletePenerimaanKain.Name = "btnDeletePenerimaanKain";
            this.btnDeletePenerimaanKain.Size = new System.Drawing.Size(87, 67);
            this.btnDeletePenerimaanKain.TabIndex = 7;
            this.btnDeletePenerimaanKain.Text = "DELETE";
            this.btnDeletePenerimaanKain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletePenerimaanKain.TileImage = global::Project.Properties.Resources.btn_delete;
            this.btnDeletePenerimaanKain.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletePenerimaanKain.UseSelectable = true;
            this.btnDeletePenerimaanKain.UseTileImage = true;
            this.btnDeletePenerimaanKain.Click += new System.EventHandler(this.btnDeletePenerimaanKain_Click);
            // 
            // btnExitPenerimaanKain
            // 
            this.btnExitPenerimaanKain.Location = new System.Drawing.Point(203, 549);
            this.btnExitPenerimaanKain.Name = "btnExitPenerimaanKain";
            this.btnExitPenerimaanKain.Size = new System.Drawing.Size(110, 48);
            this.btnExitPenerimaanKain.TabIndex = 9;
            this.btnExitPenerimaanKain.Text = "EXIT";
            this.btnExitPenerimaanKain.UseSelectable = true;
            this.btnExitPenerimaanKain.Click += new System.EventHandler(this.btnExitPenerimaanKain_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.ActiveControl = null;
            this.btnUpdateStatus.Location = new System.Drawing.Point(130, 448);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(183, 67);
            this.btnUpdateStatus.TabIndex = 24;
            this.btnUpdateStatus.Text = "UPDATE DETAIL PO STATUS";
            this.btnUpdateStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateStatus.TileImage = global::Project.Properties.Resources.btn_save;
            this.btnUpdateStatus.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateStatus.UseSelectable = true;
            this.btnUpdateStatus.UseTileImage = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // txtSupplierCode
            // 
            // 
            // 
            // 
            this.txtSupplierCode.CustomButton.Image = null;
            this.txtSupplierCode.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.txtSupplierCode.CustomButton.Name = "";
            this.txtSupplierCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSupplierCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierCode.CustomButton.TabIndex = 1;
            this.txtSupplierCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplierCode.CustomButton.UseSelectable = true;
            this.txtSupplierCode.CustomButton.Visible = false;
            this.txtSupplierCode.Lines = new string[0];
            this.txtSupplierCode.Location = new System.Drawing.Point(163, 173);
            this.txtSupplierCode.MaxLength = 32767;
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.PasswordChar = '\0';
            this.txtSupplierCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplierCode.SelectedText = "";
            this.txtSupplierCode.SelectionLength = 0;
            this.txtSupplierCode.SelectionStart = 0;
            this.txtSupplierCode.ShortcutsEnabled = true;
            this.txtSupplierCode.Size = new System.Drawing.Size(174, 23);
            this.txtSupplierCode.TabIndex = 25;
            this.txtSupplierCode.UseSelectable = true;
            this.txtSupplierCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplierCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSaveUpdateStatus
            // 
            this.btnSaveUpdateStatus.Location = new System.Drawing.Point(385, 549);
            this.btnSaveUpdateStatus.Name = "btnSaveUpdateStatus";
            this.btnSaveUpdateStatus.Size = new System.Drawing.Size(151, 48);
            this.btnSaveUpdateStatus.TabIndex = 26;
            this.btnSaveUpdateStatus.Text = "Save and Mark PO Done";
            this.btnSaveUpdateStatus.UseSelectable = true;
            this.btnSaveUpdateStatus.Click += new System.EventHandler(this.btnSaveUpdateStatus_Click);
            // 
            // PenerimaanKain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 644);
            this.Controls.Add(this.btnSaveUpdateStatus);
            this.Controls.Add(this.txtSupplierCode);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.btnExitPenerimaanKain);
            this.Controls.Add(this.btnDeletePenerimaanKain);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.cboNoPOKain);
            this.Controls.Add(this.txtNoFaktur);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PenerimaanKain";
            this.Text = "Penerimaan Kain";
            this.Load += new System.EventHandler(this.PenerimaanKain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preOrderKainBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtNoFaktur;
        private MetroFramework.Controls.MetroComboBox cboNoPOKain;
        private MetroFramework.Controls.MetroTextBox txtSupplierName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile btnDeletePenerimaanKain;
        private MetroFramework.Controls.MetroButton btnExitPenerimaanKain;
        private System.Windows.Forms.BindingSource detailPOBindingSource;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private MetroFramework.Controls.MetroTile btnUpdateStatus;
        private MetroFramework.Controls.MetroTextBox txtSupplierCode;
        private System.Windows.Forms.BindingSource preOrderKainBindingSource;
        private MetroFramework.Controls.MetroButton btnSaveUpdateStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailPOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pONumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn materialIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn colorIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn detailStatusDataGridViewCheckBoxColumn;
    }
}