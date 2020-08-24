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

        static void Sort<T>(T[] items) where T : IComparable<T>
        {
            for (int firstItem = 0; firstItem < items.Length; firstItem++)
            {
                for (int secondItem = firstItem + 1; secondItem < items.Length; secondItem++)
                {
                    if (items[secondItem].CompareTo(items[firstItem]) < 0)
                    {
                        var tempItem = items[firstItem];
                        items[firstItem] = items[secondItem];
                        items[secondItem] = tempItem;
                    }
                }
            }
        }
    }
}

//виж видеото на Дончо -> "Дефиниране На Класове - Част 2 - 12 Март 2015 (Дончо)" -> ВРЕМЕ 00:56:35