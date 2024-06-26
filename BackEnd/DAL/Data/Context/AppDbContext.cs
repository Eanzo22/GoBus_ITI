﻿using DAL.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data.Context;

public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
{
    public DbSet<ApplicationUser> ApplicationUsers => Set<ApplicationUser>();
    public DbSet<ApplicationRole> ApplicationRoles => Set<ApplicationRole>();
    public DbSet<ApplicationUserRole> ApplicationUserRoles => Set<ApplicationUserRole>();
    public DbSet<Destination> Destinations => Set<Destination>();
    public DbSet<EndBranch> EndBranches => Set<EndBranch>();
    public DbSet<StartBranch> StartBranches => Set<StartBranch>();
    public DbSet<Trip> Trips => Set<Trip>();
    public DbSet<PublicActivity> PublicActivities => Set<PublicActivity>();
    public DbSet<Question> Questions => Set<Question>();
    public DbSet<BusClass> BusClasses => Set<BusClass>();
    public DbSet<Bus> Buses => Set<Bus>();
    public DbSet<ClassImage> ClassImages => Set<ClassImage>();
    public DbSet<Term> Terms => Set<Term>();
    public DbSet<Ticket> Tickets => Set<Ticket>();
    public DbSet<Policy> Policies => Set<Policy>();
    public DbSet<Reservation> Reservations => Set<Reservation>();
    public DbSet<Report> Reports => Set<Report>();

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
