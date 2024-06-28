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
        public static void StopSong(List<Song> songs, int index)
        {
            Console.WriteLine("Song has stopped");
        }
        public static void PlaySong(List<Song> songs, int index)
        {
            if (index >= 0 && index < songs.Count)
            {
                Song song = songs[index];
                Console.WriteLine($"Playing song: {song.Title}.......");
            }

        }
        public static void SkipSong(List<Song> songs, int index)
        {
            if (index >= 0 && index < songs.Count)
            {
                index ++;
                Song song = songs[index];
                Console.WriteLine($"Skipping song: {song.Title}.......");
            }

        }
    }
}
