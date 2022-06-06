using MusicApp.View.Interfaces;

namespace MusicApp.View
{
    public class MenuDisplay : IMenu
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
