using MusicApp.Data.Context;
using MusicApp.Data.Entities;

namespace MusicApp.Data.DAL
{
    public class SongRepository : IBaseRepository<Song>
    {
        private MusicAppContext _musicAppContext;

        public SongRepository(MusicAppContext musicAppContext)
        {
            _musicAppContext = musicAppContext;
        }

        public void Add(Song entity)
        {
            _musicAppContext.Add(entity);
        }

        public List<Song> GetAll()
        {
            return _musicAppContext.Songs.ToList();
        }

        public void Remove(Song etnity)
        {
            _musicAppContext.Remove(etnity);
        }

        public void Update(Song entity)
        {
            _musicAppContext.Songs.Update(entity);
        }
        public void Save()
        {
            _musicAppContext.SaveChanges();
        }
    }
}
