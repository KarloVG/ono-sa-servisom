using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Protests.Data.Seed
{
    public static class DriverSeeder
    {
        public static void SeedDrivers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Driver>().HasData(
                new Driver
                {
                    Id = 1,
                    FirstName = "Josip",
                    LastName = "Josić"
                },
                new Driver
                {
                    Id = 2,
                    FirstName = "Marko",
                    LastName = "Marić"
                },
                new Driver
                {
                    Id = 3,
                    FirstName = "Ivan",
                    LastName = "Ivan"
                }
            );
        }
    }
}
