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
    
    public partial class Permission_Instances
    {
        public int PermissionID { get; set; }
        public Nullable<int> InstanceID { get; set; }
    
        public virtual Instance Instance { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
