using Microsoft.EntityFrameworkCore;
using Sprint.DAL.Models;

namespace Sprint.DAL.Data
{
    public class SprintDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Court> Courts { get; set; }
        public DbSet<CourtReservation> CourtReservations { get; set; }
        public DbSet<TrainerReservation> TrainerReservations { get; set; }
        public DbSet<TrainerReview> TrainerReviews { get; set; }
        public DbSet<TrainerPhoto> TrainerPhotos { get; set; }

        private string connectionString;

        public SprintDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Change Sql server
            // optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seeder();
        }
    }
}
