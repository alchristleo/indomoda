using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project.Helpers;
using Project.Models;

namespace Project
{
    public partial class PenerimaanKain : MetroFramework.Forms.MetroForm
    {
        public PenerimaanKain()
        {
            InitializeComponent();
        }

        private void btnExitPenerimaanKain_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboNoPOKain_SelectedIndexChanged(object sender, EventArgs e)
        {
            long poNumber = Convert.ToInt64(cboNoPOKain.SelectedValue.ToString());
            var db = GenericQuery.SqlQuerySingle<POKainModel>("SELECT p.idPOKain, p.PONumber, p.SupplierID, s.SupplierName, s.SupplierCode FROM PreOrderKains p JOIN IndomodaSuppliers s ON p.SupplierID = s.SupplierID WHERE p.PONumber = '"+poNumber+"'");
            txtSupplierCode.Text = db.SupplierCode.ToString();
            txtSupplierName.Text = db.SupplierName.ToString();
            List<DetailPOModel> listPO = GenericQuery.SqlQuery<DetailPOModel>("SELECT * FROM DetailPO WHERE PONumber = '" + poNumber + "'");
            detailPOBindingSource.DataSource = listPO.ToList();
        }

        private void PenerimaanKain_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                preOrderKainBindingSource.DataSource = db.PreOrderKains.ToList();
            }
        }

        //private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (metroCheckBox1.check)
        //}
    }
}
