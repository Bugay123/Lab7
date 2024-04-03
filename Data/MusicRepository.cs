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

        // Додайте інші методи за потребою (оновлення, видалення тощо)
    }
}


