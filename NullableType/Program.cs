using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods in nullable types, that are not present in primitive data types.
            int? someInt = 11;
            Console.WriteLine(someInt.HasValue);
            Console.WriteLine(someInt.Value);
            someInt = null;
            Console.WriteLine(someInt.HasValue);
        }
    }
}
