using System;
using Microsoft.EntityFrameworkCore;
using qa657.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;

namespace qa657.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See qa657MigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class qa657DbContext : AbpDbContext<qa657DbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        protected DbSet<InventoryAdjustmentLog> InventoryAdjustmentLog { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside qa657DbContextModelCreatingExtensions.Configureqa657
         */

        public qa657DbContext(DbContextOptions<qa657DbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser

                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the qa657EfCoreEntityExtensionMappings class
                 */

                b.HasMany<InventoryAdjustmentLog>().WithOne().HasForeignKey(x=>x.UserId);
            });

            /* Configure your own tables/entities inside the Configureqa657 method */

            builder.Configureqa657();

            builder.Entity<InventoryAdjustmentLog>(b =>
            {
                //SET RELATIONS FOR THE PROJECT DBCONTEXT

                b.HasOne(x => x.Creator).WithMany().HasForeignKey("CreatorId").IsRequired(false);
                b.HasOne(x => x.LastModifier).WithMany().HasForeignKey("LastModifierUserId").IsRequired(false);
            });
        }
    }
}
