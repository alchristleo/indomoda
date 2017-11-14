namespace Project
{
    partial class AddPOKain
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
            this.txtAddQuantity = new MetroFramework.Controls.MetroTextBox();
            this.detailPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAddPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cboMaterialName = new MetroFramework.Controls.MetroComboBox();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAddMaterialCode = new MetroFramework.Controls.MetroTextBox();
            this.cboColorName = new MetroFramework.Controls.MetroComboBox();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAddColorCode = new MetroFramework.Controls.MetroTextBox();
            this.btnSavePOKain = new MetroFramework.Controls.MetroButton();
            this.btnExitPOKain = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.detailPOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddQuantity
            // 
            // 
            // 
            // 
            this.txtAddQuantity.CustomButton.Image = null;
            this.txtAddQuantity.CustomButton.Location = new System.Drawing.Point(56, 1);
            this.txtAddQuantity.CustomButton.Name = "";
            this.txtAddQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddQuantity.CustomButton.TabIndex = 1;
            this.txtAddQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddQuantity.CustomButton.UseSelectable = true;
            this.txtAddQuantity.CustomButton.Visible = false;
            this.txtAddQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detailPOBindingSource, "DetailQty", true));
            this.txtAddQuantity.Lines = new string[0];
            this.txtAddQuantity.Location = new System.Drawing.Point(270, 276);
            this.txtAddQuantity.MaxLength = 32767;
            this.txtAddQuantity.Name = "txtAddQuantity";
            this.txtAddQuantity.PasswordChar = '\0';
            this.txtAddQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddQuantity.SelectedText = "";
            this.txtAddQuantity.SelectionLength = 0;
            this.txtAddQuantity.SelectionStart = 0;
            this.txtAddQuantity.ShortcutsEnabled = true;
            this.txtAddQuantity.Size = new System.Drawing.Size(78, 23);
            this.txtAddQuantity.TabIndex = 5;
            this.txtAddQuantity.UseSelectable = true;
            this.txtAddQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // detailPOBindingSource
            // 
            this.detailPOBindingSource.DataSource = typeof(Project.DetailPO);
            // 
            // txtAddPrice
            // 
            // 
            // 
            // 
            this.txtAddPrice.CustomButton.Image = null;
            this.txtAddPrice.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtAddPrice.CustomButton.Name = "";
            this.txtAddPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddPrice.CustomButton.TabIndex = 1;
            this.txtAddPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddPrice.CustomButton.UseSelectable = true;
            this.txtAddPrice.CustomButton.Visible = false;
            this.txtAddPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detailPOBindingSource, "DetailTotal", true));
            this.txtAddPrice.Lines = new string[0];
            this.txtAddPrice.Location = new System.Drawing.Point(270, 314);
            this.txtAddPrice.MaxLength = 32767;
            this.txtAddPrice.Name = "txtAddPrice";
            this.txtAddPrice.PasswordChar = '\0';
            this.txtAddPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddPrice.SelectedText = "";
            this.txtAddPrice.SelectionLength = 0;
            this.txtAddPrice.SelectionStart = 0;
            this.txtAddPrice.ShortcutsEnabled = true;
            this.txtAddPrice.Size = new System.Drawing.Size(162, 23);
            this.txtAddPrice.TabIndex = 6;
            this.txtAddPrice.UseSelectable = true;
            this.txtAddPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(175, 123);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Bahan Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(175, 165);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Bahan Code";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(175, 199);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(87, 19);
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "Warna Name";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(173, 239);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Warna Code";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(354, 277);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(24, 19);
            this.metroLabel5.TabIndex = 30;
            this.metroLabel5.Text = "Kg";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(175, 276);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 31;
            this.metroLabel6.Text = "Quantity";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(175, 314);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(38, 19);
            this.metroLabel7.TabIndex = 32;
            this.metroLabel7.Text = "Price";
            // 
            // cboMaterialName
            // 
            this.cboMaterialName.DataSource = this.materialBindingSource;
            this.cboMaterialName.DisplayMember = "MaterialName";
            this.cboMaterialName.FormattingEnabled = true;
            this.cboMaterialName.ItemHeight = 23;
            this.cboMaterialName.Location = new System.Drawing.Point(270, 123);
            this.cboMaterialName.Name = "cboMaterialName";
            this.cboMaterialName.Size = new System.Drawing.Size(162, 29);
            this.cboMaterialName.TabIndex = 1;
            this.cboMaterialName.UseSelectable = true;
            this.cboMaterialName.ValueMember = "MaterialID";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(Project.Material);
            // 
            // txtAddMaterialCode
            // 
            // 
            // 
            // 
            this.txtAddMaterialCode.CustomButton.Image = null;
            this.txtAddMaterialCode.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtAddMaterialCode.CustomButton.Name = "";
            this.txtAddMaterialCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddMaterialCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddMaterialCode.CustomButton.TabIndex = 1;
            this.txtAddMaterialCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddMaterialCode.CustomButton.UseSelectable = true;
            this.txtAddMaterialCode.CustomButton.Visible = false;
            this.txtAddMaterialCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "MaterialCode", true));
            this.txtAddMaterialCode.Lines = new string[0];
            this.txtAddMaterialCode.Location = new System.Drawing.Point(270, 165);
            this.txtAddMaterialCode.MaxLength = 32767;
            this.txtAddMaterialCode.Name = "txtAddMaterialCode";
            this.txtAddMaterialCode.PasswordChar = '\0';
            this.txtAddMaterialCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddMaterialCode.SelectedText = "";
            this.txtAddMaterialCode.SelectionLength = 0;
            this.txtAddMaterialCode.SelectionStart = 0;
            this.txtAddMaterialCode.ShortcutsEnabled = true;
            this.txtAddMaterialCode.Size = new System.Drawing.Size(162, 23);
            this.txtAddMaterialCode.TabIndex = 2;
            this.txtAddMaterialCode.UseSelectable = true;
            this.txtAddMaterialCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddMaterialCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboColorName
            // 
            this.cboColorName.DataSource = this.colorBindingSource;
            this.cboColorName.DisplayMember = "ColorName";
            this.cboColorName.FormattingEnabled = true;
            this.cboColorName.ItemHeight = 23;
            this.cboColorName.Location = new System.Drawing.Point(270, 199);
            this.cboColorName.Name = "cboColorName";
            this.cboColorName.Size = new System.Drawing.Size(162, 29);
            this.cboColorName.TabIndex = 3;
            this.cboColorName.UseSelectable = true;
            this.cboColorName.ValueMember = "ColorID";
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(Project.Color);
            // 
            // txtAddColorCode
            // 
            // 
            // 
            // 
            this.txtAddColorCode.CustomButton.Image = null;
            this.txtAddColorCode.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtAddColorCode.CustomButton.Name = "";
            this.txtAddColorCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddColorCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddColorCode.CustomButton.TabIndex = 1;
            this.txtAddColorCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddColorCode.CustomButton.UseSelectable = true;
            this.txtAddColorCode.CustomButton.Visible = false;
            this.txtAddColorCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colorBindingSource, "ColorCode", true));
            this.txtAddColorCode.Lines = new string[0];
            this.txtAddColorCode.Location = new System.Drawing.Point(270, 239);
            this.txtAddColorCode.MaxLength = 32767;
            this.txtAddColorCode.Name = "txtAddColorCode";
            this.txtAddColorCode.PasswordChar = '\0';
            this.txtAddColorCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddColorCode.SelectedText = "";
            this.txtAddColorCode.SelectionLength = 0;
            this.txtAddColorCode.SelectionStart = 0;
            this.txtAddColorCode.ShortcutsEnabled = true;
            this.txtAddColorCode.Size = new System.Drawing.Size(162, 23);
            this.txtAddColorCode.TabIndex = 4;
            this.txtAddColorCode.UseSelectable = true;
            this.txtAddColorCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddColorCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSavePOKain
            // 
            this.btnSavePOKain.Location = new System.Drawing.Point(340, 375);
            this.btnSavePOKain.Name = "btnSavePOKain";
            this.btnSavePOKain.Size = new System.Drawing.Size(93, 47);
            this.btnSavePOKain.TabIndex = 8;
            this.btnSavePOKain.Text = "SAVE";
            this.btnSavePOKain.UseSelectable = true;
            this.btnSavePOKain.Click += new System.EventHandler(this.btnSavePOKain_Click);
            // 
            // btnExitPOKain
            // 
            this.btnExitPOKain.Location = new System.Drawing.Point(175, 375);
            this.btnExitPOKain.Name = "btnExitPOKain";
            this.btnExitPOKain.Size = new System.Drawing.Size(93, 47);
            this.btnExitPOKain.TabIndex = 9;
            this.btnExitPOKain.Text = "EXIT";
            this.btnExitPOKain.UseSelectable = true;
            this.btnExitPOKain.Click += new System.EventHandler(this.btnExitPOKain_Click);
            // 
            // AddPOKain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 455);
            this.Controls.Add(this.btnExitPOKain);
            this.Controls.Add(this.btnSavePOKain);
            this.Controls.Add(this.txtAddPrice);
            this.Controls.Add(this.txtAddQuantity);
            this.Controls.Add(this.txtAddColorCode);
            this.Controls.Add(this.cboColorName);
            this.Controls.Add(this.txtAddMaterialCode);
            this.Controls.Add(this.cboMaterialName);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddPOKain";
            this.Text = "Add PO Kain";
            this.Load += new System.EventHandler(this.AddPOKain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailPOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cboMaterialName;
        private MetroFramework.Controls.MetroTextBox txtAddMaterialCode;
        private MetroFramework.Controls.MetroComboBox cboColorName;
        private MetroFramework.Controls.MetroTextBox txtAddColorCode;
        private MetroFramework.Controls.MetroButton btnSavePOKain;
        private MetroFramework.Controls.MetroButton btnExitPOKain;
        private MetroFramework.Controls.MetroTextBox txtAddQuantity;
        private MetroFramework.Controls.MetroTextBox txtAddPrice;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private System.Windows.Forms.BindingSource detailPOBindingSource;
    }
}