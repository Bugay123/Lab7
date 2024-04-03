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
        public void RemoveAllTracks()
        {
            using (var context = new MusicDbContext())
            {
                var allTracks = context.MusicTracks.ToList();
                context.MusicTracks.RemoveRange(allTracks);
                context.SaveChanges();
            }
        }

        public void UpdateTrack(MusicTrack updatedTrack)
        {
            using (var context = new MusicDbContext())
            {
                var existingTrack = context.MusicTracks.FirstOrDefault(t => t.Id == updatedTrack.Id);

                if (existingTrack != null)
                {
                    existingTrack.Title = updatedTrack.Title;
                    existingTrack.Artist = updatedTrack.Artist;
                    existingTrack.Album = updatedTrack.Album;
                    existingTrack.Year = updatedTrack.Year;

                    context.Update(existingTrack);
                    context.SaveChanges();
                }
            }
        }
    }
}
