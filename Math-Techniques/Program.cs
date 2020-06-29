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
            //I.Pow() method
            //INPORTANT: Use "BigInteger.Pow()" for more PRECISION result, instead of "Math.Pow()"
            //
            //Ia. BigInteger.Pow()
            BigInteger result = 0;
            ////////////////////////////////////
            result = 9 * BigInteger.Pow(9, 100);
            ////////////////////////////////////
            Console.WriteLine(result);
            //
            //Ib. Math.Pow() <- 
            BigInteger result2 = 0;
            ///////////////////////////////////////////
            result2 = 9 * (BigInteger)Math.Pow(9, 100);
            ///////////////////////////////////////////
            Console.WriteLine("\n" + result2);

            //II.Digit rounding (закръгляне на число)
            double precise = 8.7654321;
            double round3 = Math.Round(precise, 3);
            double round1 = Math.Round(precise, 1);
            Console.WriteLine(precise + string.Format("{0,20}", "(without rounding)"));
            Console.WriteLine(round3 + string.Format("{0,29}", "(three digits rounding)"));
            Console.WriteLine(round1 + string.Format("{0,28}", "(one digit rounding)"));

        }
    }
}

//Performing Math operations on decimal data-type in C# -> https://stackoverflow.com/questions/4124189/performing-math-operations-on-decimal-datatype-in-c

