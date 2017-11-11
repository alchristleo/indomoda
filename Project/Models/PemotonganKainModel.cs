using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
    public class PemotonganKainModel
    {
        public int idPemotonganKain { get; set; }
        public string noPemotonganKain { get; set; }
        public string NoFaktur { get; set; }
        public long PONumber { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeCode { get; set; }
        public int status { get; set; }
    }
}
