using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_T_methods
{ 
    class Generic_T_methods
    {
        static void Main(string[] args)
        {
        }

        static void PrintArray<T>(T[] items, string separator = null)
        {
            if (separator == null)
            {
                separator = ", ";
            }

            foreach (T item in items)
            {
                Console.Write(item);
                Console.Write(separator);
            }
            Console.WriteLine();
        }
    }
}

//виж видеото на Дончо -> "Дефиниране На Класове - Част 2 - 12 Март 2015 (Дончо)" -> ВРЕМЕ 00:56:35