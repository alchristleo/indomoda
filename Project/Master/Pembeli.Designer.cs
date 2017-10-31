namespace Project
{
    partial class Pembeli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pembeli));
            this.customerDataGrid = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveCust = new MetroFramework.Controls.MetroTile();
            this.btnDeleteCust = new MetroFramework.Controls.MetroTile();
            this.btnEditCust = new MetroFramework.Controls.MetroTile();
            this.btnAddCust = new MetroFramework.Controls.MetroTile();
            this.btnRefreshCust = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDataGrid
            // 
            this.customerDataGrid.AllowUserToAddRows = false;
            this.customerDataGrid.AllowUserToDeleteRows = false;
            this.customerDataGrid.AutoGenerateColumns = false;
            this.customerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerCodeDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn});
            this.customerDataGrid.DataSource = this.customerBindingSource;
            this.customerDataGrid.Location = new System.Drawing.Point(43, 180);
            this.customerDataGrid.Name = "customerDataGrid";
            this.customerDataGrid.ReadOnly = true;
            this.customerDataGrid.Size = new System.Drawing.Size(592, 207);
            this.customerDataGrid.TabIndex = 0;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerCodeDataGridViewTextBoxColumn
            // 
            this.customerCodeDataGridViewTextBoxColumn.DataPropertyName = "CustomerCode";
            this.customerCodeDataGridViewTextBoxColumn.HeaderText = "CustomerCode";
            this.customerCodeDataGridViewTextBoxColumn.Name = "customerCodeDataGridViewTextBoxColumn";
            this.customerCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            this.customerAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerPhoneDataGridViewTextBoxColumn
            // 
            this.customerPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhone";
            this.customerPhoneDataGridViewTextBoxColumn.HeaderText = "CustomerPhone";
            this.customerPhoneDataGridViewTextBoxColumn.Name = "customerPhoneDataGridViewTextBoxColumn";
            this.customerPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Project.Customer);
            // 
            // btnSaveCust
            // 
            this.btnSaveCust.ActiveControl = null;
            this.btnSaveCust.Location = new System.Drawing.Point(464, 97);
            this.btnSaveCust.Name = "btnSaveCust";
            this.btnSaveCust.Size = new System.Drawing.Size(88, 67);
            this.btnSaveCust.TabIndex = 11;
            this.btnSaveCust.Text = "SAVE";
            this.btnSaveCust.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveCust.TileImage = global::Project.Properties.Resources.btn_save;
            this.btnSaveCust.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveCust.UseSelectable = true;
            this.btnSaveCust.UseTileImage = true;
            this.btnSaveCust.Click += new System.EventHandler(this.btnSaveCust_Click);
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.ActiveControl = null;
            this.btnDeleteCust.Location = new System.Drawing.Point(357, 97);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(87, 67);
            this.btnDeleteCust.TabIndex = 10;
            this.btnDeleteCust.Text = "DELETE";
            this.btnDeleteCust.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteCust.TileImage = global::Project.Properties.Resources.btn_delete;
            this.btnDeleteCust.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteCust.UseSelectable = true;
            this.btnDeleteCust.UseTileImage = true;
            this.btnDeleteCust.Click += new System.EventHandler(this.btnDeleteCust_Click);
            // 
            // btnEditCust
            // 
            this.btnEditCust.ActiveControl = null;
            this.btnEditCust.Location = new System.Drawing.Point(250, 97);
            this.btnEditCust.Name = "btnEditCust";
            this.btnEditCust.Size = new System.Drawing.Size(87, 67);
            this.btnEditCust.TabIndex = 9;
            this.btnEditCust.Text = "EDIT";
            this.btnEditCust.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditCust.TileImage = global::Project.Properties.Resources.btn_pencil;
            this.btnEditCust.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditCust.UseSelectable = true;
            this.btnEditCust.UseTileImage = true;
            this.btnEditCust.Click += new System.EventHandler(this.btnEditCust_Click);
            // 
            // btnAddCust
            // 
            this.btnAddCust.ActiveControl = null;
            this.btnAddCust.Location = new System.Drawing.Point(146, 97);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(85, 67);
            this.btnAddCust.TabIndex = 8;
            this.btnAddCust.Text = "ADD";
            this.btnAddCust.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCust.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddCust.TileImage")));
            this.btnAddCust.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCust.UseSelectable = true;
            this.btnAddCust.UseTileImage = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // btnRefreshCust
            // 
            this.btnRefreshCust.ActiveControl = null;
            this.btnRefreshCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshCust.Location = new System.Drawing.Point(43, 97);
            this.btnRefreshCust.Name = "btnRefreshCust";
            this.btnRefreshCust.Size = new System.Drawing.Size(85, 67);
            this.btnRefreshCust.TabIndex = 7;
            this.btnRefreshCust.Text = "REFRESH";
            this.btnRefreshCust.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefreshCust.TileImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshCust.TileImage")));
            this.btnRefreshCust.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefreshCust.UseSelectable = true;
            this.btnRefreshCust.UseTileImage = true;
            this.btnRefreshCust.Click += new System.EventHandler(this.btnRefreshCust_Click);
            // 
            // Pembeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 424);
            this.Controls.Add(this.btnSaveCust);
            this.Controls.Add(this.btnDeleteCust);
            this.Controls.Add(this.btnEditCust);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.btnRefreshCust);
            this.Controls.Add(this.customerDataGrid);
            this.Name = "Pembeli";
            this.Text = "Pembeli";
            this.Load += new System.EventHandler(this.Pembeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDataGrid;
        private MetroFramework.Controls.MetroTile btnSaveCust;
        private MetroFramework.Controls.MetroTile btnDeleteCust;
        private MetroFramework.Controls.MetroTile btnEditCust;
        private MetroFramework.Controls.MetroTile btnAddCust;
        private MetroFramework.Controls.MetroTile btnRefreshCust;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
    }
}