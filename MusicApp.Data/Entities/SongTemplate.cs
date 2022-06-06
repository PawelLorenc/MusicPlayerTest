using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Data.Entities
{
    public abstract class SongTemplate
    {
        public Guid SongId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string AlbumName { get; set; }
        public double Length { get; set; }

        public SongTemplate() { }

        public SongTemplate(string author, string title, string albumName, double length)
        {
            Author = author;
            Title = title;
            AlbumName = albumName;
            Length = length;
        }
    }


}
