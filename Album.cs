using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Album : ListOfSongs 
    {
        List<Artist> Artists { get; set; }

        public Album(string name, List<Song> songs)
               : base(name, songs)
        {
            Artists = new List<Artist>();
            songs = songs;
        }

        public void AddArtist(Artist artist)
        {
            Artists.Add(artist);
        }
    }
}
