﻿using gfa_web.Configs;
using gfa_web.Items;
using gfa_web.Purchases;
using gfa_web.Sales;
using gfa_web.Vendors;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace gfa_web.EntityFrameworkCore
{
    [ReplaceDbContext(typeof(IIdentityDbContext))]
    [ReplaceDbContext(typeof(ITenantManagementDbContext))]
    [ConnectionStringName("Default")]
    public class gfa_webDbContext : 
        AbpDbContext<gfa_webDbContext>,
        IIdentityDbContext,
        ITenantManagementDbContext
    {
        /* Add DbSet properties for your Aggregate Roots / Entities here. */
        
        public DbSet<Item> Items { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
        
        #region Entities from the modules
        
        /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
         * and replaced them for this DbContext. This allows you to perform JOIN
         * queries for the entities of these modules over the repositories easily. You
         * typically don't need that for other modules. But, if you need, you can
         * implement the DbContext interface of the needed module and use ReplaceDbContext
         * attribute just like IIdentityDbContext and ITenantManagementDbContext.
         *
         * More info: Replacing a DbContext of a module ensures that the related module
         * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
         */
        
        //Identity
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<IdentityClaimType> ClaimTypes { get; set; }
        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
        public DbSet<IdentityLinkUser> LinkUsers { get; set; }
        
        // Tenant Management
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

        #endregion
        
        public gfa_webDbContext(DbContextOptions<gfa_webDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureIdentityServer();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            builder.Entity<Item>(b =>
            {
                b.ToTable("Items");
                b.ConfigureByConvention(); //auto configure for the base class props
                
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
            
            builder.Entity<Purchase>(b =>
            {
                b.ToTable("Purchases");
                b.ConfigureByConvention(); //auto configure for the base class props
                b.HasOne<Vendor>().WithMany().HasForeignKey(x => x.VendorId).IsRequired();
            });
            
            
            builder.Entity<PurchaseItem>(b =>
            {
                b.ToTable("PurchaseItems");
                b.ConfigureByConvention(); //auto configure for the base class props
                b.HasOne<Purchase>().WithMany().HasForeignKey(x => x.PurchaseId).IsRequired();
                b.HasOne<Item>().WithMany().HasForeignKey(x => x.ItemId).IsRequired();
            });

            builder.Entity<Sale>(b =>
            {
                b.ToTable("Sales");
                b.ConfigureByConvention(); //auto configure for the base class props
            });
            
            builder.Entity<SaleItem>(b =>
            {
                b.ToTable("SaleItems");
                b.ConfigureByConvention(); //auto configure for the base class props
                b.HasOne<Sale>().WithMany().HasForeignKey(x => x.SaleId).IsRequired();
                b.HasOne<Item>().WithMany().HasForeignKey(x => x.ItemId).IsRequired();
            });
            
            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(gfa_webConsts.DbTablePrefix + "YourEntities", gfa_webConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
