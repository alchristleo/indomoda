//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class PreOrderKain
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PreOrderKain()
        {
            this.DetailFakturs = new HashSet<DetailFaktur>();
            this.DetailPemotonganKains = new HashSet<DetailPemotonganKain>();
        }
    
        public int idPOKain { get; set; }
        public long PONumber { get; set; }
        public int SupplierID { get; set; }
        public long GrandTotal { get; set; }
        public System.DateTime Date_time { get; set; }
        public bool status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailFaktur> DetailFakturs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailPemotonganKain> DetailPemotonganKains { get; set; }
        public virtual IndomodaSupplier IndomodaSupplier { get; set; }
    }
}
