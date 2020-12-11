using qa657.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace qa657
{
    [DependsOn(
        typeof(qa657EntityFrameworkCoreTestModule)
        )]
    public class qa657DomainTestModule : AbpModule
    {

    }
}