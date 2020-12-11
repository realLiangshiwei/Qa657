using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace qa657.EntityFrameworkCore
{
    public static class qa657DbContextModelCreatingExtensions
    {
        public static void Configureqa657(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(qa657Consts.DbTablePrefix + "YourEntities", qa657Consts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            builder.Entity<InventoryAdjustmentLog>(b =>
            {
                b.ToTable("InventoryAdjustmentLog");
                b.ConfigureByConvention();
            });
        }
    }
}
