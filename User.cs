using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class User
    {
        public string Username { get; set; }
        public List <User> friends { get; set; }
        public List <Playlist> playlists { get; set; }
        public User(string username, List<User> friends, List<Playlist> playlist)
        {
            Username = username;
            friends = new List<User>();
            playlists = new List<Playlist>();
        }
    }
}