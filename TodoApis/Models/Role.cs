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
    
    public partial class Role
    {
        public Role()
        {
            this.Permissions = new HashSet<Permission>();
        }
    
        public int RoleID { get; set; }
        public int ProductID { get; set; }
        public string RoleName { get; set; }
    
        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual RegisteredProduct RegisteredProduct { get; set; }
    }
}
