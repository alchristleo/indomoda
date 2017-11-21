using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project.Helpers;
using System.IO;

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
                        try
                        {
                            var dba = GenericQuery.SqlQuerySingle<User>("SELECT u.UserID, u.UserName, u.UserPassword, u.UserRole FROM Users u WHERE u.UserName = '" + txtUsernameLogin.Text + "'");
                            string loginAct = dba.UserRole.ToString()+" is logged in";
                            int uID = Convert.ToInt32(dba.UserID.ToString());
                            int a = GenericQuery.ExecSQLCommand("INSERT INTO DetailLogs (id, UserID, Datetime, activity) VALUES(@id, @UserID, @Datetime, @activity)", new[] {
                                new SqlParameter("@id", db.DetailLogs.AsEnumerable().LastOrDefault() == null ? 1 : db.DetailLogs.AsEnumerable().LastOrDefault().id + 1),
                                new SqlParameter("@UserID", uID),
                                new SqlParameter("@Datetime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                                new SqlParameter("@activity", loginAct)
                            });
                            db.SaveChangesAsync().Wait();
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        MainMenu main = new MainMenu();
                        this.Hide();
                        main.Show();

                        using (StreamWriter streamWriter = new StreamWriter("temp.txt"))
                        {
                            string encryptedstring = EncryptDecrypt.encrypt(txtUsernameLogin.Text);
                            streamWriter.WriteLine(encryptedstring);
                        }
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
