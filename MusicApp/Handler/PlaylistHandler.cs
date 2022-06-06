using MusicApp.Data.DAL;
using MusicApp.Data.Entities;
using MusicApp.Utils;
using MusicApp.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            while(!exit)
            {
                _output.DisplayOptions();
                int userInput = _inputSystem.FetchIntValue("Provide a number");
                switch(userInput)
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
            double lenght = _inputSystem.FetchDobuleValue("Length: ");
            Song song = new Song();
           
        }

    }
}
