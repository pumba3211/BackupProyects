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
    
    public partial class Programming
    {
        public int id { get; set; }
        public Nullable<int> destination_id { get; set; }
        public Nullable<int> pilot_id { get; set; }
        public Nullable<int> airplane_id { get; set; }
        public Nullable<System.DateTime> start_fly { get; set; }
        public Nullable<System.DateTime> end_fly { get; set; }
    
        public virtual airplane airplane { get; set; }
        public virtual destination destination { get; set; }
        public virtual pilot pilot { get; set; }
    }
}
