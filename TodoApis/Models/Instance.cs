//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TodoApis.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Instance
    {
        public Instance()
        {
            this.Databases = new HashSet<Databas>();
            this.Instance_RegisteredProduct = new HashSet<Instance_RegisteredProduct>();
            this.Audit_Log = new HashSet<Audit_Log>();
            this.Permission_Instances = new HashSet<Permission_Instances>();
            this.Tags = new HashSet<Tag>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public System.DateTime UTCFirstSeen { get; set; }
        public System.DateTime UTCLastSeen { get; set; }
        public string Version { get; set; }
        public string Edition { get; set; }
        public string Owner { get; set; }
        public string Location { get; set; }
        public string Comments { get; set; }
    
        public virtual ICollection<Databas> Databases { get; set; }
        public virtual ICollection<Instance_RegisteredProduct> Instance_RegisteredProduct { get; set; }
        public virtual ICollection<Audit_Log> Audit_Log { get; set; }
        public virtual ICollection<Permission_Instances> Permission_Instances { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
