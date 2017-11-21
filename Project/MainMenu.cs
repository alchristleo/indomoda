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
            supplier.Show();
        }

        private void pembeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pembeli pembeli = new Pembeli();
            pembeli.Show();
        }

        private void masterBahanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterBahan bahan = new MasterBahan();
            bahan.Show();
        }

        private void warnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Warna warna = new Warna();
            warna.Show();
        }

        private void karyawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Karyawan karyawan = new Karyawan();
            karyawan.Show();
        }

        private void pOKainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            poKain poKain = new poKain();
            poKain.Show();
        }

        private void penerimaanKainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenerimaanKain penerimaanKain = new PenerimaanKain();
            penerimaanKain.Show();
        }

        private void pemotonganKainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PemotonganKain pemotonganKain = new PemotonganKain();
            pemotonganKain.Show();
        }

        private void penerimaanTukangPotongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenerimaanTukangPotong penerimaanTukangPotong = new PenerimaanTukangPotong();
            penerimaanTukangPotong.Show();
        }

        private void sPKSablonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SPKSablon spkSablon = new SPKSablon();
            spkSablon.Show();
        }

        private void sPKBordirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SPKBordir spkBordir = new SPKBordir();
            spkBordir.Show();
        }

        private void sPKCMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SPKCmt spkCmt = new SPKCmt();
            spkCmt.Show();
        }

        private void sablonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenerimaanSablon penerimaanSablon = new PenerimaanSablon();
            penerimaanSablon.Show();
        }

        private void bordirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenerimaanBordir penerimaanBordir = new PenerimaanBordir();
            penerimaanBordir.Show();
        }

        private void cMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenerimaanCMT penerimaanCmt = new PenerimaanCMT();
            penerimaanCmt.Show();
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
