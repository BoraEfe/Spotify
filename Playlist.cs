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
        public static void Makeplaylist(string name, List<Song> songs)
        {
            Console.WriteLine("Enter the name of the playlist");
            string PlaylistInputName = Console.ReadLine();
            PlaylistInputName = name;
            Playlist playlist = new Playlist(name, songs);
        }
        public void AddSong(Song song)
        {
            Songs.Add(song);
        }
        public void RemoveSong(Song song)
        {
            Songs.Remove(song);
        }
    }
}
