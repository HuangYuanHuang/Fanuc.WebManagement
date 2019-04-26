using Abp.MultiTenancy;
using Fanuc.Webmanagement.Authorization.Users;

namespace Fanuc.Webmanagement.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
