using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
    public class ListPenjualanBajuModel
    {
        public int idLPB { get; set; }
        public int idDPB { get; set; }
        public string noSeri { get; set; }
        public string model { get; set; }
        public int ColorID { get; set; }
        public string merk { get; set; }
        public string ukuran { get; set; }
        public double qtyLPB { get; set; }
        public decimal priceLPB { get; set; }
        public decimal totalLPB { get; set; }
        public bool statusLPB { get; set; }
    }
}
