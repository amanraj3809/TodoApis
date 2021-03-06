﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IderaCWFRepositoryEntities2 : DbContext
    {
        public IderaCWFRepositoryEntities2()
            : base("name=IderaCWFRepositoryEntities2")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Database_RegisteredProduct> Database_RegisteredProduct { get; set; }
        public virtual DbSet<Databas> Databases { get; set; }
        public virtual DbSet<Instance_RegisteredProduct> Instance_RegisteredProduct { get; set; }
        public virtual DbSet<Instance> Instances { get; set; }
        public virtual DbSet<License> Licenses { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<ProductConfig> ProductConfigs { get; set; }
        public virtual DbSet<ProductMigration> ProductMigrations { get; set; }
        public virtual DbSet<ProductWidgetConfig> ProductWidgetConfigs { get; set; }
        public virtual DbSet<RegisteredProduct> RegisteredProducts { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SSRSReportConfiguration> SSRSReportConfigurations { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ViewColumn> ViewColumns { get; set; }
        public virtual DbSet<ViewConfig> ViewConfigs { get; set; }
        public virtual DbSet<message> messages { get; set; }
        public virtual DbSet<version> versions { get; set; }
        public virtual DbSet<ActionsPool> ActionsPools { get; set; }
        public virtual DbSet<Alert> Alerts { get; set; }
        public virtual DbSet<Alerts_Metadata> Alerts_Metadata { get; set; }
        public virtual DbSet<Audit_Log> Audit_Log { get; set; }
        public virtual DbSet<Permission_Instances> Permission_Instances { get; set; }
        public virtual DbSet<RegisteredProductURL> RegisteredProductURLs { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<UsersProductWidgetConfig> UsersProductWidgetConfigs { get; set; }
        public virtual DbSet<ViewColumnWidget> ViewColumnWidgets { get; set; }
        public virtual DbSet<shared_data> shared_data { get; set; }
    }
}
