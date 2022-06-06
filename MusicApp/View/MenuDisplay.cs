using MusicApp.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
