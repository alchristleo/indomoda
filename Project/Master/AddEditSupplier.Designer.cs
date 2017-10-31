namespace Project
{
    partial class AddEditSupplier
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
            this.btnSaveSupplier = new MetroFramework.Controls.MetroButton();
            this.btnClearSupplier = new MetroFramework.Controls.MetroButton();
            this.lblSupplierPhone = new MetroFramework.Controls.MetroTextBox();
            this.lblSupplierAddress = new MetroFramework.Controls.MetroTextBox();
            this.lblSupplierName = new MetroFramework.Controls.MetroTextBox();
            this.lblSupplierCode = new MetroFramework.Controls.MetroTextBox();
            this.lblSupplierID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bindingSourceSupplier = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveSupplier
            // 
            this.btnSaveSupplier.Location = new System.Drawing.Point(495, 338);
            this.btnSaveSupplier.Name = "btnSaveSupplier";
            this.btnSaveSupplier.Size = new System.Drawing.Size(97, 50);
            this.btnSaveSupplier.TabIndex = 5;
            this.btnSaveSupplier.Text = "SAVE";
            this.btnSaveSupplier.UseSelectable = true;
            this.btnSaveSupplier.Click += new System.EventHandler(this.btnSaveSupplier_Click);
            // 
            // btnClearSupplier
            // 
            this.btnClearSupplier.Location = new System.Drawing.Point(176, 338);
            this.btnClearSupplier.Name = "btnClearSupplier";
            this.btnClearSupplier.Size = new System.Drawing.Size(97, 50);
            this.btnClearSupplier.TabIndex = 23;
            this.btnClearSupplier.Text = "CLEAR";
            this.btnClearSupplier.UseSelectable = true;
            this.btnClearSupplier.Click += new System.EventHandler(this.btnClearSupplier_Click);
            // 
            // lblSupplierPhone
            // 
            // 
            // 
            // 
            this.lblSupplierPhone.CustomButton.Image = null;
            this.lblSupplierPhone.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.lblSupplierPhone.CustomButton.Name = "";
            this.lblSupplierPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblSupplierPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSupplierPhone.CustomButton.TabIndex = 1;
            this.lblSupplierPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSupplierPhone.CustomButton.UseSelectable = true;
            this.lblSupplierPhone.CustomButton.Visible = false;
            this.lblSupplierPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSupplier, "SupplierPhone", true));
            this.lblSupplierPhone.Lines = new string[0];
            this.lblSupplierPhone.Location = new System.Drawing.Point(549, 219);
            this.lblSupplierPhone.MaxLength = 32767;
            this.lblSupplierPhone.Name = "lblSupplierPhone";
            this.lblSupplierPhone.PasswordChar = '\0';
            this.lblSupplierPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblSupplierPhone.SelectedText = "";
            this.lblSupplierPhone.SelectionLength = 0;
            this.lblSupplierPhone.SelectionStart = 0;
            this.lblSupplierPhone.ShortcutsEnabled = true;
            this.lblSupplierPhone.Size = new System.Drawing.Size(183, 23);
            this.lblSupplierPhone.TabIndex = 4;
            this.lblSupplierPhone.UseSelectable = true;
            this.lblSupplierPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblSupplierPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSupplierAddress
            // 
            // 
            // 
            // 
            this.lblSupplierAddress.CustomButton.Image = null;
            this.lblSupplierAddress.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.lblSupplierAddress.CustomButton.Name = "";
            this.lblSupplierAddress.CustomButton.Size = new System.Drawing.Size(63, 63);
            this.lblSupplierAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSupplierAddress.CustomButton.TabIndex = 1;
            this.lblSupplierAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSupplierAddress.CustomButton.UseSelectable = true;
            this.lblSupplierAddress.CustomButton.Visible = false;
            this.lblSupplierAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSupplier, "SupplierAddress", true));
            this.lblSupplierAddress.Lines = new string[0];
            this.lblSupplierAddress.Location = new System.Drawing.Point(176, 219);
            this.lblSupplierAddress.MaxLength = 32767;
            this.lblSupplierAddress.Multiline = true;
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.PasswordChar = '\0';
            this.lblSupplierAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblSupplierAddress.SelectedText = "";
            this.lblSupplierAddress.SelectionLength = 0;
            this.lblSupplierAddress.SelectionStart = 0;
            this.lblSupplierAddress.ShortcutsEnabled = true;
            this.lblSupplierAddress.Size = new System.Drawing.Size(206, 65);
            this.lblSupplierAddress.TabIndex = 3;
            this.lblSupplierAddress.UseSelectable = true;
            this.lblSupplierAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblSupplierAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSupplierName
            // 
            // 
            // 
            // 
            this.lblSupplierName.CustomButton.Image = null;
            this.lblSupplierName.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.lblSupplierName.CustomButton.Name = "";
            this.lblSupplierName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblSupplierName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSupplierName.CustomButton.TabIndex = 1;
            this.lblSupplierName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSupplierName.CustomButton.UseSelectable = true;
            this.lblSupplierName.CustomButton.Visible = false;
            this.lblSupplierName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSupplier, "SupplierName", true));
            this.lblSupplierName.Lines = new string[0];
            this.lblSupplierName.Location = new System.Drawing.Point(549, 153);
            this.lblSupplierName.MaxLength = 32767;
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.PasswordChar = '\0';
            this.lblSupplierName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblSupplierName.SelectedText = "";
            this.lblSupplierName.SelectionLength = 0;
            this.lblSupplierName.SelectionStart = 0;
            this.lblSupplierName.ShortcutsEnabled = true;
            this.lblSupplierName.Size = new System.Drawing.Size(183, 23);
            this.lblSupplierName.TabIndex = 2;
            this.lblSupplierName.UseSelectable = true;
            this.lblSupplierName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblSupplierName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSupplierCode
            // 
            // 
            // 
            // 
            this.lblSupplierCode.CustomButton.Image = null;
            this.lblSupplierCode.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.lblSupplierCode.CustomButton.Name = "";
            this.lblSupplierCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblSupplierCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSupplierCode.CustomButton.TabIndex = 1;
            this.lblSupplierCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSupplierCode.CustomButton.UseSelectable = true;
            this.lblSupplierCode.CustomButton.Visible = false;
            this.lblSupplierCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSupplier, "SupplierCode", true));
            this.lblSupplierCode.Lines = new string[0];
            this.lblSupplierCode.Location = new System.Drawing.Point(176, 153);
            this.lblSupplierCode.MaxLength = 32767;
            this.lblSupplierCode.Name = "lblSupplierCode";
            this.lblSupplierCode.PasswordChar = '\0';
            this.lblSupplierCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblSupplierCode.SelectedText = "";
            this.lblSupplierCode.SelectionLength = 0;
            this.lblSupplierCode.SelectionStart = 0;
            this.lblSupplierCode.ShortcutsEnabled = true;
            this.lblSupplierCode.Size = new System.Drawing.Size(183, 23);
            this.lblSupplierCode.TabIndex = 1;
            this.lblSupplierCode.UseSelectable = true;
            this.lblSupplierCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblSupplierCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSupplierID
            // 
            // 
            // 
            // 
            this.lblSupplierID.CustomButton.Image = null;
            this.lblSupplierID.CustomButton.Location = new System.Drawing.Point(44, 1);
            this.lblSupplierID.CustomButton.Name = "";
            this.lblSupplierID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblSupplierID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblSupplierID.CustomButton.TabIndex = 1;
            this.lblSupplierID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblSupplierID.CustomButton.UseSelectable = true;
            this.lblSupplierID.CustomButton.Visible = false;
            this.lblSupplierID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSupplier, "SupplierID", true));
            this.lblSupplierID.Lines = new string[0];
            this.lblSupplierID.Location = new System.Drawing.Point(176, 98);
            this.lblSupplierID.MaxLength = 32767;
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.PasswordChar = '\0';
            this.lblSupplierID.ReadOnly = true;
            this.lblSupplierID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblSupplierID.SelectedText = "";
            this.lblSupplierID.SelectionLength = 0;
            this.lblSupplierID.SelectionStart = 0;
            this.lblSupplierID.ShortcutsEnabled = true;
            this.lblSupplierID.Size = new System.Drawing.Size(66, 23);
            this.lblSupplierID.TabIndex = 22;
            this.lblSupplierID.UseSelectable = true;
            this.lblSupplierID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblSupplierID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(413, 219);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(98, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Supplier Phone";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(42, 219);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(108, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Supplier Address";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(413, 153);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Supplier Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(42, 153);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Supplier Code";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(42, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Supplier ID";
            // 
            // bindingSourceSupplier
            // 
            this.bindingSourceSupplier.DataSource = typeof(Project.IndomodaSupplier);
            // 
            // AddEditSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 435);
            this.Controls.Add(this.btnSaveSupplier);
            this.Controls.Add(this.btnClearSupplier);
            this.Controls.Add(this.lblSupplierPhone);
            this.Controls.Add(this.lblSupplierAddress);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblSupplierCode);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddEditSupplier";
            this.Text = "Add and Edit Supplier";
            this.Load += new System.EventHandler(this.AddEditSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSaveSupplier;
        private MetroFramework.Controls.MetroButton btnClearSupplier;
        private MetroFramework.Controls.MetroTextBox lblSupplierPhone;
        private MetroFramework.Controls.MetroTextBox lblSupplierAddress;
        private MetroFramework.Controls.MetroTextBox lblSupplierName;
        private MetroFramework.Controls.MetroTextBox lblSupplierCode;
        private MetroFramework.Controls.MetroTextBox lblSupplierID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.BindingSource bindingSourceSupplier;
    }
}