using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Fanuc.Webmanagement.Authorization;

namespace Fanuc.Webmanagement
{
    [DependsOn(
        typeof(WebmanagementCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class WebmanagementApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<WebmanagementAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(WebmanagementApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
