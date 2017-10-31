using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
    public class POKainModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public POKainModel()
        {
            this.DetailPOes = new HashSet<DetailPO>();
        }

        public int idPOKain { get; set; }
        public int PONumber { get; set; }
        public int SupplierID { get; set; }
        public long GrandTotal { get; set; }
        public System.DateTime Date_time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailPO> DetailPOes { get; set; }
        public virtual IndomodaSupplier IndomodaSupplier { get; set; }
    }
}
