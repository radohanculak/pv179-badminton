﻿using Microsoft.EntityFrameworkCore;
using Sprint.DAL.EFCore.Models;

namespace Sprint.DAL.EFCore.Data;

public class SprintDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Trainer> Trainers { get; set; }
    public DbSet<Court> Courts { get; set; }
    public DbSet<CourtReservation> CourtReservations { get; set; }
    public DbSet<TrainerReservation> TrainerReservations { get; set; }
    public DbSet<TrainerReview> TrainerReviews { get; set; }
    public DbSet<TrainerPhoto> TrainerPhotos { get; set; }

    private static string getDbPath()
    {
        var fileName = "sprint.db";
        return Path.Combine(Directory.GetCurrentDirectory(), fileName);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source={getDbPath()}");
    }

    /*
    public SprintDbContext(string connectionString)
    {
        // until app is created
        this.connectionString = connectionString;
    }
    */

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Seeder();
    }
}
