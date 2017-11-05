using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
    public class POKainModel
    {
        public int idPOKain { get; set; }
        public long PONumber { get; set; }
        public int SupplierID { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
    }
}
