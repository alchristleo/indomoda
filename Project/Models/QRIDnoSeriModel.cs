using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
    public class QRIDnoSeriModel
    {
        public Nullable<int> idSPKSablon { get; set; }
        public Nullable<int> idSPKBordir { get; set; }
        public Nullable<int> idSPKCMT { get; set; }

        public int id { get; set; }
        public string noSeri { get; set; }
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
