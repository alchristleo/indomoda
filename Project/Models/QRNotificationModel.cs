using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
    public class QRNotificationModel
    {
        public string noPenerimaan { get; set; }
        public string noSPK { get; set; }
        public System.DateTime Datetime { get; set; }
        public string type { get; set; }

        public string noSeri { get; set; }

        public int id { get; set; }
        public Nullable<double> qtyAwalSablon { get; set; }
        public Nullable<double> qtySablonBS { get; set; }
        public Nullable<double> qtySablonHilang { get; set; }
        public Nullable<double> qtyAwalBordir { get; set; }
        public Nullable<double> qtyBordirBS { get; set; }
        public Nullable<double> qtyBordirHilang { get; set; }
        public Nullable<double> qtyAwalCMT { get; set; }
        public Nullable<double> qtyCMTBS { get; set; }
        public Nullable<double> qtyCMTHilang { get; set; }
    }
}
