﻿using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Sprint.DAL.Models;

namespace Sprint.DAL.Data;

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
        string path;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            path = Path.Combine(
                Directory.GetParent(Directory.GetCurrentDirectory()
                    )
                    .Parent.Parent.Parent.FullName, fileName);
        }
        else
        {
            path = Path.Combine(
                Directory.GetCurrentDirectory(), fileName); // update the path if necessary (Linux, Mac)
        }

        return path;
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
        modelBuilder.Seeder();
    }
}
