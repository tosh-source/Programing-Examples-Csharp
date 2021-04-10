using MyCat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementGetEnumerator_CatOwner
{
    class Tests
    {
        static void Main(string[] args)
        {
            //Based on "Separation of concerns" pattern, Owner logic is separated of Enumerator logic.

            var cats = new List<Cat>
                {
                    new Cat { Name = "Gosho", Color = "White" },
                    new Cat { Name = "John", Color = "Black"},
                    new Cat { }
                };

            var owner = new Owner("Stefy", cats);

            Console.WriteLine("Owner: " + owner.Name + " have cats:");
            //Test GetEnumerator implementation and get cats.
            foreach (var cat in owner)
            {
                Console.WriteLine(cat.Name);
            }
        }
    }
}
