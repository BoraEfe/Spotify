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
        public void Addsongs()
        {
            songs.Add(new Song("Thriller", "pop", 140, 1995, new List<Artist>() { new Artist()}));
            songs.Add(new Song("Bohemian Rhapsody", "rock", 180, 1995, new List<Artist>() { new Artist()}));
            songs.Add(new Song("Hotel California", "rock", 174, 1995, new List<Artist>() { new Artist()}));
            songs.Add(new Song("Stairway to Heaven", "rock", 190, 1995, new List<Artist>() { new Artist()}));
            songs.Add(new Song("Imagine", "pop", 146, 1992, new List<Artist>() { new Artist()}));
            songs.Add(new Song("What's Going On", "pop", 190, 1855, new List<Artist>() { new Artist()}));
            songs.Add(new Song("Born to Run", "rock", 120, 1995, new List<Artist>() { new Artist()}));
            songs.Add(new Song("Layla", "rock", 186, 2003, new List<Artist>() { new Artist()}));
        }
    }
}
