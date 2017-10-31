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
            this.txtAddPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cboMaterialCode = new MetroFramework.Controls.MetroComboBox();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAddMaterialName = new MetroFramework.Controls.MetroTextBox();
            this.cboColorCode = new MetroFramework.Controls.MetroComboBox();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAddColorName = new MetroFramework.Controls.MetroTextBox();
            this.btnSavePOKain = new MetroFramework.Controls.MetroButton();
            this.btnExitPOKain = new MetroFramework.Controls.MetroButton();
            this.detailPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPOBindingSource)).BeginInit();
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
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Bahan Code";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(175, 165);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 19);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Bahan Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(175, 199);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "Warna Code";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(173, 239);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 19);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Warna Name";
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
            // cboMaterialCode
            // 
            this.cboMaterialCode.DataSource = this.materialBindingSource;
            this.cboMaterialCode.DisplayMember = "MaterialCode";
            this.cboMaterialCode.FormattingEnabled = true;
            this.cboMaterialCode.ItemHeight = 23;
            this.cboMaterialCode.Location = new System.Drawing.Point(270, 123);
            this.cboMaterialCode.Name = "cboMaterialCode";
            this.cboMaterialCode.Size = new System.Drawing.Size(162, 29);
            this.cboMaterialCode.TabIndex = 1;
            this.cboMaterialCode.UseSelectable = true;
            this.cboMaterialCode.ValueMember = "MaterialID";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(Project.Material);
            // 
            // txtAddMaterialName
            // 
            // 
            // 
            // 
            this.txtAddMaterialName.CustomButton.Image = null;
            this.txtAddMaterialName.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtAddMaterialName.CustomButton.Name = "";
            this.txtAddMaterialName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddMaterialName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddMaterialName.CustomButton.TabIndex = 1;
            this.txtAddMaterialName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddMaterialName.CustomButton.UseSelectable = true;
            this.txtAddMaterialName.CustomButton.Visible = false;
            this.txtAddMaterialName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "MaterialName", true));
            this.txtAddMaterialName.Lines = new string[0];
            this.txtAddMaterialName.Location = new System.Drawing.Point(270, 165);
            this.txtAddMaterialName.MaxLength = 32767;
            this.txtAddMaterialName.Name = "txtAddMaterialName";
            this.txtAddMaterialName.PasswordChar = '\0';
            this.txtAddMaterialName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddMaterialName.SelectedText = "";
            this.txtAddMaterialName.SelectionLength = 0;
            this.txtAddMaterialName.SelectionStart = 0;
            this.txtAddMaterialName.ShortcutsEnabled = true;
            this.txtAddMaterialName.Size = new System.Drawing.Size(162, 23);
            this.txtAddMaterialName.TabIndex = 2;
            this.txtAddMaterialName.UseSelectable = true;
            this.txtAddMaterialName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddMaterialName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboColorCode
            // 
            this.cboColorCode.DataSource = this.colorBindingSource;
            this.cboColorCode.DisplayMember = "ColorCode";
            this.cboColorCode.FormattingEnabled = true;
            this.cboColorCode.ItemHeight = 23;
            this.cboColorCode.Location = new System.Drawing.Point(270, 199);
            this.cboColorCode.Name = "cboColorCode";
            this.cboColorCode.Size = new System.Drawing.Size(162, 29);
            this.cboColorCode.TabIndex = 3;
            this.cboColorCode.UseSelectable = true;
            this.cboColorCode.ValueMember = "ColorID";
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(Project.Color);
            // 
            // txtAddColorName
            // 
            // 
            // 
            // 
            this.txtAddColorName.CustomButton.Image = null;
            this.txtAddColorName.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.txtAddColorName.CustomButton.Name = "";
            this.txtAddColorName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddColorName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddColorName.CustomButton.TabIndex = 1;
            this.txtAddColorName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddColorName.CustomButton.UseSelectable = true;
            this.txtAddColorName.CustomButton.Visible = false;
            this.txtAddColorName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colorBindingSource, "ColorName", true));
            this.txtAddColorName.Lines = new string[0];
            this.txtAddColorName.Location = new System.Drawing.Point(270, 239);
            this.txtAddColorName.MaxLength = 32767;
            this.txtAddColorName.Name = "txtAddColorName";
            this.txtAddColorName.PasswordChar = '\0';
            this.txtAddColorName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddColorName.SelectedText = "";
            this.txtAddColorName.SelectionLength = 0;
            this.txtAddColorName.SelectionStart = 0;
            this.txtAddColorName.ShortcutsEnabled = true;
            this.txtAddColorName.Size = new System.Drawing.Size(162, 23);
            this.txtAddColorName.TabIndex = 4;
            this.txtAddColorName.UseSelectable = true;
            this.txtAddColorName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddColorName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // detailPOBindingSource
            // 
            this.detailPOBindingSource.DataSource = typeof(Project.DetailPO);
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
            this.Controls.Add(this.txtAddColorName);
            this.Controls.Add(this.cboColorCode);
            this.Controls.Add(this.txtAddMaterialName);
            this.Controls.Add(this.cboMaterialCode);
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
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailPOBindingSource)).EndInit();
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
        private MetroFramework.Controls.MetroComboBox cboMaterialCode;
        private MetroFramework.Controls.MetroTextBox txtAddMaterialName;
        private MetroFramework.Controls.MetroComboBox cboColorCode;
        private MetroFramework.Controls.MetroTextBox txtAddColorName;
        private MetroFramework.Controls.MetroButton btnSavePOKain;
        private MetroFramework.Controls.MetroButton btnExitPOKain;
        private MetroFramework.Controls.MetroTextBox txtAddQuantity;
        private MetroFramework.Controls.MetroTextBox txtAddPrice;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private System.Windows.Forms.BindingSource detailPOBindingSource;
    }
}