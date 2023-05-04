using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FlexiCloudPay.EntityFrameworkCore
{
    public static class FlexiCloudPayDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FlexiCloudPayDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FlexiCloudPayDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
