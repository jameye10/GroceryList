//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GroceryList.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public Customer()
        {
            this.Lists = new HashSet<List>();
        }
    
        public int CustomerId { get; set; }
        public string CFirstName { get; set; }
        public string CLastName { get; set; }
        public string CAddress { get; set; }
        public string CCity { get; set; }
        public string CState { get; set; }
        public string CZipCode { get; set; }
    
        public virtual ICollection<List> Lists { get; set; }
    }
}