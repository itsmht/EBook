﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EBook.Models.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EBookEntities : DbContext
    {
        public EBookEntities()
            : base("name=EBookEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<ProductBook> ProductBooks { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<SuperAdmin> SuperAdmins { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
