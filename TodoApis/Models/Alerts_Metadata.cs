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
    
    public partial class Alerts_Metadata
    {
        public int ID { get; set; }
        public int ProductId { get; set; }
        public string Metric { get; set; }
        public string Message { get; set; }
        public string Preview { get; set; }
        public string PluralMessage { get; set; }
        public string PluralPreview { get; set; }
        public string KB { get; set; }
        public string LinkToWiki { get; set; }
        public string LinkToDetails { get; set; }
        public string LinkToDashboard { get; set; }
    
        public virtual RegisteredProduct RegisteredProduct { get; set; }
    }
}