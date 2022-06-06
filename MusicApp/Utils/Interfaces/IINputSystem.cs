namespace MusicApp.Utils
{
    public interface IINputSystem
    {
        public string FetchStringValue(string prompt);
        public int FetchIntValue(string prompt);
        public int FetchIntValue(string prompt, int maximumImputNumber);
        public double FetchDoubleValue(string prompt);
    }
}
