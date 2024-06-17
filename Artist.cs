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

        public Artist(string name)
        {
            Name = name;

        }
        public List<Artist> Artists = new List<Artist>();
    }
}
