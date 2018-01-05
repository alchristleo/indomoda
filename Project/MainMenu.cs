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
using Project.Models;

namespace Project
{
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        public static int CD;
        public static string NS;
        public static string CW;
        public static string JS;
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
            List<SPKNotifierModel> tempList = GenericQuery.SqlQuery<SPKNotifierModel>("SELECT p.idListPTP, p.idPenerimaanTukangPotong, p.noSeri, p.model, p.ColorID, p.merk, p.ukuran, p.quantity, p.statusSPKSablon, p.statusSPKBordir, p.statusSPKCMT, p.statusNoSeri, p.idSPKSablon, p.idSPKBordir, p.idSPKCMT, q.Date_insert, q.NotifyStatus FROM ListPenerimaanTukangPotong p JOIN DatetimeNotification q ON p.noSeri = q.noSeri WHERE (p.idSPKSablon = '" + 0 + "' AND p.idSPKBordir = '" + 0 + "') OR p.idSPKCMT = '" + 0 + "'");
            List<QuantityRecord> tempSablon = GenericQuery.SqlQuery<QuantityRecord>("SELECT lp.id, lp.noSeri, lp.qtyAwalSablon, lp.qtySablonBS, lp.qtySablonHilang, lp.qtyAwalBordir, qtyBordirBS, lp.qtyBordirHilang, lp.qtyAwalCMT, lp.qtyCMTBS, lp.qtyCMTHilang FROM QuantityRecord lp WHERE lp.qtyAwalSablon != '"+0+"' AND (lp.qtySablonBS + lp.qtySablonHilang) > 0.02 * lp.qtyAwalSablon");
            List<QuantityRecord> tempBordir = GenericQuery.SqlQuery<QuantityRecord>("SELECT lp.id, lp.noSeri, lp.qtyAwalSablon, lp.qtySablonBS, lp.qtySablonHilang, lp.qtyAwalBordir, qtyBordirBS, lp.qtyBordirHilang, lp.qtyAwalCMT, lp.qtyCMTBS, lp.qtyCMTHilang FROM QuantityRecord lp WHERE lp.qtyAwalBordir != '" + 0 + "' AND (lp.qtyBordirBS + lp.qtyBordirHilang) > 0.02 * lp.qtyAwalBordir");
            List<QuantityRecord> tempCMT = GenericQuery.SqlQuery<QuantityRecord>("SELECT lp.id, lp.noSeri, lp.qtyAwalSablon, lp.qtySablonBS, lp.qtySablonHilang, lp.qtyAwalBordir, qtyBordirBS, lp.qtyBordirHilang, lp.qtyAwalCMT, lp.qtyCMTBS, lp.qtyCMTHilang FROM QuantityRecord lp WHERE lp.qtyAwalCMT != '" + 0 + "' AND (lp.qtyCMTBS + lp.qtyCMTHilang) > 0.02 * lp.qtyAwalCMT");
            List<MetroFramework.Controls.MetroLabel> labels = new List<MetroFramework.Controls.MetroLabel>();
            List<MetroFramework.Controls.MetroLabel> labels2 = new List<MetroFramework.Controls.MetroLabel>();
            List<MetroFramework.Controls.MetroLabel> labels3 = new List<MetroFramework.Controls.MetroLabel>();
            List<MetroFramework.Controls.MetroLabel> labels4 = new List<MetroFramework.Controls.MetroLabel>();
            Random r = new Random();
            CD = tempList.Count + tempSablon.Count + tempBordir.Count + tempCMT.Count;

            labelCount.Text = CD.ToString();
            if (tempList.Count > 0)
            {
                //Label[] labels = new Label[tempList.Count];
                for (int i = 0; i < tempList.Count; i++)
                {
                    labels.Add(new MetroFramework.Controls.MetroLabel());
                    System.Drawing.Point productLabelsPoint = new System.Drawing.Point(0, i * 40);
                    (labels[i]).Location = productLabelsPoint;
                    (labels[i]).BackColor = System.Drawing.Color.Tomato;
                    (labels[i]).FontSize = MetroFramework.MetroLabelSize.Tall;
                    (labels[i]).FontWeight = MetroFramework.MetroLabelWeight.Regular;
                    (labels[i]).ForeColor = System.Drawing.SystemColors.ButtonFace;
                    (labels[i]).Size = new System.Drawing.Size(951, 31);
                    (labels[i]).UseCustomBackColor = true;
                    (labels[i]).UseCustomForeColor = true;
                    (labels[i]).Cursor = System.Windows.Forms.Cursors.Hand;
                    panel1.Controls.Add(labels[i] as MetroFramework.Controls.MetroLabel);
                    if (tempList[i].idSPKSablon == 0 && tempList[i].idSPKBordir == 0)
                    {
                        (labels[i]).Text = "No Seri: " + tempList[i].noSeri + " belum dimasukkan ke dalam SPK Sablon maupun SPK Bordir";
                    }
                    else
                    {
                        (labels[i]).Text = "No Seri: " + tempList[i].noSeri + " belum dimasukkan ke dalam SPK CMT";
                    }

                    (labels[i]).Click += new EventHandler(labels_Click);
                }
            }

