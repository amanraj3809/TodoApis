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
    
    public partial class ProductMigration
    {
        public int AttemptID { get; set; }
        public int ProductID { get; set; }
        public int MigrationStatus { get; set; }
        public System.DateTime LastUpdatedOn { get; set; }
        public string MigratedBy { get; set; }
        public string DestinationHost { get; set; }
        public string DestinationPort { get; set; }
        public string Result { get; set; }
        public bool IsActive { get; set; }
    }
}