using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InputOutput_Techniques_ConsoleFonts
{
    class ConsoleFonts
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            //Use current font and try to print Cyrillic symbols. <--(will NOT work)
            Console.WriteLine(Console.OutputEncoding);
            Console.WriteLine("АБВГДЕЖЗ");

            //Change font to UTF8 and print Cyrillic symbols.
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(Console.OutputEncoding);
            Console.WriteLine("АБВГДЕЖЗ");


            //Change console width and height.
            Console.WindowWidth = 50;
            Console.WindowHeight = 25;

            Console.BufferWidth = 50;
            Console.BufferHeight = 25;
        }
    }
}
