using MusicApp.Data.Entities;
using MusicApp.View.Interfaces;

namespace MusicApp.View
{
    public class Output : IOutput<Song>
    {
        private IMenu menu = new MenuDisplay();
        public void DisplayAll(List<Song> entity)
        {
            for (int i = 0; i < entity.Count; i++)
                Console.WriteLine("Index: " + i + " | Album: " + entity[i].AlbumName + " | Author: " + entity[i].Author + " | Length: " + entity[i].Length + " | Title: " + entity[i].Title);
        }

        public void DisplayOptions()
        {
            menu.PrintMessage("[1] To Add song\n" + "[2] To delete song\n" + "[3] To display all songs\n" + "[4] Sort songs\n" + "[5] Display specific song\n" + "[0] To quit");
        }
    }
}
