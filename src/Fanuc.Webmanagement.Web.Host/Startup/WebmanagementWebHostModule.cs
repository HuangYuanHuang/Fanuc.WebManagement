using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Fanuc.Webmanagement.Configuration;

namespace Fanuc.Webmanagement.Web.Host.Startup
{
    [DependsOn(
       typeof(WebmanagementWebCoreModule))]
    public class WebmanagementWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public WebmanagementWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WebmanagementWebHostModule).GetAssembly());
        }
    }
}
