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
    
    public partial class SuperAdmin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public System.DateTime DOB { get; set; }
        public int User_Id { get; set; }
    
        public virtual User User { get; set; }
    }
}
