using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class ListOfSongs
    {
        public List<Song> songs = new List<Song>();

        public ListOfSongs(List<Song> Songs)
        {
            this.songs = Songs;
        }
    }
}
