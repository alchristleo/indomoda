using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
    public class DetailPOModel
    {
        public int DetailPOID { get; set; }
        public long PONumber { get; set; }
        public int MaterialID { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public int ColorID { get; set; }
        public string ColorCode { get; set; }
        public string ColorName { get; set; }
        public double DetailQty { get; set; }
        public decimal DetailPrice { get; set; }
        public decimal DetailTotal { get; set; }
        public bool DetailStatus { get; set; }

        public virtual Color Color { get; set; }
        public virtual Material Material { get; set; }
    }
}
