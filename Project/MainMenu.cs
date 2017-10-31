using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
    }
}
