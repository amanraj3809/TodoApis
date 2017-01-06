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
    
    public partial class ProductWidgetConfig
    {
        public ProductWidgetConfig()
        {
            this.UsersProductWidgetConfigs = new HashSet<UsersProductWidgetConfig>();
            this.ViewColumnWidgets = new HashSet<ViewColumnWidget>();
        }
    
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string WidgetType { get; set; }
        public string NavigationLink { get; set; }
        public string PackageURI { get; set; }
        public string DataURI { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public string Settings { get; set; }
        public string DefaultViews { get; set; }
        public bool Collapsed { get; set; }
    
        public virtual RegisteredProduct RegisteredProduct { get; set; }
        public virtual ICollection<UsersProductWidgetConfig> UsersProductWidgetConfigs { get; set; }
        public virtual ICollection<ViewColumnWidget> ViewColumnWidgets { get; set; }
    }
}