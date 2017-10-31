namespace Project
{
    partial class MasterBahan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterBahan));
            this.dataGridBahan = new System.Windows.Forms.DataGridView();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveBahan = new MetroFramework.Controls.MetroTile();
            this.btnDeleteBahan = new MetroFramework.Controls.MetroTile();
            this.btnEditBahan = new MetroFramework.Controls.MetroTile();
            this.btnAddBahan = new MetroFramework.Controls.MetroTile();
            this.btnRefreshBahan = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBahan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBahan
            // 
            this.dataGridBahan.AllowUserToAddRows = false;
            this.dataGridBahan.AllowUserToDeleteRows = false;
            this.dataGridBahan.AutoGenerateColumns = false;
            this.dataGridBahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBahan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialIDDataGridViewTextBoxColumn,
            this.materialCodeDataGridViewTextBoxColumn,
            this.materialNameDataGridViewTextBoxColumn});
            this.dataGridBahan.DataSource = this.materialBindingSource;
            this.dataGridBahan.Location = new System.Drawing.Point(47, 165);
            this.dataGridBahan.Name = "dataGridBahan";
            this.dataGridBahan.ReadOnly = true;
            this.dataGridBahan.Size = new System.Drawing.Size(536, 192);
            this.dataGridBahan.TabIndex = 0;
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialCodeDataGridViewTextBoxColumn
            // 
            this.materialCodeDataGridViewTextBoxColumn.DataPropertyName = "MaterialCode";
            this.materialCodeDataGridViewTextBoxColumn.HeaderText = "MaterialCode";
            this.materialCodeDataGridViewTextBoxColumn.Name = "materialCodeDataGridViewTextBoxColumn";
            this.materialCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialNameDataGridViewTextBoxColumn
            // 
            this.materialNameDataGridViewTextBoxColumn.DataPropertyName = "MaterialName";
            this.materialNameDataGridViewTextBoxColumn.HeaderText = "MaterialName";
            this.materialNameDataGridViewTextBoxColumn.Name = "materialNameDataGridViewTextBoxColumn";
            this.materialNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(Project.Material);
            // 
            // btnSaveBahan
            // 
            this.btnSaveBahan.ActiveControl = null;
            this.btnSaveBahan.Location = new System.Drawing.Point(458, 92);
            this.btnSaveBahan.Name = "btnSaveBahan";
            this.btnSaveBahan.Size = new System.Drawing.Size(88, 67);
            this.btnSaveBahan.TabIndex = 10;
            this.btnSaveBahan.Text = "SAVE";
            this.btnSaveBahan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveBahan.TileImage = global::Project.Properties.Resources.btn_save;
            this.btnSaveBahan.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveBahan.UseSelectable = true;
            this.btnSaveBahan.UseTileImage = true;
            this.btnSaveBahan.Click += new System.EventHandler(this.btnSaveBahan_Click);
            // 
            // btnDeleteBahan
            // 
            this.btnDeleteBahan.ActiveControl = null;
            this.btnDeleteBahan.Location = new System.Drawing.Point(355, 92);
            this.btnDeleteBahan.Name = "btnDeleteBahan";
            this.btnDeleteBahan.Size = new System.Drawing.Size(87, 67);
            this.btnDeleteBahan.TabIndex = 9;
            this.btnDeleteBahan.Text = "DELETE";
            this.btnDeleteBahan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteBahan.TileImage = global::Project.Properties.Resources.btn_delete;
            this.btnDeleteBahan.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteBahan.UseSelectable = true;
            this.btnDeleteBahan.UseTileImage = true;
            this.btnDeleteBahan.Click += new System.EventHandler(this.btnDeleteBahan_Click);
            // 
            // btnEditBahan
            // 
            this.btnEditBahan.ActiveControl = null;
            this.btnEditBahan.Location = new System.Drawing.Point(253, 92);
            this.btnEditBahan.Name = "btnEditBahan";
            this.btnEditBahan.Size = new System.Drawing.Size(87, 67);
            this.btnEditBahan.TabIndex = 8;
            this.btnEditBahan.Text = "EDIT";
            this.btnEditBahan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditBahan.TileImage = global::Project.Properties.Resources.btn_pencil;
            this.btnEditBahan.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditBahan.UseSelectable = true;
            this.btnEditBahan.UseTileImage = true;
            this.btnEditBahan.Click += new System.EventHandler(this.btnEditBahan_Click);
            // 
            // btnAddBahan
            // 
            this.btnAddBahan.ActiveControl = null;
            this.btnAddBahan.Location = new System.Drawing.Point(151, 92);
            this.btnAddBahan.Name = "btnAddBahan";
            this.btnAddBahan.Size = new System.Drawing.Size(85, 67);
            this.btnAddBahan.TabIndex = 7;
            this.btnAddBahan.Text = "ADD";
            this.btnAddBahan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddBahan.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddBahan.TileImage")));
            this.btnAddBahan.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddBahan.UseSelectable = true;
            this.btnAddBahan.UseTileImage = true;
            this.btnAddBahan.Click += new System.EventHandler(this.btnAddBahan_Click);
            // 
            // btnRefreshBahan
            // 
            this.btnRefreshBahan.ActiveControl = null;
            this.btnRefreshBahan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshBahan.Location = new System.Drawing.Point(49, 92);
            this.btnRefreshBahan.Name = "btnRefreshBahan";
            this.btnRefreshBahan.Size = new System.Drawing.Size(85, 67);
            this.btnRefreshBahan.TabIndex = 6;
            this.btnRefreshBahan.Text = "REFRESH";
            this.btnRefreshBahan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefreshBahan.TileImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshBahan.TileImage")));
            this.btnRefreshBahan.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefreshBahan.UseSelectable = true;
            this.btnRefreshBahan.UseTileImage = true;
            this.btnRefreshBahan.Click += new System.EventHandler(this.btnRefreshBahan_Click);
            // 
            // MasterBahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 380);
            this.Controls.Add(this.btnSaveBahan);
            this.Controls.Add(this.btnDeleteBahan);
            this.Controls.Add(this.btnEditBahan);
            this.Controls.Add(this.btnAddBahan);
            this.Controls.Add(this.btnRefreshBahan);
            this.Controls.Add(this.dataGridBahan);
            this.Name = "MasterBahan";
            this.Text = "MasterBahan";
            this.Load += new System.EventHandler(this.MasterBahan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBahan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBahan;
        private MetroFramework.Controls.MetroTile btnSaveBahan;
        private MetroFramework.Controls.MetroTile btnDeleteBahan;
        private MetroFramework.Controls.MetroTile btnEditBahan;
        private MetroFramework.Controls.MetroTile btnAddBahan;
        private MetroFramework.Controls.MetroTile btnRefreshBahan;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource materialBindingSource;
    }
}