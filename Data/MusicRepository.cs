using System.Linq;
using System.Collections.Generic;
using MusicCollection.Models;
using Microsoft.Extensions.Options;

namespace MusicCollection.Data
{
    public class MusicRepository
    {
        private readonly MusicDbContext _context;

        public MusicRepository()
        {
            _context = new MusicDbContext();
        }

        public List<MusicTrack> GetAllTracks()
        {
            return _context.MusicTracks.ToList();
        }

        public void AddTrack(MusicTrack track)
        {
            _context.MusicTracks.Add(track);
            _context.SaveChanges();
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


