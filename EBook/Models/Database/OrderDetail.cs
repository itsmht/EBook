//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int Product_Id { get; set; }
        public int Order_id { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual ProductBook ProductBook { get; set; }
    }
}