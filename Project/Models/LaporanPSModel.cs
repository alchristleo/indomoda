using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
    public class LaporanPSModel
    {
        public int idDetail { get; set; }
        public string noPenerimaan { get; set; }
        public string noSPK { get; set; }
        public string noSeri { get; set; }
        public string type { get; set; }
        public int tempSablon { get; set; }
        public int tempBordir { get; set; }
        public int tempCMT { get; set; }

        public string model { get; set; }
        public int ColorID { get; set; }
        public string merk { get; set; }
        public string ukuran { get; set; }

        public Nullable<double> qtyAwalSablon { get; set; }
        public Nullable<double> qtySablonBS { get; set; }
        public Nullable<double> qtySablonHilang { get; set; }
    }
}
