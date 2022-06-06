using MusicApp.Data.Context;
using MusicApp.Handler;
using MusicApp.Utils;
using MusicApp.View;

namespace MusicApp
{
    public class Program
    {
        public static void Main()
        {
            MusicAppContext musicApp = new();
            PlaylistHandler playlist = new(
                new Data.DAL.SongRepository(musicApp),
                new InputValidator(),
                new Output(),
                new MenuDisplay()
                );
            playlist.Run();
        }
    }
}
