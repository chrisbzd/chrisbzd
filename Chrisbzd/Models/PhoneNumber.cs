//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chrisbzd.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhoneNumber
    {
        public int PhoneNumberID { get; set; }
        public string Type { get; set; }
        public string Number { get; set; }
        public Nullable<int> ContactID { get; set; }
    
        public virtual Contact Contact { get; set; }
    }
}
