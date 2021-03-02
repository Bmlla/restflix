using System;
namespace RestFlix.Models
{
    public class Movie
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Duration { get; set; }
        public string Synopsis { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Classification { get; set; }
    }
}
