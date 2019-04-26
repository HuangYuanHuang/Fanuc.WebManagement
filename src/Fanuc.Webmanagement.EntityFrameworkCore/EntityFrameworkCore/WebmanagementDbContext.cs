using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Fanuc.Webmanagement.Authorization.Roles;
using Fanuc.Webmanagement.Authorization.Users;
using Fanuc.Webmanagement.MultiTenancy;

namespace Fanuc.Webmanagement.EntityFrameworkCore
{
    public class WebmanagementDbContext : AbpZeroDbContext<Tenant, Role, User, WebmanagementDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public WebmanagementDbContext(DbContextOptions<WebmanagementDbContext> options)
            : base(options)
        {
        }
    }
}
