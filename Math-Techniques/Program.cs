using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Math_Techniques
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use "BigInteger.Pow()" for more PRECISION result, instead of "Math.Pow()"
            //
            //BigInteger.Pow()
            BigInteger result = 0;
            ////////////////////////////////////
            result = 9 * BigInteger.Pow(9, 100);
            ////////////////////////////////////
            Console.WriteLine(result);

            //Math.Pow() <- 
            BigInteger result2 = 0;
            result2 = 9 * (BigInteger)Math.Pow(9, 100);
            Console.WriteLine("\n" + result2);
        }
    }
}
