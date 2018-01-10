using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
    public class SPKEmployeeModel
    {
        public int idSPK { get; set; }
        public string noSPK { get; set; }
        public int EmployeeID { get; set; }
        public System.DateTime Datetime { get; set; }
        public string type { get; set; }
        public int status { get; set; }

        public string EmployeeName { get; set; }
        public string EmployeeCode { get; set; }
    }
}
