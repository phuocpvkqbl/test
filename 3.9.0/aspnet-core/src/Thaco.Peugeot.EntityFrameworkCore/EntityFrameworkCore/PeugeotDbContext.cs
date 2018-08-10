using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Thaco.Peugeot.Authorization.Roles;
using Thaco.Peugeot.Authorization.Users;
using Thaco.Peugeot.MultiTenancy;

namespace Thaco.Peugeot.EntityFrameworkCore
{
    public class PeugeotDbContext : AbpZeroDbContext<Tenant, Role, User, PeugeotDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PeugeotDbContext(DbContextOptions<PeugeotDbContext> options)
            : base(options)
        {
        }
    }
}
