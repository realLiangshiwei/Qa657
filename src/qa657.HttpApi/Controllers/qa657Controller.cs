using qa657.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace qa657.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class qa657Controller : AbpController
    {
        protected qa657Controller()
        {
            LocalizationResource = typeof(qa657Resource);
        }
    }
}