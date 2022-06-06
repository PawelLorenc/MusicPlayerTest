using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Utils
{
    public interface IINputSystem
    {
        public string FetchStringValue(string prompt);
        public int FetchIntValue(string prompt);
        public int FetchIntValue(string prompt, int maximumImputNumber);
        public decimal FetchDecimalValue(string prompt);
    }
}
