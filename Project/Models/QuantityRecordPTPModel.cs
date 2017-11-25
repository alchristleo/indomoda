using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
    public class QuantityRecordPTPModel
    {
        public int idListPTP { get; set; }
        public int idPenerimaanTukangPotong { get; set; }
        public string noSeri { get; set; }
        public string model { get; set; }
        public int ColorID { get; set; }
        public string merk { get; set; }
        public string ukuran { get; set; }
        public double quantity { get; set; }
        public Nullable<bool> statusSPKSablon { get; set; }
        public Nullable<bool> statusSPKBordir { get; set; }
        public Nullable<bool> statusSPKCMT { get; set; }
        public Nullable<int> statusNoSeri { get; set; }
        public Nullable<int> idSPKSablon { get; set; }
        public Nullable<int> idSPKBordir { get; set; }
        public Nullable<int> idSPKCMT { get; set; }

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

        public virtual Color Color { get; set; }
    }
}
