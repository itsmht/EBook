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
    
    public partial class Payment
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }
        public System.DateTime Date { get; set; }
        public int Order_Id { get; set; }
        public int Customer_Id { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Order Order { get; set; }
    }
}
