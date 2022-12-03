using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Sprint.DAL.EFCore.Models;

namespace Sprint.DAL.EFCore.Data;

public class SprintDbContext : DbContext
{
    private string _connectionString;
    
    public DbSet<User> Users { get; set; }
    public DbSet<Trainer> Trainers { get; set; }
    public DbSet<Court> Courts { get; set; }
    public DbSet<CourtReservation> CourtReservations { get; set; }
    public DbSet<TrainerReservation> TrainerReservations { get; set; }
    public DbSet<TrainerReview> TrainerReviews { get; set; }
    public DbSet<TrainerPhoto> TrainerPhotos { get; set; }
    
    public SprintDbContext()
    {
    }

    public SprintDbContext(DbContextOptions<SprintDbContext> options) : base(options)
    {
    }
    
    public SprintDbContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if(options.IsConfigured == false)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = config.GetConnectionString("SprintDatabase");
        }
        
        options.UseSqlite(_connectionString);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Seeder();
    }

}
