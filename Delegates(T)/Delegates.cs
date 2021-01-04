using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_T_
{
    public delegate int SimpleDelegate<T>(T inputMethod);

    class Delegates
    {
        static void Main(string[] args)
        {
            SimpleDelegate<string> firstSimpleDelegate = int.Parse;
            SimpleDelegate<int> secondSimpleDelegate = SimpleMethod;


            var parseFirstDelegate = firstSimpleDelegate("234");
            Console.WriteLine(parseFirstDelegate);
            parseFirstDelegate = secondSimpleDelegate(45678);
            Console.WriteLine(parseFirstDelegate);
        }

        public static int SimpleMethod(int integer = 456)
        {
            return integer;
        }
    }
}
