using static System.Console;

namespace MusicApp.Utils
{
    public class InputValidator : IINputSystem
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
            while (!isInt || !(fetchInt < maximumImputNumber && fetchInt >= 0))
            {
                string stringToParese = ReadLine();
                isInt = int.TryParse(stringToParese, out fetchInt);
                if (!isInt || !(fetchInt < maximumImputNumber && fetchInt >= 0))
                {
                    WriteLine("Provided input is not an integer or not it is not in range");
                    WriteLine(prompt);
                }
            }
            return fetchInt;
        }
        public double FetchDoubleValue(string prompt)
        {
            WriteLine(prompt);
            bool isDouble = false;
            double fetchDouble = 0;
            while (!isDouble)
            {
                string stringToParese = ReadLine();
                isDouble = double.TryParse(stringToParese, out fetchDouble);
                if (!isDouble)
                {
                    WriteLine("Provided input is not double");
                }
            }
            return fetchDouble;
        }
    }
}
