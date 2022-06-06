using MusicApp.Data.DAL;
using MusicApp.Data.Entities;
using MusicApp.Utils;
using MusicApp.View.Interfaces;

namespace MusicApp.Handler
{
    public class PlaylistHandler
    {
        private readonly SongRepository _songRepo;
        private IINputSystem _inputSystem;
        private IOutput<Song> _output;
        private IMenu _menu;
        public PlaylistHandler(SongRepository songRepo, IINputSystem inputSystem, IOutput<Song> output, IMenu menu)
        {
            _songRepo = songRepo;
            _inputSystem = inputSystem;
            _output = output;
            _menu = menu;
        }

        public void Run()
        {
            bool exit = false;
            while (!exit)
            {
                _output.DisplayOptions();
                int userInput = _inputSystem.FetchIntValue("Provide a number");
                switch (userInput)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        AddSong();
                        break;
                    case 2:
                        DeleteSong();
                        break;
                    case 3:
                        DisplayAllSongs();
                        break;
                    case 4:
                        SortSongs();
                        break;
                    case 5:
                        DisplaySpecificSong();
                        break;
                    default:
                        _menu.PrintMessage("Invalid Value");
                        break;

                }
            }
        }
        public void AddSong()
        {
            string author = _inputSystem.FetchStringValue("Author name: ");
            string title = _inputSystem.FetchStringValue("Title: ");
            string album = _inputSystem.FetchStringValue("Album: ");
            double lenght = _inputSystem.FetchDoubleValue("Length: ");
            Song song = new Song();
            song.Author = author;
            song.Title = title;
            song.AlbumName = album;
            song.Length = lenght;
            _songRepo.Add(song);
            _songRepo.Save();
            Console.Clear();
        }
        public void DeleteSong()
        {
            List<Song> songs = _songRepo.GetAll();
            _output.DisplayAll(songs);
            int songIndex = _inputSystem.FetchIntValue("Provide index of the song you want to remove", songs.Count);
            _songRepo.Remove(songs[songIndex]);
            _songRepo.Save();
        }
        private void DisplayAllSongs()
        {
            List<Song> songs = _songRepo.GetAll();
            _output.DisplayAll(songs);
        }
        private void SortSongs()
        {
            List<Song> songs = _songRepo.GetAll();
            songs.Sort((a, b) => a.Title.CompareTo(b.Title));
            _output.DisplayAll(songs);
        }
        private void DisplaySpecificSong()
        {
            List<Song> songs = _songRepo.GetAll();
            int songIndex = _inputSystem.FetchIntValue("Provide songs index", songs.Count);
            _menu.PrintMessage(songs[songIndex].Title);
        }
    }
}
