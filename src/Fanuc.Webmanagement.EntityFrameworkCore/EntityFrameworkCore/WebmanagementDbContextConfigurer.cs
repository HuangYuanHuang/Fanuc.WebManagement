using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Fanuc.Webmanagement.EntityFrameworkCore
{
    public static class WebmanagementDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<WebmanagementDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<WebmanagementDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
