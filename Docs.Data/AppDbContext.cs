using Docs.Core;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Docs.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Package> Packages { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<PackageTag> PackageTags { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Package>().HasIndex(p => p.Name).IsUnique();

            modelBuilder.Entity<Package>().HasQueryFilter(p => p.IsDisplayed);

            modelBuilder.Entity<PackageTag>().HasIndex(p => new { p.TagId, p.PackageId }).IsUnique();

        }

    }
}
