using Microsoft.EntityFrameworkCore;
using MusicCollection.Models;

namespace MusicCollection.Data
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext()
        {
        }

        public MusicDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<MusicTrack> MusicTracks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MusicCollection;Username=postgres;Password=postgres;");
            }
        }
        
    }
}
