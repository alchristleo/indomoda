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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Karyawan));
            this.employeeDataGrid = new System.Windows.Forms.DataGridView();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.employeeDataGrid.AllowUserToResizeRows = false;
            this.employeeDataGrid.AutoGenerateColumns = false;
            this.employeeDataGrid.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.employeeDataGrid.ColumnHeadersHeight = 30;
            this.employeeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NO,
            this.employeeCodeDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeEmailDataGridViewTextBoxColumn,
            this.employeePhoneDataGridViewTextBoxColumn,
            this.employeePositionDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn});
            this.employeeDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeDataGrid.DataSource = this.employeeBindingSource2;
            this.employeeDataGrid.EnableHeadersVisualStyles = false;
            this.employeeDataGrid.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.employeeDataGrid.Location = new System.Drawing.Point(57, 161);
            this.employeeDataGrid.Name = "employeeDataGrid";
            this.employeeDataGrid.ReadOnly = true;
            this.employeeDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.employeeDataGrid.RowHeadersVisible = false;
            this.employeeDataGrid.RowHeadersWidth = 50;
            this.employeeDataGrid.RowTemplate.Height = 30;
            this.employeeDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeDataGrid.Size = new System.Drawing.Size(724, 283);
            this.employeeDataGrid.TabIndex = 0;
            this.employeeDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataGrid_CellContentClick);
            // 
            // NO
            // 
            this.NO.HeaderText = "No.";
            this.NO.Name = "NO";
            this.NO.ReadOnly = true;
            this.NO.Width = 40;
            // 
            // employeeCodeDataGridViewTextBoxColumn
            // 
            this.employeeCodeDataGridViewTextBoxColumn.DataPropertyName = "EmployeeCode";
            this.employeeCodeDataGridViewTextBoxColumn.HeaderText = "Employee Code";
            this.employeeCodeDataGridViewTextBoxColumn.Name = "employeeCodeDataGridViewTextBoxColumn";
            this.employeeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeCodeDataGridViewTextBoxColumn.Width = 120;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Employee Name";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            this.employeeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // employeeEmailDataGridViewTextBoxColumn
            // 
            this.employeeEmailDataGridViewTextBoxColumn.DataPropertyName = "EmployeeEmail";
            this.employeeEmailDataGridViewTextBoxColumn.HeaderText = "Employee Email";
            this.employeeEmailDataGridViewTextBoxColumn.Name = "employeeEmailDataGridViewTextBoxColumn";
            this.employeeEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeEmailDataGridViewTextBoxColumn.Width = 120;
            // 
            // employeePhoneDataGridViewTextBoxColumn
            // 
            this.employeePhoneDataGridViewTextBoxColumn.DataPropertyName = "EmployeePhone";
            this.employeePhoneDataGridViewTextBoxColumn.HeaderText = "Employee Phone";
            this.employeePhoneDataGridViewTextBoxColumn.Name = "employeePhoneDataGridViewTextBoxColumn";
            this.employeePhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeePhoneDataGridViewTextBoxColumn.Width = 120;
            // 
            // employeePositionDataGridViewTextBoxColumn
            // 
            this.employeePositionDataGridViewTextBoxColumn.DataPropertyName = "EmployeePosition";
            this.employeePositionDataGridViewTextBoxColumn.HeaderText = "Employee Position";
            this.employeePositionDataGridViewTextBoxColumn.Name = "employeePositionDataGridViewTextBoxColumn";
            this.employeePositionDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeePositionDataGridViewTextBoxColumn.Width = 120;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // employeeBindingSource2
            // 
            this.employeeBindingSource2.DataSource = typeof(Project.Employee);
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.ActiveControl = null;
            this.btnSaveEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEmployee.Location = new System.Drawing.Point(367, 88);
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
            this.btnDeleteEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(472, 88);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(87, 67);
            this.btnDeleteEmployee.TabIndex = 4;
            this.btnDeleteEmployee.Text = "DELETE";
            this.btnDeleteEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteEmployee.TileImage = global::Project.Properties.Resources.btn_delete;
            this.btnDeleteEmployee.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteEmployee.UseSelectable = true;
            this.btnDeleteEmployee.UseTileImage = true;
            this.btnDeleteEmployee.Visible = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.ActiveControl = null;
            this.btnEditEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.ClientSize = new System.Drawing.Size(838, 492);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
    }
}