namespace Project
{
    partial class DetailPOPopup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detailPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noPemotonganKainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pONumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colorIDDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.detailQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusFakturDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.detailStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tempPemotonganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailPOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(484, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 53);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NO,
            this.noPemotonganKainDataGridViewTextBoxColumn,
            this.pONumberDataGridViewTextBoxColumn,
            this.materialIDDataGridViewComboBoxColumn,
            this.colorIDDataGridViewComboBoxColumn,
            this.detailQtyDataGridViewTextBoxColumn,
            this.detailPriceDataGridViewTextBoxColumn,
            this.detailTotalDataGridViewTextBoxColumn,
            this.statusFakturDataGridViewCheckBoxColumn,
            this.detailStatusDataGridViewCheckBoxColumn,
            this.tempPemotonganDataGridViewTextBoxColumn,
            this.detailPOIDDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.detailPOBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.Location = new System.Drawing.Point(23, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 240);
            this.dataGridView1.TabIndex = 5;
            // 
            // detailPOBindingSource
            // 
            this.detailPOBindingSource.DataSource = typeof(Project.DetailPO);
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(Project.Material);
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(Project.Color);
            // 
            // NO
            // 
            this.NO.HeaderText = "No.";
            this.NO.Name = "NO";
            this.NO.ReadOnly = true;
            this.NO.Width = 60;
            // 
            // noPemotonganKainDataGridViewTextBoxColumn
            // 
            this.noPemotonganKainDataGridViewTextBoxColumn.DataPropertyName = "noPemotonganKain";
            this.noPemotonganKainDataGridViewTextBoxColumn.HeaderText = "No. Pemotongan Kain";
            this.noPemotonganKainDataGridViewTextBoxColumn.Name = "noPemotonganKainDataGridViewTextBoxColumn";
            this.noPemotonganKainDataGridViewTextBoxColumn.Width = 140;
            // 
            // pONumberDataGridViewTextBoxColumn
            // 
            this.pONumberDataGridViewTextBoxColumn.DataPropertyName = "PONumber";
            this.pONumberDataGridViewTextBoxColumn.HeaderText = "No. PO";
            this.pONumberDataGridViewTextBoxColumn.Name = "pONumberDataGridViewTextBoxColumn";
            this.pONumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // materialIDDataGridViewComboBoxColumn
            // 
            this.materialIDDataGridViewComboBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewComboBoxColumn.DataSource = this.materialBindingSource;
            this.materialIDDataGridViewComboBoxColumn.DisplayMember = "MaterialName";
            this.materialIDDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.materialIDDataGridViewComboBoxColumn.HeaderText = "Material";
            this.materialIDDataGridViewComboBoxColumn.Name = "materialIDDataGridViewComboBoxColumn";
            this.materialIDDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.materialIDDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.materialIDDataGridViewComboBoxColumn.ValueMember = "MaterialID";
            this.materialIDDataGridViewComboBoxColumn.Width = 120;
            // 
            // colorIDDataGridViewComboBoxColumn
            // 
            this.colorIDDataGridViewComboBoxColumn.DataPropertyName = "ColorID";
            this.colorIDDataGridViewComboBoxColumn.DataSource = this.colorBindingSource;
            this.colorIDDataGridViewComboBoxColumn.DisplayMember = "ColorName";
            this.colorIDDataGridViewComboBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colorIDDataGridViewComboBoxColumn.HeaderText = "Color";
            this.colorIDDataGridViewComboBoxColumn.Name = "colorIDDataGridViewComboBoxColumn";
            this.colorIDDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colorIDDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colorIDDataGridViewComboBoxColumn.ValueMember = "ColorID";
            this.colorIDDataGridViewComboBoxColumn.Width = 120;
            // 
            // detailQtyDataGridViewTextBoxColumn
            // 
            this.detailQtyDataGridViewTextBoxColumn.DataPropertyName = "DetailQty";
            this.detailQtyDataGridViewTextBoxColumn.HeaderText = "Quantity (kgs)";
            this.detailQtyDataGridViewTextBoxColumn.Name = "detailQtyDataGridViewTextBoxColumn";
            // 
            // detailPriceDataGridViewTextBoxColumn
            // 
            this.detailPriceDataGridViewTextBoxColumn.DataPropertyName = "DetailPrice";
            this.detailPriceDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.detailPriceDataGridViewTextBoxColumn.Name = "detailPriceDataGridViewTextBoxColumn";
            this.detailPriceDataGridViewTextBoxColumn.Width = 120;
            // 
            // detailTotalDataGridViewTextBoxColumn
            // 
            this.detailTotalDataGridViewTextBoxColumn.DataPropertyName = "DetailTotal";
            this.detailTotalDataGridViewTextBoxColumn.HeaderText = "Total Harga";
            this.detailTotalDataGridViewTextBoxColumn.Name = "detailTotalDataGridViewTextBoxColumn";
            this.detailTotalDataGridViewTextBoxColumn.Width = 120;
            // 
            // statusFakturDataGridViewCheckBoxColumn
            // 
            this.statusFakturDataGridViewCheckBoxColumn.DataPropertyName = "statusFaktur";
            this.statusFakturDataGridViewCheckBoxColumn.HeaderText = "Status Faktur";
            this.statusFakturDataGridViewCheckBoxColumn.Name = "statusFakturDataGridViewCheckBoxColumn";
            // 
            // detailStatusDataGridViewCheckBoxColumn
            // 
            this.detailStatusDataGridViewCheckBoxColumn.DataPropertyName = "DetailStatus";
            this.detailStatusDataGridViewCheckBoxColumn.HeaderText = "DetailStatus";
            this.detailStatusDataGridViewCheckBoxColumn.Name = "detailStatusDataGridViewCheckBoxColumn";
            this.detailStatusDataGridViewCheckBoxColumn.Visible = false;
            // 
            // tempPemotonganDataGridViewTextBoxColumn
            // 
            this.tempPemotonganDataGridViewTextBoxColumn.DataPropertyName = "tempPemotongan";
            this.tempPemotonganDataGridViewTextBoxColumn.HeaderText = "tempPemotongan";
            this.tempPemotonganDataGridViewTextBoxColumn.Name = "tempPemotonganDataGridViewTextBoxColumn";
            this.tempPemotonganDataGridViewTextBoxColumn.Visible = false;
            // 
            // detailPOIDDataGridViewTextBoxColumn
            // 
            this.detailPOIDDataGridViewTextBoxColumn.DataPropertyName = "DetailPOID";
            this.detailPOIDDataGridViewTextBoxColumn.HeaderText = "DetailPOID";
            this.detailPOIDDataGridViewTextBoxColumn.Name = "detailPOIDDataGridViewTextBoxColumn";
            this.detailPOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrint.Image = global::Project.Properties.Resources.btn_print;
            this.btnPrint.Location = new System.Drawing.Point(988, 69);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(61, 33);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.MouseHover += new System.EventHandler(this.btnPrint_MouseHover);
            // 
            // DetailPOPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 444);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Name = "DetailPOPopup";
            this.Text = "Detail Pemotongan Kain";
            this.Load += new System.EventHandler(this.DetailPOPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPemotonganKainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pONumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn materialIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn colorIDDataGridViewComboBoxColumn;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusFakturDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn detailStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempPemotonganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailPOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource detailPOBindingSource;
        private System.Windows.Forms.Button btnPrint;
    }
}