using System;
using System.Collections.Generic;
using System.Text;
using qa657.Localization;
using Volo.Abp.Application.Services;

namespace qa657
{
    /* Inherit your application services from this class.
     */
    public abstract class qa657AppService : ApplicationService
    {
        protected qa657AppService()
        {
            LocalizationResource = typeof(qa657Resource);
        }
    }
}
