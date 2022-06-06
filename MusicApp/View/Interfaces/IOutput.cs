namespace MusicApp.View.Interfaces
{
    public interface IOutput<T>
    {
        public void DisplayAll(List<T> entity);
        public void DisplayOptions();
    }
}
