using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MusicApp.Utils
{
    internal class InputValidator : IINputSystem
    {
        public string FetchStringValue(string prompt)
        {
            WriteLine(prompt);
            return ReadLine();
        }

        public int FetchIntValue(string prompt)
        {
            WriteLine(prompt);
            bool isInt = false;
            int fetchInt = 0;
            while (!isInt)
            {
                string stringToParese = ReadLine();
                isInt = int.TryParse(stringToParese, out fetchInt);
                if (!isInt)
                {
                    WriteLine("Provided input is not an integer");
                }
            }
            return fetchInt;
        }
        public int FetchIntValue(string prompt, int maximumImputNumber)
        {
            WriteLine(prompt);
            bool isInt = false;
            int fetchInt = 1;
            while (!isInt || !(fetchInt <= maximumImputNumber && fetchInt > 0))
            {
                string stringToParese = ReadLine();
                isInt = int.TryParse(stringToParese, out fetchInt);
                if (!isInt || !(fetchInt <= maximumImputNumber && fetchInt > 0))
                {
                    WriteLine("Provided input is not an integer or not it is not in range");
                    WriteLine(prompt);
                }
            }
            return fetchInt;
        }
        public decimal FetchDecimalValue(string prompt)
        {
            WriteLine(prompt);
            bool isDecimal = false;
            decimal fetchDec = 0;
            while (!isDecimal)
            {
                string stringToParese = ReadLine();
                isDecimal = decimal.TryParse(stringToParese, out fetchDec);
                if (!isDecimal)
                {
                    WriteLine("Provided input is not a decimal number");
                }
            }
            return fetchDec;
        }
    }
}
