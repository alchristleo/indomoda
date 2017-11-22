using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Project.Helpers;
using System.Data.SqlClient;

namespace Project
{
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        string path = Environment.CurrentDirectory + "/" + "temp.txt";
        string a = EncryptDecrypt.Decrypt("sctO0FZzAhxvUNDOt9Uh0Ir61idWtENbWOyR/+XY33E=");
        string b = EncryptDecrypt.Decrypt("lxtwZ8VbPKj9t3n7FdVdq4ROv0B0n78O5Emo17ah5l0=");
        string c = EncryptDecrypt.Decrypt("gTViqhlEMV6d8r2vAVqgIPnqk1P7YtXXF+IKYy/PDKo=");
        string d = EncryptDecrypt.Decrypt("STbMPl+2rk9nfpdVQZ0b9kXzi33u8yRVI5cTYmImFgI=");

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(MainMenu_FormClosed);
            Close();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != c)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    supplier.Show();
                }
            }
        }

        private void pembeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pembeli pembeli = new Pembeli();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != c)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pembeli.Show();
                }
            }
        }

        private void masterBahanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterBahan bahan = new MasterBahan();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != c)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bahan.Show();
                }
            }
        }

        private void warnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Warna warna = new Warna();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != c)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    warna.Show();
                }
            }
        }

        private void karyawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Karyawan karyawan = new Karyawan();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != c)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    karyawan.Show();
                }
            }
        }

        private void pOKainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            poKain poKain = new poKain();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != c)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    poKain.Show();
                }
            }
        }

        private void penerimaanKainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenerimaanKain penerimaanKain = new PenerimaanKain();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != b && decryptText != c)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    penerimaanKain.Show();
                }
            }
        }

        private void pemotonganKainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PemotonganKain pemotonganKain = new PemotonganKain();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != c)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pemotonganKain.Show();
                }
            }
        }

        private void penerimaanTukangPotongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenerimaanTukangPotong penerimaanTukangPotong = new PenerimaanTukangPotong();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != c)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    penerimaanTukangPotong.Show();
                }
            }
        }

        private void sPKSablonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SPKSablon spkSablon = new SPKSablon();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != c)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    spkSablon.Show();
                }
            }
        }

        private void sPKBordirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SPKBordir spkBordir = new SPKBordir();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != c)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    spkBordir.Show();
                }
            }
        }

        private void sPKCMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SPKCmt spkCmt = new SPKCmt();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != c)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    spkCmt.Show();
                }
            }
        }

        private void sablonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenerimaanSablon penerimaanSablon = new PenerimaanSablon();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != c)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    penerimaanSablon.Show();
                }
            }
        }

        private void bordirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenerimaanBordir penerimaanBordir = new PenerimaanBordir();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != c)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    penerimaanBordir.Show();
                }
            }
        }

        private void cMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenerimaanCMT penerimaanCmt = new PenerimaanCMT();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != c)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    penerimaanCmt.Show();
                }
            }
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailLogForm logForm = new DetailLogForm();
            logForm.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void MainMenu_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                try
                {
                    using (StreamReader streamReader = new StreamReader("temp.txt"))
                    {
                        string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                        var dba = GenericQuery.SqlQuerySingle<User>("SELECT u.UserID, u.UserName, u.UserPassword, u.UserRole FROM Users u WHERE u.UserName = '" + decryptText + "'");
                        string logAct = dba.UserRole.ToString() + " is logged out";
                        string uName = decryptText;
                        int uID = Convert.ToInt32(dba.UserID.ToString());
                        int a = GenericQuery.ExecSQLCommand("INSERT INTO DetailLogs (id, UserID, Datetime, activity) VALUES(@id, @UserID, @Datetime, @activity)", new[] {
                                new SqlParameter("@id", db.DetailLogs.AsEnumerable().LastOrDefault() == null ? 1 : db.DetailLogs.AsEnumerable().LastOrDefault().id + 1),
                                new SqlParameter("@UserID", uID),
                                new SqlParameter("@Datetime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                                new SqlParameter("@activity", logAct)
                            });
                        db.SaveChangesAsync().Wait();
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
