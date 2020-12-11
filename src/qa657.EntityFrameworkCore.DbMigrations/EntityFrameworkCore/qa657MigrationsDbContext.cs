using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace qa657.EntityFrameworkCore
{
    /* This DbContext is only used for database migrations.
     * It is not used on runtime. See qa657DbContext for the runtime DbContext.
     * It is a unified model that includes configuration for
     * all used modules and your application.
     */
    public class qa657MigrationsDbContext : AbpDbContext<qa657MigrationsDbContext>
    {
        public qa657MigrationsDbContext(DbContextOptions<qa657MigrationsDbContext> options)
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


            builder.Entity<InventoryAdjustmentLog>(b =>
            {
                b.Ignore(x => x.Creator);
                b.Ignore(x => x.LastModifier);

                b.HasOne<IdentityUser>().WithMany().HasForeignKey("CreatorId").IsRequired(false);
                b.HasOne<IdentityUser>().WithMany().HasForeignKey("LastModifierUserId").IsRequired(false);
            });

            builder.Entity<IdentityUser>(b =>
            {
                b.HasMany<InventoryAdjustmentLog>().WithOne().HasForeignKey(x=>x.UserId);
            });

            builder.Configureqa657();
        }
    }
}
