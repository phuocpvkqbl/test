using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Thaco.Peugeot.Configuration;
using Thaco.Peugeot.Web;

namespace Thaco.Peugeot.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PeugeotDbContextFactory : IDesignTimeDbContextFactory<PeugeotDbContext>
    {
        public PeugeotDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PeugeotDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PeugeotDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PeugeotConsts.ConnectionStringName));

            return new PeugeotDbContext(builder.Options);
        }
    }
}
