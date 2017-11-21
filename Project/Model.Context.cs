﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Threading.Tasks;

    public partial class indomodaEntities : DbContext
    {
        public indomodaEntities()
            : base("name=indomodaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<IndomodaSupplier> IndomodaSuppliers { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<DetailFaktur> DetailFakturs { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<PreOrderKain> PreOrderKains { get; set; }
        public virtual DbSet<DetailPemotonganKain> DetailPemotonganKains { get; set; }
        public virtual DbSet<DetailPenerimaanTukangPotong> DetailPenerimaanTukangPotongs { get; set; }
        public virtual DbSet<ListPenerimaanTukangPotong> ListPenerimaanTukangPotongs { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<DetailPO> DetailPOes { get; set; }
        public virtual DbSet<DetailLog> DetailLogs { get; set; }

        internal Task<int> SaveChangesAsync()
        {
            return Task.Factory.StartNew(() => base.SaveChanges());
        }
    }
}
