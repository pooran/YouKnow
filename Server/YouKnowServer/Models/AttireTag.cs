﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YouKnowServer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AttireTag
    {
        public System.Guid Id { get; set; }
        public System.Guid AttireId { get; set; }
        public System.Guid TagId { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual Attire Attire { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
