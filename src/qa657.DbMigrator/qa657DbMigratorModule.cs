using qa657.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace qa657.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(qa657EntityFrameworkCoreDbMigrationsModule),
        typeof(qa657ApplicationContractsModule)
        )]
    public class qa657DbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
