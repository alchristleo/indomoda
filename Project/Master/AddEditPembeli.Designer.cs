namespace Project
{
    partial class AddEditPembeli
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblCustomerID = new MetroFramework.Controls.MetroTextBox();
            this.bindingSourceCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.lblCustomerCode = new MetroFramework.Controls.MetroTextBox();
            this.lblCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.lblCustomerPhone = new MetroFramework.Controls.MetroTextBox();
            this.btnClearCustomer = new MetroFramework.Controls.MetroButton();
            this.btnSaveCustomer = new MetroFramework.Controls.MetroButton();
            this.lblCustomerAddress = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Customer ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(41, 151);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Customer Code";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(412, 151);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(106, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Customer Name";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(41, 217);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(117, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Customer Address";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(412, 217);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(107, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Customer Phone";
            // 
            // lblCustomerID
            // 
            // 
            // 
            // 
            this.lblCustomerID.CustomButton.Image = null;
            this.lblCustomerID.CustomButton.Location = new System.Drawing.Point(44, 1);
            this.lblCustomerID.CustomButton.Name = "";
            this.lblCustomerID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblCustomerID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCustomerID.CustomButton.TabIndex = 1;
            this.lblCustomerID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCustomerID.CustomButton.UseSelectable = true;
            this.lblCustomerID.CustomButton.Visible = false;
            this.lblCustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "CustomerID", true));
            this.lblCustomerID.Lines = new string[0];
            this.lblCustomerID.Location = new System.Drawing.Point(175, 96);
            this.lblCustomerID.MaxLength = 32767;
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.PasswordChar = '\0';
            this.lblCustomerID.ReadOnly = true;
            this.lblCustomerID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblCustomerID.SelectedText = "";
            this.lblCustomerID.SelectionLength = 0;
            this.lblCustomerID.SelectionStart = 0;
            this.lblCustomerID.ShortcutsEnabled = true;
            this.lblCustomerID.Size = new System.Drawing.Size(66, 23);
            this.lblCustomerID.TabIndex = 6;
            this.lblCustomerID.UseSelectable = true;
            this.lblCustomerID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblCustomerID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bindingSourceCustomer
            // 
            this.bindingSourceCustomer.DataSource = typeof(Project.Customer);
            // 
            // lblCustomerCode
            // 
            // 
            // 
            // 
            this.lblCustomerCode.CustomButton.Image = null;
            this.lblCustomerCode.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.lblCustomerCode.CustomButton.Name = "";
            this.lblCustomerCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblCustomerCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCustomerCode.CustomButton.TabIndex = 1;
            this.lblCustomerCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCustomerCode.CustomButton.UseSelectable = true;
            this.lblCustomerCode.CustomButton.Visible = false;
            this.lblCustomerCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "CustomerCode", true));
            this.lblCustomerCode.Lines = new string[0];
            this.lblCustomerCode.Location = new System.Drawing.Point(175, 151);
            this.lblCustomerCode.MaxLength = 32767;
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.PasswordChar = '\0';
            this.lblCustomerCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblCustomerCode.SelectedText = "";
            this.lblCustomerCode.SelectionLength = 0;
            this.lblCustomerCode.SelectionStart = 0;
            this.lblCustomerCode.ShortcutsEnabled = true;
            this.lblCustomerCode.Size = new System.Drawing.Size(183, 23);
            this.lblCustomerCode.TabIndex = 1;
            this.lblCustomerCode.UseSelectable = true;
            this.lblCustomerCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblCustomerCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCustomerName
            // 
            // 
            // 
            // 
            this.lblCustomerName.CustomButton.Image = null;
            this.lblCustomerName.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.lblCustomerName.CustomButton.Name = "";
            this.lblCustomerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCustomerName.CustomButton.TabIndex = 1;
            this.lblCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCustomerName.CustomButton.UseSelectable = true;
            this.lblCustomerName.CustomButton.Visible = false;
            this.lblCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "CustomerName", true));
            this.lblCustomerName.Lines = new string[0];
            this.lblCustomerName.Location = new System.Drawing.Point(548, 151);
            this.lblCustomerName.MaxLength = 32767;
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.PasswordChar = '\0';
            this.lblCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblCustomerName.SelectedText = "";
            this.lblCustomerName.SelectionLength = 0;
            this.lblCustomerName.SelectionStart = 0;
            this.lblCustomerName.ShortcutsEnabled = true;
            this.lblCustomerName.Size = new System.Drawing.Size(183, 23);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.UseSelectable = true;
            this.lblCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCustomerPhone
            // 
            // 
            // 
            // 
            this.lblCustomerPhone.CustomButton.Image = null;
            this.lblCustomerPhone.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.lblCustomerPhone.CustomButton.Name = "";
            this.lblCustomerPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lblCustomerPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCustomerPhone.CustomButton.TabIndex = 1;
            this.lblCustomerPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCustomerPhone.CustomButton.UseSelectable = true;
            this.lblCustomerPhone.CustomButton.Visible = false;
            this.lblCustomerPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "CustomerPhone", true));
            this.lblCustomerPhone.Lines = new string[0];
            this.lblCustomerPhone.Location = new System.Drawing.Point(548, 217);
            this.lblCustomerPhone.MaxLength = 32767;
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.PasswordChar = '\0';
            this.lblCustomerPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblCustomerPhone.SelectedText = "";
            this.lblCustomerPhone.SelectionLength = 0;
            this.lblCustomerPhone.SelectionStart = 0;
            this.lblCustomerPhone.ShortcutsEnabled = true;
            this.lblCustomerPhone.Size = new System.Drawing.Size(183, 23);
            this.lblCustomerPhone.TabIndex = 4;
            this.lblCustomerPhone.UseSelectable = true;
            this.lblCustomerPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblCustomerPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnClearCustomer
            // 
            this.btnClearCustomer.Location = new System.Drawing.Point(175, 336);
            this.btnClearCustomer.Name = "btnClearCustomer";
            this.btnClearCustomer.Size = new System.Drawing.Size(97, 50);
            this.btnClearCustomer.TabIndex = 11;
            this.btnClearCustomer.Text = "CLEAR";
            this.btnClearCustomer.UseSelectable = true;
            this.btnClearCustomer.Click += new System.EventHandler(this.btnClearCustomer_Click);
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Location = new System.Drawing.Point(494, 336);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(97, 50);
            this.btnSaveCustomer.TabIndex = 5;
            this.btnSaveCustomer.Text = "SAVE";
            this.btnSaveCustomer.UseSelectable = true;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // lblCustomerAddress
            // 
            // 
            // 
            // 
            this.lblCustomerAddress.CustomButton.Image = null;
            this.lblCustomerAddress.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.lblCustomerAddress.CustomButton.Name = "";
            this.lblCustomerAddress.CustomButton.Size = new System.Drawing.Size(63, 63);
            this.lblCustomerAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCustomerAddress.CustomButton.TabIndex = 1;
            this.lblCustomerAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblCustomerAddress.CustomButton.UseSelectable = true;
            this.lblCustomerAddress.CustomButton.Visible = false;
            this.lblCustomerAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCustomer, "CustomerAddress", true));
            this.lblCustomerAddress.Lines = new string[0];
            this.lblCustomerAddress.Location = new System.Drawing.Point(175, 217);
            this.lblCustomerAddress.MaxLength = 32767;
            this.lblCustomerAddress.Multiline = true;
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.PasswordChar = '\0';
            this.lblCustomerAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblCustomerAddress.SelectedText = "";
            this.lblCustomerAddress.SelectionLength = 0;
            this.lblCustomerAddress.SelectionStart = 0;
            this.lblCustomerAddress.ShortcutsEnabled = true;
            this.lblCustomerAddress.Size = new System.Drawing.Size(206, 65);
            this.lblCustomerAddress.TabIndex = 3;
            this.lblCustomerAddress.UseSelectable = true;
            this.lblCustomerAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lblCustomerAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddEditPembeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 436);
            this.Controls.Add(this.btnSaveCustomer);
            this.Controls.Add(this.btnClearCustomer);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerCode);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddEditPembeli";
            this.Text = "Add and Edit Customer";
            this.Load += new System.EventHandler(this.AddEditPembeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox lblCustomerID;
        private MetroFramework.Controls.MetroTextBox lblCustomerCode;
        private MetroFramework.Controls.MetroTextBox lblCustomerName;
        private MetroFramework.Controls.MetroTextBox lblCustomerPhone;
        private System.Windows.Forms.BindingSource bindingSourceCustomer;
        private MetroFramework.Controls.MetroButton btnClearCustomer;
        private MetroFramework.Controls.MetroButton btnSaveCustomer;
        private MetroFramework.Controls.MetroTextBox lblCustomerAddress;
    }
}