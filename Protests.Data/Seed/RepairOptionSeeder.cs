using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Protests.Data.Seed
{
    public static class RepairOptionSeeder
    {
        public static void SeedRepairOptions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RepairOption>().HasData(
                new RepairOption
                {
                    Id = 1,
                    Name = "Vulkanizacija",
                    Price = 5
                },
                new RepairOption
                {
                    Id = 2,
                    Name = "Redovni servis",
                    Price = 5
                }
            );
        }
    }
}
