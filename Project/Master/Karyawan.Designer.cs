namespace Project
{
    partial class Karyawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Karyawan));
            this.employeeDataGrid = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveEmployee = new MetroFramework.Controls.MetroTile();
            this.btnDeleteEmployee = new MetroFramework.Controls.MetroTile();
            this.btnEditEmployee = new MetroFramework.Controls.MetroTile();
            this.btnAddEmployee = new MetroFramework.Controls.MetroTile();
            this.btnRefresh = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeDataGrid
            // 
            this.employeeDataGrid.AllowUserToAddRows = false;
            this.employeeDataGrid.AllowUserToDeleteRows = false;
            this.employeeDataGrid.AutoGenerateColumns = false;
            this.employeeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeeCodeDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeEmailDataGridViewTextBoxColumn,
            this.employeePhoneDataGridViewTextBoxColumn,
            this.employeePositionDataGridViewTextBoxColumn});
            this.employeeDataGrid.DataSource = this.employeeBindingSource2;
            this.employeeDataGrid.Location = new System.Drawing.Point(58, 161);
            this.employeeDataGrid.Name = "employeeDataGrid";
            this.employeeDataGrid.ReadOnly = true;
            this.employeeDataGrid.Size = new System.Drawing.Size(610, 230);
            this.employeeDataGrid.TabIndex = 0;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // employeeCodeDataGridViewTextBoxColumn
            // 
            this.employeeCodeDataGridViewTextBoxColumn.DataPropertyName = "EmployeeCode";
            this.employeeCodeDataGridViewTextBoxColumn.HeaderText = "EmployeeCode";
            this.employeeCodeDataGridViewTextBoxColumn.Name = "employeeCodeDataGridViewTextBoxColumn";
            this.employeeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            this.employeeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeEmailDataGridViewTextBoxColumn
            // 
            this.employeeEmailDataGridViewTextBoxColumn.DataPropertyName = "EmployeeEmail";
            this.employeeEmailDataGridViewTextBoxColumn.HeaderText = "EmployeeEmail";
            this.employeeEmailDataGridViewTextBoxColumn.Name = "employeeEmailDataGridViewTextBoxColumn";
            this.employeeEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeePhoneDataGridViewTextBoxColumn
            // 
            this.employeePhoneDataGridViewTextBoxColumn.DataPropertyName = "EmployeePhone";
            this.employeePhoneDataGridViewTextBoxColumn.HeaderText = "EmployeePhone";
            this.employeePhoneDataGridViewTextBoxColumn.Name = "employeePhoneDataGridViewTextBoxColumn";
            this.employeePhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeePositionDataGridViewTextBoxColumn
            // 
            this.employeePositionDataGridViewTextBoxColumn.DataPropertyName = "EmployeePosition";
            this.employeePositionDataGridViewTextBoxColumn.HeaderText = "EmployeePosition";
            this.employeePositionDataGridViewTextBoxColumn.Name = "employeePositionDataGridViewTextBoxColumn";
            this.employeePositionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource2
            // 
            this.employeeBindingSource2.DataSource = typeof(Project.Employee);
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.ActiveControl = null;
            this.btnSaveEmployee.Location = new System.Drawing.Point(466, 88);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(88, 67);
            this.btnSaveEmployee.TabIndex = 5;
            this.btnSaveEmployee.Text = "SAVE";
            this.btnSaveEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaveEmployee.TileImage = global::Project.Properties.Resources.btn_save;
            this.btnSaveEmployee.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveEmployee.UseSelectable = true;
            this.btnSaveEmployee.UseTileImage = true;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.ActiveControl = null;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(363, 88);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(87, 67);
            this.btnDeleteEmployee.TabIndex = 4;
            this.btnDeleteEmployee.Text = "DELETE";
            this.btnDeleteEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteEmployee.TileImage = global::Project.Properties.Resources.btn_delete;
            this.btnDeleteEmployee.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteEmployee.UseSelectable = true;
            this.btnDeleteEmployee.UseTileImage = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.ActiveControl = null;
            this.btnEditEmployee.Location = new System.Drawing.Point(261, 88);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(87, 67);
            this.btnEditEmployee.TabIndex = 3;
            this.btnEditEmployee.Text = "EDIT";
            this.btnEditEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditEmployee.TileImage = global::Project.Properties.Resources.btn_pencil;
            this.btnEditEmployee.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditEmployee.UseSelectable = true;
            this.btnEditEmployee.UseTileImage = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.ActiveControl = null;
            this.btnAddEmployee.Location = new System.Drawing.Point(159, 88);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(85, 67);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "ADD";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddEmployee.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.TileImage")));
            this.btnAddEmployee.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddEmployee.UseSelectable = true;
            this.btnAddEmployee.UseTileImage = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ActiveControl = null;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(57, 88);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 67);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.TileImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.TileImage")));
            this.btnRefresh.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.UseTileImage = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Karyawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 442);
            this.Controls.Add(this.btnSaveEmployee);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.employeeDataGrid);
            this.Name = "Karyawan";
            this.Text = "Karyawan";
            this.Load += new System.EventHandler(this.Karyawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeDataGrid;
        private MetroFramework.Controls.MetroTile btnRefresh;
        private MetroFramework.Controls.MetroTile btnAddEmployee;
        private MetroFramework.Controls.MetroTile btnEditEmployee;
        private MetroFramework.Controls.MetroTile btnDeleteEmployee;
        private MetroFramework.Controls.MetroTile btnSaveEmployee;
        private System.Windows.Forms.BindingSource employeeBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePositionDataGridViewTextBoxColumn;
    }
}