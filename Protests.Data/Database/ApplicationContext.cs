using Microsoft.EntityFrameworkCore;
using Protests.Data.Entities;
using Protests.Data.Seed;
using System;
using System.Collections.Generic;
using System.Text;

namespace Protests.Data.Database
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<RepairOption> RepairOptions { get; set; }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Protest> Protests { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<City> Cities { get; set; }

        public DbSet<Organizer> Organizers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedCars();
            modelBuilder.SeedDrivers();
            modelBuilder.SeedRepairs();
            modelBuilder.SeedRepairOptions();
        }
    }
}
