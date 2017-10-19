using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(ObjectsCounter.NextValue());
            }

            ObjectsCounter.Reset();
            Console.WriteLine("\nReset counter\n" + ObjectsCounter.NextValue() + "\n");
        }
    }
}
