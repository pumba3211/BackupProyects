//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiCharp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class destination
    {
        public destination()
        {
            this.Programming = new HashSet<Programming>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    
        public virtual ICollection<Programming> Programming { get; set; }
    }
}
