using qa657.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace qa657.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class qa657PageModel : AbpPageModel
    {
        protected qa657PageModel()
        {
            LocalizationResourceType = typeof(qa657Resource);
        }
    }
}