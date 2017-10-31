namespace Project
{
    partial class Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier));
            this.btnSaveSup = new MetroFramework.Controls.MetroTile();
            this.btnDeleteSup = new MetroFramework.Controls.MetroTile();
            this.btnEditSup = new MetroFramework.Controls.MetroTile();
            this.btnAddSup = new MetroFramework.Controls.MetroTile();
            this.btnRefreshSup = new MetroFramework.Controls.MetroTile();
            this.supplierDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveSup
            // 
            this.btnSaveSup.ActiveControl = null;
            this.btnSaveSup.Location = new System.Drawing.Point(461, 82);
            this.btnSaveSup.Name = "btnSaveSup";
            this.btnSaveSup.Size = new System.Drawing.Size(88, 67);
            this.btnSaveSup.TabIndex = 17;
            this.btnSaveSup.Text = "SAVE";
            this.btnSaveSup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveSup.TileImage = global::Project.Properties.Resources.btn_save;
            this.btnSaveSup.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveSup.UseSelectable = true;
            this.btnSaveSup.UseTileImage = true;
            this.btnSaveSup.Click += new System.EventHandler(this.btnSaveSup_Click);
            // 
            // btnDeleteSup
            // 
            this.btnDeleteSup.ActiveControl = null;
            this.btnDeleteSup.Location = new System.Drawing.Point(354, 82);
            this.btnDeleteSup.Name = "btnDeleteSup";
            this.btnDeleteSup.Size = new System.Drawing.Size(87, 67);
            this.btnDeleteSup.TabIndex = 16;
            this.btnDeleteSup.Text = "DELETE";
            this.btnDeleteSup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteSup.TileImage = global::Project.Properties.Resources.btn_delete;
            this.btnDeleteSup.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteSup.UseSelectable = true;
            this.btnDeleteSup.UseTileImage = true;
            this.btnDeleteSup.Click += new System.EventHandler(this.btnDeleteSup_Click);
            // 
            // btnEditSup
            // 
            this.btnEditSup.ActiveControl = null;
            this.btnEditSup.Location = new System.Drawing.Point(247, 82);
            this.btnEditSup.Name = "btnEditSup";
            this.btnEditSup.Size = new System.Drawing.Size(87, 67);
            this.btnEditSup.TabIndex = 15;
            this.btnEditSup.Text = "EDIT";
            this.btnEditSup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditSup.TileImage = global::Project.Properties.Resources.btn_pencil;
            this.btnEditSup.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditSup.UseSelectable = true;
            this.btnEditSup.UseTileImage = true;
            this.btnEditSup.Click += new System.EventHandler(this.btnEditSup_Click);
            // 
            // btnAddSup
            // 
            this.btnAddSup.ActiveControl = null;
            this.btnAddSup.Location = new System.Drawing.Point(143, 82);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(85, 67);
            this.btnAddSup.TabIndex = 14;
            this.btnAddSup.Text = "ADD";
            this.btnAddSup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSup.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddSup.TileImage")));
            this.btnAddSup.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSup.UseSelectable = true;
            this.btnAddSup.UseTileImage = true;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click);
            // 
            // btnRefreshSup
            // 
            this.btnRefreshSup.ActiveControl = null;
            this.btnRefreshSup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshSup.Location = new System.Drawing.Point(40, 82);
            this.btnRefreshSup.Name = "btnRefreshSup";
            this.btnRefreshSup.Size = new System.Drawing.Size(85, 67);
            this.btnRefreshSup.TabIndex = 13;
            this.btnRefreshSup.Text = "REFRESH";
            this.btnRefreshSup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefreshSup.TileImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshSup.TileImage")));
            this.btnRefreshSup.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefreshSup.UseSelectable = true;
            this.btnRefreshSup.UseTileImage = true;
            this.btnRefreshSup.Click += new System.EventHandler(this.btnRefreshSup_Click);
            // 
            // supplierDataGrid
            // 
            this.supplierDataGrid.AllowUserToAddRows = false;
            this.supplierDataGrid.AllowUserToDeleteRows = false;
            this.supplierDataGrid.AutoGenerateColumns = false;
            this.supplierDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.supplierDataGrid.DataSource = this.supplierBindingSource;
            this.supplierDataGrid.Location = new System.Drawing.Point(40, 165);
            this.supplierDataGrid.Name = "supplierDataGrid";
            this.supplierDataGrid.ReadOnly = true;
            this.supplierDataGrid.Size = new System.Drawing.Size(592, 207);
            this.supplierDataGrid.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SupplierID";
            this.dataGridViewTextBoxColumn1.HeaderText = "SupplierID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SupplierCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "SupplierCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SupplierName";
            this.dataGridViewTextBoxColumn3.HeaderText = "SupplierName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SupplierAddress";
            this.dataGridViewTextBoxColumn4.HeaderText = "SupplierAddress";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SupplierPhone";
            this.dataGridViewTextBoxColumn5.HeaderText = "SupplierPhone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(Project.IndomodaSupplier);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 406);
            this.Controls.Add(this.btnSaveSup);
            this.Controls.Add(this.btnDeleteSup);
            this.Controls.Add(this.btnEditSup);
            this.Controls.Add(this.btnAddSup);
            this.Controls.Add(this.btnRefreshSup);
            this.Controls.Add(this.supplierDataGrid);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnSaveSup;
        private MetroFramework.Controls.MetroTile btnDeleteSup;
        private MetroFramework.Controls.MetroTile btnEditSup;
        private MetroFramework.Controls.MetroTile btnAddSup;
        private MetroFramework.Controls.MetroTile btnRefreshSup;
        private System.Windows.Forms.DataGridView supplierDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}