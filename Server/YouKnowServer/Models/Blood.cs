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
    
    public partial class Blood
    {
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Media { get; set; }
        public string Description { get; set; }
        public System.Guid OrgUserId { get; set; }
        public bool IsFulfilled { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public System.Data.Entity.Spatial.DbGeography WantedFrom { get; set; }
        public string Contact { get; set; }
        public string BloodGroup { get; set; }
    
        public virtual OrgUser OrgUser { get; set; }
    }
}