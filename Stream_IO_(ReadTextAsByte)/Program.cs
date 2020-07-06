using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream_IO__ReadTextAsByte_
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathToTXTfile = @"..\..\testDoc.txt";
            var byteReader = new FileStream(pathToTXTfile);
        }
    }
}
