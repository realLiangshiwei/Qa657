using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace qa657.Web
{
    [Dependency(ReplaceServices = true)]
    public class qa657BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "qa657";
    }
}
