using System.Security.Cryptography.X509Certificates;

namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Song song1 = new Song("Thriller", "Disco", 174, 1988);
            Song song2 = new Song("Billie Jean", "Disco", 214, 1982);
            Song song3 = new Song("Beat it", "Disco", 258, 1983);
            Song song4 = new Song("Smooth Criminal", "Disco", 236, 1988);
            Song song5 = new Song("Dirty Diana", "Disco", 228, 1980);
            Song song6 = new Song("Black or White", "Disco", 228, 1980);
            Song song7 = new Song("Bad", "Disco", 228, 1980);
            Song song8 = new Song("The way you make me feel", "Disco", 228, 1980);

            List<Song> playlist1Songs = new List<Song> { song1, song2, song3, song4, song5 };
            List<Song> playlist2Songs = new List<Song> { song1, song2, song3, song4, song5 };
            List<Song> playlist3Songs = new List<Song> { song1, song2, song3, song4, song5 };

            Playlist playlist1  = new Playlist("Velist" , playlist1Songs);
            Playlist playlist2 = new Playlist("Rocky" , playlist2Songs);
            Playlist playlist3 = new Playlist("Chan" , playlist3Songs); 

            List<Playlist> playlists = new List<Playlist> { playlist1, playlist2, playlist3};

            List<User> users = new List<User>();

            User user1 = new User("Jan", users, playlists);
            User user2 = new User("Bram", users, playlists)
                ;
            List<Song> album1Songs = new List<Song> { song1, song2, song3, song4, song5};
            List<Song> album2Songs = new List<Song> { song2, song5, song6, song7, song8};
     
            Album album1 = new Album("Rockyveli", album1Songs);
            Album album2 = new Album("ChanRock", album2Songs);

            List<Album> Artist1Albums = new List<Album> { album1, album2 };
            List<Album> Artist2Albums = new List<Album> { album2 };

            List<Song> artist1Songs = new List<Song>{ song1, song2, song3, song4};
            List<Song> artist2Songs = new List<Song> { song2, song5, song6, song7, song8};

            Artist artist2 = new Artist("Vanchan", Artist1Albums,  artist1Songs);
            Artist artist3 = new Artist("Chanvan", Artist2Albums,  artist2Songs);

            List<Song> AllSongs = new List<Song> { song1, song2, song3, song4, song5, song6, song7, song8 };
            List<Album> AllAlbums = new List<Album> { album1, album2 };
            List<Artist> AllArtists = new List<Artist> { artist2, artist3 };
            List<User> AllUsers = new List<User> { user1, user2 };

            static void ShowSongs(List<Song> songs)
            {
                int index = 0;
                foreach (Song song in songs)
                {
                    Console.WriteLine("Title: " + song.Title + ", genre: " + song.Genre + ", Length: " + song.LengthInSeconds + ", Year: " + song.Age  + ", Id: " + index + "\n");
                    index++;
                }
            }
            static void ShowPlaylist(List<Playlist> playlists)
            {
                foreach (Playlist playlist in playlists)
                {
                    Console.WriteLine(playlist.Name);
                }
            }
            static void ShowAlbum(List<Album> albums)
            {
                foreach (Album album in albums)
                {
                    Console.WriteLine(album.Name);
                }
            }
            static void ShowArtist(List<Artist> artists)
            {
                foreach (Artist artist in artists)
                {
                    Console.WriteLine(artist.Name);
                }

            }
            static void ShowUsers(List<User> users)
            {
                foreach (User user in users)
                {
                    Console.WriteLine(user.Username);
                }
            }

            Console.WriteLine("Welkom bij Velify");

            string antwoord = "";


            while (antwoord != "7")
            { 

            Console.WriteLine("Kies een van de volgende opties:");
            Console.WriteLine("1. Bekijk alle songs");
            Console.WriteLine("2. Bekijk alle albums");
            Console.WriteLine("3. Bekijk alle artiesten");
            Console.WriteLine("4. Bekijk jouw playlists");
            Console.WriteLine("5. Bekijk alle users");
            Console.WriteLine("6. Maak nieuwe playlist");
            Console.WriteLine("7. Speel nummer af");
            Console.WriteLine("8. Exit");

            antwoord = Console.ReadLine();
            
                switch (antwoord)
                {
                    case "1":
                        ShowSongs(AllSongs);
                        break;
                    case "2":
                        ShowAlbum(AllAlbums);
                        break;
                    case "3":
                        ShowArtist(AllArtists);
                        break;
                    case "4":
                        // ShowPlaylists();
                        break;
                    case "5":
                        ShowUsers(AllUsers);
                        break;
                    case "6":
                        Playlist.Makeplaylist("kevin", AllSongs);
                        break;
                    case "7":

                        ShowSongs(AllSongs);
                        Console.WriteLine("Welk nummer wil je afspelen?");
                        string nummer = Console.ReadLine();
                        int nummerInt = Convert.ToInt32(nummer);
                        ListOfSongs.PlaySong(AllSongs, nummerInt);
                        string nummerActie = "";
                        while (nummerActie != "1" && nummerActie != "3") {
                            Console.WriteLine(
                                "1. Stop nummer\n" +
                                "2. Skip nummer\n" +
                                "3. Kies ander nummer\n" +
                                "4. Terug naar menu\n");
                             nummerActie = Console.ReadLine();
                            switch (nummerActie)
                            {
                                case "1":
                                    ListOfSongs.StopSong(AllSongs, nummerInt);
                                    break;
                                case "2":
                                    ListOfSongs.SkipSong(AllSongs, nummerInt);
                                    break;
                                case "3":
                                    break;
                                case "":
                                    break;
                            }
                        }
                        break;
                    case "8":
                        Console.WriteLine("Tot ziens!");
                        break;
                    default:
                        Console.WriteLine("Ongeldige invoer");
                        break;
                }
            }
        }
    }
}