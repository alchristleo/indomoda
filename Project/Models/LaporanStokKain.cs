using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
    public class LaporanStokKain
    {
        public int DetailPOID { get; set; }
        public long PONumber { get; set; }
        public int MaterialID { get; set; }
        public int ColorID { get; set; }
        public double DetailQty { get; set; }
        public decimal DetailPrice { get; set; }
        public decimal DetailTotal { get; set; }
        public bool DetailStatus { get; set; }

        public System.DateTime Date_time { get; set; }
    }
}
