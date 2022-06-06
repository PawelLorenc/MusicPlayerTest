using Microsoft.EntityFrameworkCore;
using MusicApp.Data.Entities;

namespace MusicApp.Data.Context
{
    public class MusicAppContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public MusicAppContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=MusicApp;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedDatabase();
        }
    }
}
