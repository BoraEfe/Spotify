using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Song
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int LengthInSeconds { get; set; }
        public int Age { get; set; }
        List<Artist> Artists { get; set; }

        public Song(string title, string genre, int lenghtinseconds, int age)
        {
            Title = title;
            Genre = genre;
            LengthInSeconds = lenghtinseconds;
            Age = age;
            Artists = new List<Artist>();
        }
        public void AddArtist(Artist artist)
        {
            Artists.Add(artist);
        }
    }
}
