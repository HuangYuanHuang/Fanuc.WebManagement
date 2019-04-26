using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Fanuc.Webmanagement.Configuration;
using Fanuc.Webmanagement.Web;

namespace Fanuc.Webmanagement.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class WebmanagementDbContextFactory : IDesignTimeDbContextFactory<WebmanagementDbContext>
    {
        public WebmanagementDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<WebmanagementDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            WebmanagementDbContextConfigurer.Configure(builder, configuration.GetConnectionString(WebmanagementConsts.ConnectionStringName));

            return new WebmanagementDbContext(builder.Options);
        }
    }
}
