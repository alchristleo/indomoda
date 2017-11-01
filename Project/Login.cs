using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        indomodaEntities db;

        public Login()
        {
            InitializeComponent();
        }

        private void txtUsernameLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                txtPasswordLogin.Focus();
            }
        }

        private void txtPasswordLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            db = new indomodaEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.Configuration.LazyLoadingEnabled = false;

            if (String.IsNullOrEmpty(txtUsernameLogin.Text)) {
                MetroFramework.MetroMessageBox.Show(this, "Please enter your username!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsernameLogin.Focus();
                return;
            }else if (String.IsNullOrEmpty(txtPasswordLogin.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter your password!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPasswordLogin.Focus();
                return;
            }

            try
            {
                using (indomodaEntities login = new indomodaEntities())
                {
                    var query = from o in login.Users
                                where o.UserName == txtUsernameLogin.Text && o.UserPassword == txtPasswordLogin.Text
                                select o;
                    if (query.SingleOrDefault() != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Successfully login", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        
                        //PROCCESS AFTER LOGIN                        
                        MainMenu main = new MainMenu();
                        this.Hide();
                        main.Show();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Your username or password is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsernameLogin.Clear();
                        txtPasswordLogin.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
