using System;
using System.ComponentModel.DataAnnotations;

namespace MusicCollection.Models
{
    public class MusicTrack
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Year { get; set; }
    }
}