            if (tempSablon.Count > 0)
            {
                for (int i = 0; i < tempSablon.Count; i++)
                {
                    labels2.Add(new MetroFramework.Controls.MetroLabel());
                    System.Drawing.Point productLabelsPoint = new System.Drawing.Point(0, i * 40);
                    (labels2[i]).Location = productLabelsPoint;
                    (labels2[i]).BackColor = System.Drawing.Color.Thistle;
                    (labels2[i]).FontSize = MetroFramework.MetroLabelSize.Tall;
                    (labels2[i]).FontWeight = MetroFramework.MetroLabelWeight.Regular;
                    (labels2[i]).ForeColor = System.Drawing.SystemColors.ControlText;
                    (labels2[i]).Size = new System.Drawing.Size(951, 31);
                    (labels2[i]).UseCustomBackColor = true;
                    (labels2[i]).UseCustomForeColor = true;
                    (labels2[i]).Cursor = System.Windows.Forms.Cursors.Hand;
                    panel2.Controls.Add(labels2[i] as MetroFramework.Controls.MetroLabel);
                    if (tempSablon[i].qtySablonBS + tempSablon[i].qtySablonHilang > 0.02 * tempSablon[i].qtyAwalSablon)
                    {
                        (labels2[i]).Text = "No Seri: " + tempSablon[i].noSeri + " quantity barang hilang dan BS melebihi 2% dari quantity awal Sablon";
                    }

                    (labels2[i]).Click += new EventHandler(labels2_Click);
                }
            }

            if (tempBordir.Count > 0)
            {
                for (int i = 0; i < tempSablon.Count; i++)
                {
                    labels3.Add(new MetroFramework.Controls.MetroLabel());
                    System.Drawing.Point productLabelsPoint = new System.Drawing.Point(0, (i * 40) + (tempSablon.Count * 40));
                    (labels3[i]).Location = productLabelsPoint;
                    (labels3[i]).BackColor = System.Drawing.Color.LightGreen;
                    (labels3[i]).FontSize = MetroFramework.MetroLabelSize.Tall;
                    (labels3[i]).FontWeight = MetroFramework.MetroLabelWeight.Regular;
                    (labels3[i]).ForeColor = System.Drawing.SystemColors.ControlText;
                    (labels3[i]).Size = new System.Drawing.Size(951, 31);
                    (labels3[i]).UseCustomBackColor = true;
                    (labels3[i]).UseCustomForeColor = true;
                    (labels3[i]).Cursor = System.Windows.Forms.Cursors.Hand;
                    panel2.Controls.Add(labels3[i] as MetroFramework.Controls.MetroLabel);
                    if (tempBordir[i].qtyBordirBS + tempBordir[i].qtyBordirHilang > 0.02 * tempBordir[i].qtyAwalBordir)
                    {
                        (labels3[i]).Text = "No Seri: " + tempBordir[i].noSeri + " quantity barang hilang dan BS melebihi 2% dari quantity awal Bordir";
                    }

                    (labels3[i]).Click += new EventHandler(labels3_Click);
                }
            }

