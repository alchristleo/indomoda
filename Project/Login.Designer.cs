namespace Project
{
    partial class Login
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
            this.txtPasswordLogin = new MetroFramework.Controls.MetroTextBox();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.txtUsernameLogin = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtPasswordLogin
            // 
            // 
            // 
            // 
            this.txtPasswordLogin.CustomButton.Image = null;
            this.txtPasswordLogin.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txtPasswordLogin.CustomButton.Name = "";
            this.txtPasswordLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPasswordLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswordLogin.CustomButton.TabIndex = 1;
            this.txtPasswordLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasswordLogin.CustomButton.UseSelectable = true;
            this.txtPasswordLogin.CustomButton.Visible = false;
            this.txtPasswordLogin.Lines = new string[0];
            this.txtPasswordLogin.Location = new System.Drawing.Point(236, 158);
            this.txtPasswordLogin.MaxLength = 32767;
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordLogin.SelectedText = "";
            this.txtPasswordLogin.SelectionLength = 0;
            this.txtPasswordLogin.SelectionStart = 0;
            this.txtPasswordLogin.ShortcutsEnabled = true;
            this.txtPasswordLogin.Size = new System.Drawing.Size(221, 23);
            this.txtPasswordLogin.TabIndex = 2;
            this.txtPasswordLogin.UseSelectable = true;
            this.txtPasswordLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasswordLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPasswordLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasswordLogin_KeyPress);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(127, 107);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 19);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "USERNAME";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(127, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 48);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(127, 158);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 19);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "PASSWORD";
            // 
            // txtUsernameLogin
            // 
            // 
            // 
            // 
            this.txtUsernameLogin.CustomButton.Image = null;
            this.txtUsernameLogin.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.txtUsernameLogin.CustomButton.Name = "";
            this.txtUsernameLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsernameLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsernameLogin.CustomButton.TabIndex = 1;
            this.txtUsernameLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsernameLogin.CustomButton.UseSelectable = true;
            this.txtUsernameLogin.CustomButton.Visible = false;
            this.txtUsernameLogin.Lines = new string[0];
            this.txtUsernameLogin.Location = new System.Drawing.Point(236, 103);
            this.txtUsernameLogin.MaxLength = 32767;
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.PasswordChar = '\0';
            this.txtUsernameLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsernameLogin.SelectedText = "";
            this.txtUsernameLogin.SelectionLength = 0;
            this.txtUsernameLogin.SelectionStart = 0;
            this.txtUsernameLogin.ShortcutsEnabled = true;
            this.txtUsernameLogin.Size = new System.Drawing.Size(221, 23);
            this.txtUsernameLogin.TabIndex = 1;
            this.txtUsernameLogin.UseSelectable = true;
            this.txtUsernameLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsernameLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsernameLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsernameLogin_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(348, 211);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(109, 48);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 320);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUsernameLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPasswordLogin);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Indomoda Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtPasswordLogin;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroTextBox txtUsernameLogin;
        private MetroFramework.Controls.MetroButton btnLogin;
    }
}