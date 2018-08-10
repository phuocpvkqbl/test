using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Thaco.Peugeot.Authorization.Roles;
using Thaco.Peugeot.Authorization.Users;
using Thaco.Peugeot.MultiTenancy;
using Thaco.Peugeot.Entities;

namespace Thaco.Peugeot.EntityFrameworkCore
{
    public class PeugeotDbContext : AbpZeroDbContext<Tenant, Authorization.Roles.Role, Authorization.Users.User, PeugeotDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<DocumentDetail> DocumentDetail { get; set; }
        public DbSet<DocumentGroup> DocumentGroup { get; set; }
        public DbSet<Event> EventProp { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<Maintenance> Maintenance { get; set; }
        public DbSet<Mileage> Mileage { get; set; }
        public DbSet<Model> Model { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Package> Package { get; set; }
        public DbSet<Period> Period { get; set; }
        public DbSet<Review> Review { get; set; }
        //public DbSet<Entities.Role> Role { get; set; }
        public DbSet<Setting> Setting { get; set; }
        //public DbSet<Entities.User> User { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Notification> Notification { get; set; }
         public DbSet<Verification> Verification { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Ward> Ward { get; set; }
        public PeugeotDbContext(DbContextOptions<PeugeotDbContext> options)
            : base(options)
        {
        }
    }
}
