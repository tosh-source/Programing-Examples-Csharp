using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class Bitwise_Techniques
{
    static void Main(string[] args)
    {
        //Bitwise Calculation with BigInteger (Left & Right shift bitwise operations)
        //
        //input
        Console.Write("enter bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());
        //calculation
        BigInteger positiveResult = (BigInteger)1 << bitPosition;
        BigInteger negativeResult = (BigInteger)(-1) << bitPosition;
        //print
        Console.WriteLine("positive:\n " + positiveResult + "\n\nnegative:\n" + negativeResult + "\n");

        //Invert values (from positive to negative integer number)
        int bit = 39;
        Console.WriteLine(~bit + 1);

    }
}
