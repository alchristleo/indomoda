namespace Project
{
    partial class DetailPC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.detailPenerimaanSBCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noPenerimaanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSPKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.merk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukuran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyAwalCMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyCMTBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyCMTHilang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyAkhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempSablonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempBordirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempCMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPenerimaanSBCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.noPenerimaanDataGridViewTextBoxColumn,
            this.noSPKDataGridViewTextBoxColumn,
            this.noSeriDataGridViewTextBoxColumn,
            this.model,
            this.ColorID,
            this.merk,
            this.ukuran,
            this.qtyAwalCMT,
            this.qtyCMTBS,
            this.qtyCMTHilang,
            this.qtyAkhir,
            this.typeDataGridViewTextBoxColumn,
            this.tempSablonDataGridViewTextBoxColumn,
            this.tempBordirDataGridViewTextBoxColumn,
            this.tempCMTDataGridViewTextBoxColumn,
            this.idDetailDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.detailPenerimaanSBCBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.Location = new System.Drawing.Point(23, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1193, 240);
            this.dataGridView1.TabIndex = 27;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(561, 367);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 53);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrint.Image = global::Project.Properties.Resources.btn_print;
            this.btnPrint.Location = new System.Drawing.Point(1155, 64);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(61, 33);
            this.btnPrint.TabIndex = 28;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.MouseHover += new System.EventHandler(this.btnPrint_MouseHover);
            // 
            // detailPenerimaanSBCBindingSource
            // 
            this.detailPenerimaanSBCBindingSource.DataSource = typeof(Project.DetailPenerimaanSBC);
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
            this.NO.Width = 40;
            // 
            // noPenerimaanDataGridViewTextBoxColumn
            // 
            this.noPenerimaanDataGridViewTextBoxColumn.DataPropertyName = "noPenerimaan";
            this.noPenerimaanDataGridViewTextBoxColumn.HeaderText = "No. Penerimaan CMT";
            this.noPenerimaanDataGridViewTextBoxColumn.Name = "noPenerimaanDataGridViewTextBoxColumn";
            this.noPenerimaanDataGridViewTextBoxColumn.ReadOnly = true;
            this.noPenerimaanDataGridViewTextBoxColumn.Width = 130;
            // 
            // noSPKDataGridViewTextBoxColumn
            // 
            this.noSPKDataGridViewTextBoxColumn.DataPropertyName = "noSPK";
            this.noSPKDataGridViewTextBoxColumn.HeaderText = "No. SPK CMT";
            this.noSPKDataGridViewTextBoxColumn.Name = "noSPKDataGridViewTextBoxColumn";
            this.noSPKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noSeriDataGridViewTextBoxColumn
            // 
            this.noSeriDataGridViewTextBoxColumn.DataPropertyName = "noSeri";
            this.noSeriDataGridViewTextBoxColumn.HeaderText = "No. Seri";
            this.noSeriDataGridViewTextBoxColumn.Name = "noSeriDataGridViewTextBoxColumn";
            this.noSeriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // model
            // 
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // ColorID
            // 
            this.ColorID.DataPropertyName = "ColorID";
            this.ColorID.DataSource = this.colorBindingSource;
            this.ColorID.DisplayMember = "ColorName";
            this.ColorID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ColorID.HeaderText = "Color";
            this.ColorID.Name = "ColorID";
            this.ColorID.ReadOnly = true;
            this.ColorID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColorID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColorID.ValueMember = "ColorID";
            // 
            // merk
            // 
            this.merk.DataPropertyName = "merk";
            this.merk.HeaderText = "Merk";
            this.merk.Name = "merk";
            this.merk.ReadOnly = true;
            // 
            // ukuran
            // 
            this.ukuran.DataPropertyName = "ukuran";
            this.ukuran.HeaderText = "Ukuran";
            this.ukuran.Name = "ukuran";
            this.ukuran.ReadOnly = true;
            // 
            // qtyAwalCMT
            // 
            this.qtyAwalCMT.DataPropertyName = "qtyAwalCMT";
            this.qtyAwalCMT.HeaderText = "Qty Awal CMT (pcs)";
            this.qtyAwalCMT.Name = "qtyAwalCMT";
            this.qtyAwalCMT.ReadOnly = true;
            // 
            // qtyCMTBS
            // 
            this.qtyCMTBS.DataPropertyName = "qtyCMTBS";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Pink;
            this.qtyCMTBS.DefaultCellStyle = dataGridViewCellStyle2;
            this.qtyCMTBS.HeaderText = "Qty Sablon CMT (pcs)";
            this.qtyCMTBS.Name = "qtyCMTBS";
            this.qtyCMTBS.ReadOnly = true;
            // 
            // qtyCMTHilang
            // 
            this.qtyCMTHilang.DataPropertyName = "qtyCMTHilang";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightPink;
            this.qtyCMTHilang.DefaultCellStyle = dataGridViewCellStyle3;
            this.qtyCMTHilang.HeaderText = "Qty CMT Hilang (pcs)";
            this.qtyCMTHilang.Name = "qtyCMTHilang";
            this.qtyCMTHilang.ReadOnly = true;
            // 
            // qtyAkhir
            // 
            this.qtyAkhir.DataPropertyName = "qtyAkhir";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Plum;
            this.qtyAkhir.DefaultCellStyle = dataGridViewCellStyle4;
            this.qtyAkhir.HeaderText = "Qty Akhir CMT (pcs)";
            this.qtyAkhir.Name = "qtyAkhir";
            this.qtyAkhir.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // tempSablonDataGridViewTextBoxColumn
            // 
            this.tempSablonDataGridViewTextBoxColumn.DataPropertyName = "tempSablon";
            this.tempSablonDataGridViewTextBoxColumn.HeaderText = "tempSablon";
            this.tempSablonDataGridViewTextBoxColumn.Name = "tempSablonDataGridViewTextBoxColumn";
            this.tempSablonDataGridViewTextBoxColumn.ReadOnly = true;
            this.tempSablonDataGridViewTextBoxColumn.Visible = false;
            // 
            // tempBordirDataGridViewTextBoxColumn
            // 
            this.tempBordirDataGridViewTextBoxColumn.DataPropertyName = "tempBordir";
            this.tempBordirDataGridViewTextBoxColumn.HeaderText = "tempBordir";
            this.tempBordirDataGridViewTextBoxColumn.Name = "tempBordirDataGridViewTextBoxColumn";
            this.tempBordirDataGridViewTextBoxColumn.ReadOnly = true;
            this.tempBordirDataGridViewTextBoxColumn.Visible = false;
            // 
            // tempCMTDataGridViewTextBoxColumn
            // 
            this.tempCMTDataGridViewTextBoxColumn.DataPropertyName = "tempCMT";
            this.tempCMTDataGridViewTextBoxColumn.HeaderText = "tempCMT";
            this.tempCMTDataGridViewTextBoxColumn.Name = "tempCMTDataGridViewTextBoxColumn";
            this.tempCMTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tempCMTDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDetailDataGridViewTextBoxColumn
            // 
            this.idDetailDataGridViewTextBoxColumn.DataPropertyName = "idDetail";
            this.idDetailDataGridViewTextBoxColumn.HeaderText = "idDetail";
            this.idDetailDataGridViewTextBoxColumn.Name = "idDetailDataGridViewTextBoxColumn";
            this.idDetailDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDetailDataGridViewTextBoxColumn.Visible = false;
            // 
            // DetailPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 445);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Name = "DetailPC";
            this.Text = "DetailPC";
            this.Load += new System.EventHandler(this.DetailPC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPenerimaanSBCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnExit;
        private System.Windows.Forms.BindingSource detailPenerimaanSBCBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn noPenerimaanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSPKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColorID;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn merk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukuran;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyAwalCMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyCMTBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyCMTHilang;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyAkhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempSablonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempBordirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempCMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetailDataGridViewTextBoxColumn;
    }
}