            if (tempCMT.Count > 0)
            {
                for (int i = 0; i < tempCMT.Count; i++)
                {
                    labels4.Add(new MetroFramework.Controls.MetroLabel());
                    System.Drawing.Point productLabelsPoint = new System.Drawing.Point(0, (i * 40) + (tempSablon.Count * 40) + (tempBordir.Count * 40));
                    (labels4[i]).Location = productLabelsPoint;
                    (labels4[i]).BackColor = System.Drawing.Color.LightSteelBlue;
                    (labels4[i]).FontSize = MetroFramework.MetroLabelSize.Tall;
                    (labels4[i]).FontWeight = MetroFramework.MetroLabelWeight.Regular;
                    (labels4[i]).ForeColor = System.Drawing.SystemColors.ControlText;
                    (labels4[i]).Size = new System.Drawing.Size(951, 31);
                    (labels4[i]).UseCustomBackColor = true;
                    (labels4[i]).UseCustomForeColor = true;
                    (labels4[i]).Cursor = System.Windows.Forms.Cursors.Hand;
                    panel2.Controls.Add(labels4[i] as MetroFramework.Controls.MetroLabel);
                    if (tempCMT[i].qtyCMTBS + tempCMT[i].qtyCMTHilang > 0.02 * tempCMT[i].qtyAwalCMT)
                    {
                        (labels4[i]).Text = "No Seri: " + tempCMT[i].noSeri + " quantity barang hilang dan BS melebihi 2% dari quantity awal CMT";
                    }

                    (labels4[i]).Click += new EventHandler(labels4_Click);
                }
            }
        }

        protected void labels_Click(object sender, EventArgs e)
        {
            //attempt to cast the sender as a label
            MetroFramework.Controls.MetroLabel lbl = sender as MetroFramework.Controls.MetroLabel;

            //if the cast was successful (i.e. not null), show notification details
            if (lbl != null)
            {
                string[] separators = { ",", ".", "!", "?", ";", ":", " " };
                string value = lbl.ToString();
                string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string value2 = value.Split(':')[2];
                NotificationDetail nd = new NotificationDetail();
                NS = words[6];
                CW = "No Seri - "+value2;
                nd.Show();
            }
        }

        protected void labels2_Click(object sender, EventArgs e)
        {
            //attempt to cast the sender as a label
            MetroFramework.Controls.MetroLabel lbl = sender as MetroFramework.Controls.MetroLabel;

            //if the cast was successful (i.e. not null), show notification details
            if (lbl != null)
            {
                string[] separators = { ",", ".", "!", "?", ";", ":", " " };
                string value = lbl.ToString();
                string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string value2 = value.Split(':')[2];
                NotificationQuantity nq = new NotificationQuantity();
                JS = "Sablon";
                NS = words[6];
                CW = "No Seri - " + value2;
                nq.Show();
            }
        }

        protected void labels3_Click(object sender, EventArgs e)
        {
            //attempt to cast the sender as a label
            MetroFramework.Controls.MetroLabel lbl = sender as MetroFramework.Controls.MetroLabel;

            //if the cast was successful (i.e. not null), show notification details
            if (lbl != null)
            {
                string[] separators = { ",", ".", "!", "?", ";", ":", " " };
                string value = lbl.ToString();
                string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string value2 = value.Split(':')[2];
                NotificationQuantity nq = new NotificationQuantity();
                JS = "Bordir";
                NS = words[6];
                CW = "No Seri - " + value2;
                nq.Show();
            }
        }

        protected void labels4_Click(object sender, EventArgs e)
        {
            //attempt to cast the sender as a label
            MetroFramework.Controls.MetroLabel lbl = sender as MetroFramework.Controls.MetroLabel;

            //if the cast was successful (i.e. not null), show notification details
            if (lbl != null)
            {
                string[] separators = { ",", ".", "!", "?", ";", ":", " " };
                string value = lbl.ToString();
                string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string value2 = value.Split(':')[2];
                NotificationQuantity nq = new NotificationQuantity();
                JS = "CMT";
                NS = words[6];
                CW = "No Seri - " + value2;
                nq.Show();
            }
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


        private void penjualanBajuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PenjualanBaju penjualanBaju = new PenjualanBaju();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != d)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    penjualanBaju.Show();
                }
            }
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

        private void stockKainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockKain stockKain = new StockKain();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != d)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    stockKain.Show();
                }
            }
        }

        private void stockBajuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockBaju stockBaju = new StockBaju();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != d)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    stockBaju.Show();
                }
            }
        }

        private void pemotonganKainToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LaporanPemotonganKain lpk = new LaporanPemotonganKain();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != d)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lpk.Show();
                }
            }
        }

        private void sablonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LaporanPenerimaanSablon lps = new LaporanPenerimaanSablon();
            using (StreamReader streamReader = new StreamReader("temp.txt"))
            {
                string decryptText = EncryptDecrypt.Decrypt(streamReader.ReadLine());
                if (decryptText != a && decryptText != d)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry you can not access this menu, please contact administrator for more info", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lps.Show();
                }
            }
        }
    }
}
