using Project.Helpers;
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
    public partial class NotificationDetail : MetroFramework.Forms.MetroForm
    {
        public NotificationDetail()
        {
            InitializeComponent();
        }

        private void NotificationDetail_Load(object sender, EventArgs e)
        {
            metroLabel8.Text = MainMenu.CW;
            using (indomodaEntities db = new indomodaEntities())
            {
                colorBindingSource.DataSource = db.Colors.ToList();
            }
            var x = MainMenu.NS;
            try
            {
                var dba = GenericQuery.SqlQuerySingle<ListPenerimaanTukangPotong>("SELECT lp.idListPTP, lp.idPenerimaanTukangPotong, lp.noSeri, lp.model, lp.ColorID, lp.merk, lp.ukuran, lp.quantity, lp.statusSPKSablon, lp.statusSPKBordir, lp.statusSPKCMT, lp.statusNoSeri, lp.idSPKSablon, lp.idSPKBordir, lp.idSPKCMT  FROM ListPenerimaanTukangPotong lp WHERE lp.noSeri = '" + x + "'");
                txtNoSeriTukangPotong.Text = dba.noSeri.ToString();
                txtModelTukangPotong.Text = dba.model.ToString();
                cboWarna.SelectedValue = dba.ColorID;
                txtMerkTukangPotong.Text = dba.merk.ToString();
                txtUkuranTukangPotong.Text = dba.ukuran.ToString();
                txtQtyTukangPotong.Text = dba.quantity.ToString();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "There is another same No. Seri", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
