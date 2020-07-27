﻿using Microsoft.EntityFrameworkCore;
using Protests.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Protests.Data.Database
{
    public class ProtestsContext : DbContext
    {
        public ProtestsContext(DbContextOptions<ProtestsContext> options)
            : base(options)
        { }

        public DbSet<Protest> Protests { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City
                {
                    Id = 1,
                    CityName = "Zagreb"
                },
                new City
                {
                    Id = 2,
                    CityName = "Široki"
                }
            );

            modelBuilder.Entity<Protest>().HasData(
                new Protest
                {
                    Id = 1,
                    Title = "Title 1",
                    Description = "Description 1",
                    StartsAt = DateTime.Now.AddDays(5),
                    CityId = 1
                },
                new Protest
                {
                    Id = 2,
                    Title = "David predvodi u Širokom prosvjed",
                    Description = "Description 2",
                    StartsAt = DateTime.Now.AddDays(15),
                    CityId = 2
                }
            );

            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    Id = 1,
                    CommentText = "Comment 1",
                    ProtestId = 1
                },
                new Comment
                {
                    Id = 2,
                    CommentText = "Comment 1",
                    ProtestId = 1
                },
                new Comment
                {
                    Id = 3,
                    CommentText = "Comment 1",
                    ProtestId = 2
                }
            );
        }
    }
}
