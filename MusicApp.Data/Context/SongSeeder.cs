using Microsoft.EntityFrameworkCore;
using MusicApp.Data.Entities;

namespace MusicApp.Data.Context
{
    public static class SongSeeder
    {
        public static void SeedDatabase(this ModelBuilder builder)
        {
            List<Song> songList = new();
            Song song = new Song
            {
                SongId = Guid.NewGuid(),
                Author = "Q",
                AlbumName = "W",
                Title = "E",
                Length = 1.2
            };
            songList.Add(song);

            Song song2 = new Song
            {
                SongId = Guid.NewGuid(),
                Author = "A",
                AlbumName = "B",
                Title = "C",
                Length = 2.2
            };
            songList.Add(song2);

            Song song3 = new Song
            {
                SongId = Guid.NewGuid(),
                Author = "Zx",
                AlbumName = "Cv",
                Title = "Bn",
                Length = 1.5
            };
            songList.Add(song3);

            builder.Entity<Song>().HasData(songList);
        }
    }
}
