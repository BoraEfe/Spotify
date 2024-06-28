using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Spotify
{
    internal class Playlist : ListOfSongs
    {
        public Playlist(string name, List<Song> songs)
             : base(name, songs)
        {

        }
        public void Addsong(Song song)
        {
            Songs.Add(song);
        }
        public void removesong(Song song)
        {
            Songs.Remove(song);
        }
    }
}
