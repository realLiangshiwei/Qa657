using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace qa657.EntityFrameworkCore
{
    [DependsOn(
        typeof(qa657EntityFrameworkCoreModule)
        )]
    public class qa657EntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<qa657MigrationsDbContext>();
        }
    }
}
