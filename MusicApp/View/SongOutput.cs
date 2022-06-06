using MusicApp.Data.Entities;
using MusicApp.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.View
{
    internal class SongOutput : IOutput<Song>
    {
        public void DisplayAll(List<Song> entity)
        {
            for(int i = 0; i < entity.Count; i++)
                Console.WriteLine("Index: " + i + " | Album: " + entity[i].AlbumName + " | Author: " + entity[i].Author + " | Length: " + entity[i].Length + " | Title: " + entity[i].Title);
        }
    }
}
