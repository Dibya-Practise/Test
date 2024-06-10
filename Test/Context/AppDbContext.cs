using Microsoft.EntityFrameworkCore;
using System.Data;
using Test.Model;

namespace Test.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<CustomerApplication> CustomerApplications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerApplication>()
                .HasKey(ca => new { ca.CustomerId, ca.ApplicationId });

            modelBuilder.Entity<CustomerApplication>()
                .HasOne(ca => ca.Customer)
                .WithMany(c => c.CustomerApplications)
                .HasForeignKey(ca => ca.CustomerId);

            modelBuilder.Entity<CustomerApplication>()
                .HasOne(ca => ca.Application)
                .WithMany(a => a.CustomerApplications)
                .HasForeignKey(ca => ca.ApplicationId);
        }
    }

}
