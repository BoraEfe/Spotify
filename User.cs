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
        public List <string> friends { get; set; }
        public List <string> playlists { get; set; }
        public User(string username) 
        {
            Username = username;
            friends = new List<string>();
            playlists = new List<string>();
        }

        public void AddFriend(string friend)
        {
            friends.Add(friend);
        }
        public void RemoveFriend(string friend)
        {
            friends.Remove(friend);
        }
    }
}