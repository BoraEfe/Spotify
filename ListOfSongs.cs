using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class ListOfSongs
    {
        public string Name { get; set; }

        public List<Song> Songs = new List<Song>();

        public ListOfSongs(string name, List<Song> songs)
        {
            Name = name;
            Songs = songs;
        }
    }
}
