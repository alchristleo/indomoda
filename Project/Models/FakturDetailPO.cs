using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
    public class FakturDetailPO
    {
        public int idFaktur { get; set; }
        public string NoFaktur { get; set; }
        public long PONumber { get; set; }
        public bool status { get; set; }

        public int DetailPOID { get; set; }
        public int MaterialID { get; set; }
        public int ColorID { get; set; }
        public double DetailQty { get; set; }
        public bool DetailStatus { get; set; }
        public bool statusFaktur { get; set; }
        public string noPemotonganKain { get; set; }
        public int tempPemotongan { get; set; }

        public virtual Color Color { get; set; }
        public virtual Material Material { get; set; }
    }
}
