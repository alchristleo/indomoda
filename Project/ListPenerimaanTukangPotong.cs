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
    
    public partial class ListPenerimaanTukangPotong
    {
        public int idListPTP { get; set; }
        public Nullable<int> idPenerimaanTukangPotong { get; set; }
        public string noSeri { get; set; }
        public string model { get; set; }
        public int ColorID { get; set; }
        public string merk { get; set; }
        public string ukuran { get; set; }
        public int quantity { get; set; }
    
        public virtual Color Color { get; set; }
    }
}