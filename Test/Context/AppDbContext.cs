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

            modelBuilder.Entity<Application>().HasData(
                new Application { Id = 1, Name = "Application1" },
                new Application { Id = 2, Name = "Application2" },
                new Application { Id = 3, Name = "Application3" }
            );

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Description = "Rule1", ApplicationId = 1 },
                new Role { Id = 2, Description = "Rule2", ApplicationId = 1 },
                new Role { Id = 3, Description = "Rule3", ApplicationId = 2 },
                new Role { Id = 4, Description = "Rule4", ApplicationId = 2 },
                new Role { Id = 5, Description = "Rule5", ApplicationId = 3 }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Customer1" },
                new Customer { Id = 2, Name = "Customer2" },
                new Customer { Id = 3, Name = "Customer3" }
            );

            modelBuilder.Entity<CustomerApplication>().HasData(
                new CustomerApplication { CustomerId = 1, ApplicationId = 1 },
                new CustomerApplication { CustomerId = 1, ApplicationId = 2 },
                new CustomerApplication { CustomerId = 2, ApplicationId = 2 },
                new CustomerApplication { CustomerId = 2, ApplicationId = 3 },
                new CustomerApplication { CustomerId = 3, ApplicationId = 1 },
                new CustomerApplication { CustomerId = 3, ApplicationId = 3 }
            );
        }
    }

}
