using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
    public class FakturKainModel
    {
        public int idFaktur { get; set; }
        public string NoFaktur { get; set; }
        public long PONumber { get; set; }
        public int SupplierID { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public bool status { get; set; }
        public System.DateTime Date_time { get; set; }
    }
}
