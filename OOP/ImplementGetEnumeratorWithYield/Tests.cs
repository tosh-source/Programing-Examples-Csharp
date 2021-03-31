using System;
using System.Collections.Generic;
using System.Linq;
using MyCat;

namespace ImplementGetEnumeratorWithYield
{
    class Tests
    {
        static void Main(string[] args)
        {
            Cat[] cats =
                {
                    new Cat { Name = "Gosho", Color = "White" },
                    new Cat { Name = "John", Color = "Black"},
                    new Cat { }
                };

            CatsEnumerator<Cat> catsEnumerator = new CatsEnumerator<Cat>();
            catsEnumerator.GetCats = cats;

            //Use "yield" implementation in foreach loop.
            foreach (var cat in catsEnumerator)
            {
                Console.WriteLine(cat.Name);
            }
        }
    }
}
