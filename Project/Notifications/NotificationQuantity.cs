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
    public partial class NotificationQuantity : MetroFramework.Forms.MetroForm
    {
        public NotificationQuantity()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NotificationQuantity_Load(object sender, EventArgs e)
        {
            metroLabel8.Text = MainMenu.CW;
            using (indomodaEntities db = new indomodaEntities())
            {
                colorBindingSource.DataSource = db.Colors.ToList();
            }
            var x = MainMenu.NS;
            var y = MainMenu.JS;
            var dba = GenericQuery.SqlQuerySingle<ListPenerimaanTukangPotong>("SELECT lp.idListPTP, lp.idPenerimaanTukangPotong, lp.noSeri, lp.model, lp.ColorID, lp.merk, lp.ukuran, lp.quantity, lp.statusSPKSablon, lp.statusSPKBordir, lp.statusSPKCMT, lp.statusNoSeri, lp.idSPKSablon, lp.idSPKBordir, lp.idSPKCMT  FROM ListPenerimaanTukangPotong lp WHERE lp.noSeri = '" + x + "'");
            var dbc = GenericQuery.SqlQuerySingle<QuantityRecord>("SELECT qr.id, qr.noSeri, qr.qtyAwalSablon, qr.qtySablonBS, qr.qtySablonHilang, qr.qtyAwalBordir, qr.qtyBordirBS, qr.qtyBordirHilang, qr.qtyAwalCMT, qr.qtyCMTBS, qr.qtyCMTHilang FROM QuantityRecord qr WHERE qr.noSeri = '" + x + "'");

            if (y == "Sablon")
            {
                var z = dba.idSPKSablon.ToString();
                var dbb = GenericQuery.SqlQuerySingle<DetailSPK>("SELECT d.idSPK, d.noSPK, d.EmployeeID, d.Datetime, d.type, d.status FROM DetailSPK d WHERE d.idSPK = '" + z + "'");
                txtNoSPK.Text = dbb.noSPK.ToString();
                txtJenisSPK.Text = y.ToString();
                txtQtyAwal.Text = dbc.qtyAwalSablon.ToString();
                txtQtyHilang.Text = dbc.qtySablonHilang.ToString();
                txtQtyBS.Text = dbc.qtySablonBS.ToString();
                txtQtyAwal.UseCustomBackColor = true;
                txtQtyAwal.BackColor = System.Drawing.Color.Plum;
                txtQtyBS.UseCustomBackColor = true;
                txtQtyBS.BackColor = System.Drawing.Color.Pink;
                txtQtyHilang.UseCustomBackColor = true;
                txtQtyHilang.BackColor = System.Drawing.Color.LightPink;
                txtNoSPK.UseCustomBackColor = true;
                txtNoSPK.BackColor = System.Drawing.Color.Thistle;
                txtJenisSPK.UseCustomBackColor = true;
                txtJenisSPK.BackColor = System.Drawing.Color.Thistle;
            }
            else if (y == "Bordir")
            {
                var z = dba.idSPKBordir.ToString();
                var dbb = GenericQuery.SqlQuerySingle<DetailSPK>("SELECT d.idSPK, d.noSPK, d.EmployeeID, d.Datetime, d.type, d.status FROM DetailSPK d WHERE d.idSPK = '" + z + "'");
                txtNoSPK.Text = dbb.noSPK.ToString();
                txtJenisSPK.Text = y.ToString();
                txtQtyAwal.Text = dbc.qtyAwalSablon.ToString();
                txtQtyHilang.Text = dbc.qtySablonHilang.ToString();
                txtQtyBS.Text = dbc.qtySablonBS.ToString();
                txtQtyAwal.UseCustomBackColor = true;
                txtQtyAwal.BackColor = System.Drawing.Color.Plum;
                txtQtyBS.UseCustomBackColor = true;
                txtQtyBS.BackColor = System.Drawing.Color.Pink;
                txtQtyHilang.UseCustomBackColor = true;
                txtQtyHilang.BackColor = System.Drawing.Color.LightPink;
                txtNoSPK.UseCustomBackColor = true;
                txtNoSPK.BackColor = System.Drawing.Color.LightGreen;
                txtJenisSPK.UseCustomBackColor = true;
                txtJenisSPK.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                var z = dba.idSPKCMT.ToString();
                var dbb = GenericQuery.SqlQuerySingle<DetailSPK>("SELECT d.idSPK, d.noSPK, d.EmployeeID, d.Datetime, d.type, d.status FROM DetailSPK d WHERE d.idSPK = '" + z + "'");
                txtNoSPK.Text = dbb.noSPK.ToString();
                txtJenisSPK.Text = y.ToString();
                txtQtyAwal.Text = dbc.qtyAwalSablon.ToString();
                txtQtyHilang.Text = dbc.qtySablonHilang.ToString();
                txtQtyBS.Text = dbc.qtySablonBS.ToString();
                txtQtyAwal.UseCustomBackColor = true;
                txtQtyAwal.BackColor = System.Drawing.Color.Plum;
                txtQtyBS.UseCustomBackColor = true;
                txtQtyBS.BackColor = System.Drawing.Color.Pink;
                txtQtyHilang.UseCustomBackColor = true;
                txtQtyHilang.BackColor = System.Drawing.Color.LightPink;
                txtNoSPK.UseCustomBackColor = true;
                txtNoSPK.BackColor = System.Drawing.Color.LightSteelBlue;
                txtJenisSPK.UseCustomBackColor = true;
                txtJenisSPK.BackColor = System.Drawing.Color.LightSteelBlue;
            }

            txtNoSeriTukangPotong.Text = dba.noSeri.ToString();
            txtModelTukangPotong.Text = dba.model.ToString();
            cboWarna.SelectedValue = dba.ColorID;
            txtMerkTukangPotong.Text = dba.merk.ToString();
            txtUkuranTukangPotong.Text = dba.ukuran.ToString();
            txtQtyTukangPotong.Text = dba.quantity.ToString();
        }
    }
}
