﻿using DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Context
{
    public class AppDbContext: DbContext
    {
        public DbSet<Destination> Destinations => Set<Destination>();

        public DbSet<EndBranch> EndBranches => Set<EndBranch>();

        public DbSet<StartBranch> StartBranches => Set<StartBranch>();

         public DbSet<Trip> Trips => Set<Trip>();

        public DbSet<PublicActivity> PublicActivities => Set<PublicActivity>();
        public DbSet<Question> Questions => Set<Question>();

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
