using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Protests.Data.Seed
{
    public static class CarSeeder
    {
        public static void SeedCars(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    LicencePlate = "ZG0123BK",
                    DriverId = 1
                },
                new Car
                {
                    Id = 2,
                    LicencePlate = "KA280JA",
                    DriverId = 1
                }
            );
        }
    }
}
