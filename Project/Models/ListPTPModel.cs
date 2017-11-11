using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
    public class ListPTPModel
    {
        public int idListPTP { get; set; }
        public string noSeri { get; set; }
        public string model { get; set; }
        public int ColorID { get; set; }
        public string merk { get; set; }
        public string ukuran { get; set; }
        public string quantity { get; set; }

        public virtual Color Color { get; set; }
    }
}
