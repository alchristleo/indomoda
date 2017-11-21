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
    public partial class DetailLogForm : MetroFramework.Forms.MetroForm
    {
        public DetailLogForm()
        {
            InitializeComponent();
        }

        private void DetailLogForm_Load(object sender, EventArgs e)
        {
            using (indomodaEntities db = new indomodaEntities())
            {
                userBindingSource.DataSource = db.Users.ToList();
                List<DetailLog> list = GenericQuery.SqlQuery<DetailLog>("SELECT dl.id, dl.UserID, dl.Datetime, dl.activity FROM DetailLogs dl");
                var newList = list.OrderByDescending(x => x.Datetime).ToList();
                detailLogBindingSource.DataSource = newList;
            }
        }
    }
}
