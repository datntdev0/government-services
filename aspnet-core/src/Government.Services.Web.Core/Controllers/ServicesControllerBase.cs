using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Government.Services.Controllers
{
    public abstract class ServicesControllerBase: AbpController
    {
        protected ServicesControllerBase()
        {
            LocalizationSourceName = ServicesConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

