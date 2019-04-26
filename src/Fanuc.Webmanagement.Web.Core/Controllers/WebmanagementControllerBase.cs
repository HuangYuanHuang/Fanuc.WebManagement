using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Fanuc.Webmanagement.Controllers
{
    public abstract class WebmanagementControllerBase: AbpController
    {
        protected WebmanagementControllerBase()
        {
            LocalizationSourceName = WebmanagementConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
