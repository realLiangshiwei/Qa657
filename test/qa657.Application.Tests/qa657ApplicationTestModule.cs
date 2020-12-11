using Volo.Abp.Modularity;

namespace qa657
{
    [DependsOn(
        typeof(qa657ApplicationModule),
        typeof(qa657DomainTestModule)
        )]
    public class qa657ApplicationTestModule : AbpModule
    {

    }
}