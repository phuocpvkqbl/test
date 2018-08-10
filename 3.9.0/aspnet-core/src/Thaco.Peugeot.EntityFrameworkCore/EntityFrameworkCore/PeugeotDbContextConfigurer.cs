using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Thaco.Peugeot.EntityFrameworkCore
{
    public static class PeugeotDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PeugeotDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PeugeotDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
