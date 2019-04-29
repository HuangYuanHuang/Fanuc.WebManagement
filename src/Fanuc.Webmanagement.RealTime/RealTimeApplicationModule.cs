using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fanuc.Webmanagement.RealTime
{
    public class RealTimeApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            var thisAssembly = typeof(RealTimeApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

         
        }
    }
}
