using DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Context
{
    public class AppDbContext: DbContext
    {
        public DbSet<Destination> Destinations => Set<Destination>();

        public DbSet<StartBranch> StartBranches => Set<StartBranch>();
        public DbSet<EndBranch> EndBranches => Set<EndBranch>();

        public DbSet<Trip> Trips => Set<Trip>();

        public DbSet<PublicActivity> PublicActivities => Set<PublicActivity>();

        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
