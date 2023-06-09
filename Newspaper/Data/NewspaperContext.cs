﻿using Microsoft.EntityFrameworkCore;
using Newspaper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newspaper.Data
{
    public class NewspaperContext : DbContext
    {
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Reporter> Reporters { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;" +
                "Username=postgres;" +
                "Password=password123;" +
                "Database=Newspaper")
                .UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Issue>().Navigation(e => e.Articles).AutoInclude();
            modelBuilder.Entity<Article>().Navigation(e => e.Reporter).AutoInclude();
            modelBuilder.Entity<Reporter>().Navigation(e => e.Articles).AutoInclude();
        }
    }
}
