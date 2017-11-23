using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
    public class DetailSPKModel
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

        public virtual Color Color { get; set; }
    }
}
