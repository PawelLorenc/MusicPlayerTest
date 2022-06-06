namespace MusicApp.Data.DAL
{
    public interface IBaseRepository<T> where T : class
    {
        public List<T> GetAll();
        public void Add(T entity);
        public void Remove(T etnity);
        public T GetSingle(Func<T, bool> condition);
    }
}
