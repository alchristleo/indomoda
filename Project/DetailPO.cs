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
    
    public partial class DetailPO
    {
        public int DetailPOID { get; set; }
        public long PONumber { get; set; }
        public int MaterialID { get; set; }
        public int ColorID { get; set; }
        public int DetailQty { get; set; }
        public int DetailPrice { get; set; }
        public int DetailTotal { get; set; }
        public int DetailStatus { get; set; }
    
        public virtual Color Color { get; set; }
        public virtual Material Material { get; set; }
    }
}
