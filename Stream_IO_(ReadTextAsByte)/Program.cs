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
            var pathToTXTfile = @"..\..\testDoc1 (symbols in Cyrillic-UTF8).txt";
            Console.WriteLine("First text");
            TextAsByteReader(pathToTXTfile);

            var secondPathToTXTfile = @"..\..\testDoc2 (symbols in Latin-UTF8).txt";
            Console.WriteLine(Environment.NewLine + "Second Text:");
            TextAsByteReader(secondPathToTXTfile);

            var thirdPathToTXTfile = @"..\..\testDoc3 (symbols in Cyrillic-UTF8).txt";
            Console.WriteLine(Environment.NewLine + "Third Text:");
            TextAsByteReader(thirdPathToTXTfile);

            var folderOnDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                                                            + Path.DirectorySeparatorChar         //This is OS independent path slash getter. Backslash in Win and slash in Unix.
                                                            + "createSomeTXTfileForTests.txt";    //This mean: ~\Desktop + \\ + createSomeTXTfileForTests.txt
            Console.WriteLine(Environment.NewLine + "Text file on Desktop: ");
            TextAsByteReader(folderOnDesktop);
        }

        private static void TextAsByteReader(string pathToTXTfile)
        {
            try
            {
                using (var allTextAsByte = new FileStream(pathToTXTfile, FileMode.Open))
                {
                    for (int counter = 1; counter <= allTextAsByte.Length; counter++)
                    {
                        int currenByte = allTextAsByte.ReadByte();

                        Console.Write("{0:X} ", currenByte);

                        //Create new line after every 10 byte. 
                        //This is just for grouping amount of bytes.
                        if (counter % 10 == 0) Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("TXT file was not found!" + Environment.NewLine);
            }
            catch (Exception er)
            {
                Console.WriteLine("Unexpended error! " + er.Message);
            }
        }
    }
}
