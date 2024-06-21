namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artist artist1 = new Artist("Bouwer");
            Artist artist2 = new Artist("Vouwer");

            List<Artist> artists = new List<Artist> { artist1, artist2 };

            Song song1 = new Song("Bob","Jazz",120,1998, artists);
        }
    }
}