using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Print_Figure
{
    class Dictionary_Print_Figure
    {
        static void Main(string[] args)
        {
            var tmpDict = new Dictionary<string, byte[,]>();

            tmpDict.Add("first figure", new byte[,]
            {
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,1,0,0,0,0 },
                {0,0,0,1,1,1,0,0,0 },
                {0,1,1,0,1,0,1,1,0 },
                {0,1,1,1,0,1,1,1,0 },
                {0,1,1,1,1,1,1,1,0 },
                {0,0,1,1,1,1,1,0,0 },
                {0,0,1,1,1,1,1,0,0 },
                {0,0,0,0,0,0,0,0,0 },
            });
            tmpDict.Add("second figure", new byte[,]
            {
                {0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,1,1,0,0,0 },
                {0,0,0,1,1,1,1,0,0 },
                {0,0,1,1,1,0,1,0,0 },
                {0,0,0,1,0,1,1,0,0 },
                {0,0,0,0,1,1,1,0,0 },
                {0,0,0,1,1,1,0,0,0 },
                {0,0,1,1,1,1,1,0,0 },
                {0,0,0,0,0,0,0,0,0 },
            });

            var toPrint = tmpDict["first figure"];
            PrintMethod(toPrint);

            toPrint = tmpDict["second figure"];
            PrintMethod(toPrint);
        }

        private static void PrintMethod(byte[,] toPrint)
        {
            for (int row = 0; row < toPrint.GetLength(0); row++)
            {
                for (int col = 0; col < toPrint.GetLength(1); col++)
                {
                    if (toPrint[row, col] != 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
