using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
    public class POKainSupplierModel
    {
        public int idPOKain { get; set; }
        public long PONumber { get; set; }
        public int SupplierID { get; set; }
        public long GrandTotal { get; set; }
        public System.DateTime Date_time { get; set; }
        public bool status { get; set; }

        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
    }
}
