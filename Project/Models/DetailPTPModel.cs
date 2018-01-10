using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
    public class DetailPTPModel
    {
        public int idPenerimaanTukangPotong { get; set; }
        public string noPenerimaanTukangPotong { get; set; }
        public string noPemotonganKain { get; set; }
        public System.DateTime Date_time { get; set; }
        public int status { get; set; }

        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }
        public string EmployeeCode { get; set; }
    }
}
