using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Protests.Data.Seed
{
    public static class RepairSeeder
    {
        public static void SeedRepairs(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Repair>().HasData(
                new Repair
                {
                    Id = 1,
                    CarId = 1,
                    RepairOptionId = 1

                },
                new Repair
                {
                    Id = 2,
                    CarId = 2,
                    RepairOptionId = 2
                }
            );
        }
    }
}
