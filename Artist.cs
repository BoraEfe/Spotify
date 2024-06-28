using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Artist
    {
        public string Name { get; set; }
        List<Album> Albums { get; set; }
        List<Song> Songs { get; set; }

        public Artist(string name, List<Album> albums, List<Song> songs)
        {
            Name = name;
            Albums = albums;
            foreach (Album album in albums)
            {
                album.AddArtist(this);
            }
            foreach (Song song in songs)
            {
                song.AddArtist(this);
            }
            Songs = songs;
        }
    }
}
