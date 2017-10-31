namespace Project
{
    partial class Warna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warna));
            this.colorDataGrid = new System.Windows.Forms.DataGridView();
            this.colorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveWarna = new MetroFramework.Controls.MetroTile();
            this.btnDeleteWarna = new MetroFramework.Controls.MetroTile();
            this.btnEditWarna = new MetroFramework.Controls.MetroTile();
            this.btnAddWarna = new MetroFramework.Controls.MetroTile();
            this.btnRefreshWarna = new MetroFramework.Controls.MetroTile();
            this.warnaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.warnaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warnaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.warnaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.colorDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warnaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warnaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warnaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warnaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // colorDataGrid
            // 
            this.colorDataGrid.AllowUserToAddRows = false;
            this.colorDataGrid.AllowUserToDeleteRows = false;
            this.colorDataGrid.AutoGenerateColumns = false;
            this.colorDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.colorDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colorIDDataGridViewTextBoxColumn,
            this.colorCodeDataGridViewTextBoxColumn,
            this.colorNameDataGridViewTextBoxColumn});
            this.colorDataGrid.DataSource = this.colorBindingSource;
            this.colorDataGrid.Location = new System.Drawing.Point(36, 161);
            this.colorDataGrid.Name = "colorDataGrid";
            this.colorDataGrid.ReadOnly = true;
            this.colorDataGrid.Size = new System.Drawing.Size(528, 216);
            this.colorDataGrid.TabIndex = 0;
            // 
            // colorIDDataGridViewTextBoxColumn
            // 
            this.colorIDDataGridViewTextBoxColumn.DataPropertyName = "ColorID";
            this.colorIDDataGridViewTextBoxColumn.HeaderText = "ColorID";
            this.colorIDDataGridViewTextBoxColumn.Name = "colorIDDataGridViewTextBoxColumn";
            this.colorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorCodeDataGridViewTextBoxColumn
            // 
            this.colorCodeDataGridViewTextBoxColumn.DataPropertyName = "ColorCode";
            this.colorCodeDataGridViewTextBoxColumn.HeaderText = "ColorCode";
            this.colorCodeDataGridViewTextBoxColumn.Name = "colorCodeDataGridViewTextBoxColumn";
            this.colorCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            this.colorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(Project.Color);
            // 
            // btnSaveWarna
            // 
            this.btnSaveWarna.ActiveControl = null;
            this.btnSaveWarna.Location = new System.Drawing.Point(457, 78);
            this.btnSaveWarna.Name = "btnSaveWarna";
            this.btnSaveWarna.Size = new System.Drawing.Size(88, 67);
            this.btnSaveWarna.TabIndex = 6;
            this.btnSaveWarna.Text = "SAVE";
            this.btnSaveWarna.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveWarna.TileImage = global::Project.Properties.Resources.btn_save;
            this.btnSaveWarna.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveWarna.UseSelectable = true;
            this.btnSaveWarna.UseTileImage = true;
            this.btnSaveWarna.Click += new System.EventHandler(this.btnSaveWarna_Click);
            // 
            // btnDeleteWarna
            // 
            this.btnDeleteWarna.ActiveControl = null;
            this.btnDeleteWarna.Location = new System.Drawing.Point(350, 78);
            this.btnDeleteWarna.Name = "btnDeleteWarna";
            this.btnDeleteWarna.Size = new System.Drawing.Size(87, 67);
            this.btnDeleteWarna.TabIndex = 5;
            this.btnDeleteWarna.Text = "DELETE";
            this.btnDeleteWarna.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteWarna.TileImage = global::Project.Properties.Resources.btn_delete;
            this.btnDeleteWarna.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteWarna.UseSelectable = true;
            this.btnDeleteWarna.UseTileImage = true;
            this.btnDeleteWarna.Click += new System.EventHandler(this.btnDeleteWarna_Click);
            // 
            // btnEditWarna
            // 
            this.btnEditWarna.ActiveControl = null;
            this.btnEditWarna.Location = new System.Drawing.Point(243, 78);
            this.btnEditWarna.Name = "btnEditWarna";
            this.btnEditWarna.Size = new System.Drawing.Size(87, 67);
            this.btnEditWarna.TabIndex = 4;
            this.btnEditWarna.Text = "EDIT";
            this.btnEditWarna.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditWarna.TileImage = global::Project.Properties.Resources.btn_pencil;
            this.btnEditWarna.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditWarna.UseSelectable = true;
            this.btnEditWarna.UseTileImage = true;
            this.btnEditWarna.Click += new System.EventHandler(this.btnEditWarna_Click);
            // 
            // btnAddWarna
            // 
            this.btnAddWarna.ActiveControl = null;
            this.btnAddWarna.Location = new System.Drawing.Point(139, 78);
            this.btnAddWarna.Name = "btnAddWarna";
            this.btnAddWarna.Size = new System.Drawing.Size(85, 67);
            this.btnAddWarna.TabIndex = 3;
            this.btnAddWarna.Text = "ADD";
            this.btnAddWarna.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddWarna.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddWarna.TileImage")));
            this.btnAddWarna.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddWarna.UseSelectable = true;
            this.btnAddWarna.UseTileImage = true;
            this.btnAddWarna.Click += new System.EventHandler(this.btnAddWarna_Click);
            // 
            // btnRefreshWarna
            // 
            this.btnRefreshWarna.ActiveControl = null;
            this.btnRefreshWarna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshWarna.Location = new System.Drawing.Point(36, 78);
            this.btnRefreshWarna.Name = "btnRefreshWarna";
            this.btnRefreshWarna.Size = new System.Drawing.Size(85, 67);
            this.btnRefreshWarna.TabIndex = 2;
            this.btnRefreshWarna.Text = "REFRESH";
            this.btnRefreshWarna.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefreshWarna.TileImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshWarna.TileImage")));
            this.btnRefreshWarna.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefreshWarna.UseSelectable = true;
            this.btnRefreshWarna.UseTileImage = true;
            this.btnRefreshWarna.Click += new System.EventHandler(this.btnRefreshWarna_Click);
            // 
            // Warna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 417);
            this.Controls.Add(this.btnSaveWarna);
            this.Controls.Add(this.btnDeleteWarna);
            this.Controls.Add(this.btnEditWarna);
            this.Controls.Add(this.btnAddWarna);
            this.Controls.Add(this.btnRefreshWarna);
            this.Controls.Add(this.colorDataGrid);
            this.Name = "Warna";
            this.Text = "Warna";
            this.Load += new System.EventHandler(this.Warna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warnaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warnaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warnaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warnaBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView colorDataGrid;
        private MetroFramework.Controls.MetroTile btnRefreshWarna;
        private MetroFramework.Controls.MetroTile btnAddWarna;
        private MetroFramework.Controls.MetroTile btnEditWarna;
        private MetroFramework.Controls.MetroTile btnDeleteWarna;
        private MetroFramework.Controls.MetroTile btnSaveWarna;
        private System.Windows.Forms.BindingSource warnaBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource warnaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceptButtonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autoScrollDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autoSizeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoSizeModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoValidateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formBorderStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancelButtonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn controlBoxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn helpButtonDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn iconDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMdiContainerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn keyPreviewDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximumSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainMenuStripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn maximizeBoxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn minimizeBoxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rightToLeftLayoutDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn showInTaskbarDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn showIconDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeGripStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn topMostDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transparencyKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windowStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoScrollMarginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoScrollMinSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessibleDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessibleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessibleRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn allowDropDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anchorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn backgroundImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backgroundImageLayoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn causesValidationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contextMenuStripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBindingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foreColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightToLeftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn useWaitCursorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn visibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paddingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource warnaBindingSource2;
        private System.Windows.Forms.BindingSource warnaBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource colorBindingSource;
    }
}