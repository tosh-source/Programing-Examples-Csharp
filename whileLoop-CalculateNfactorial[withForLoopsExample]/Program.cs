using System;
using System.Numerics;


namespace whileLoop_CalculateNfactorial_withForLoopsExample_
{
    class Program
    {
        static void Main()
        { //Програма за пресмятане на n фактурел
            int n = int.Parse(Console.ReadLine());
            // Calculate n! = 1 * 2 * ... * n
            BigInteger result = 1;
            Console.Write("!n = ");
            while (true)
            {
                Console.Write(n);
                if (n == 1)
                {
                    break;
                }

                Console.Write(" * ");
                result *= n;
                n--;
            }
            Console.WriteLine(" = " + result);


            //Пресмятане във вид на for цикъл:
            //
            //BigInteger factorial = 1;
            //for (BigInteger i = 0; i < 10000000000000000000; i++)
            //{
            //    factorial *= i;
            //    Console.Write("{0} ", i);
            //}
            //Console.WriteLine();


            //Трети вариянт написан от мен!
            //
            //uint n = uint.Parse(Console.ReadLine());
            //BigInteger nFactur = 1;
            //Console.Write("n! = {0} ", n);
            //while (true)
            //{
            //    if (n <= 1)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.Write("*");
            //    }
            //    nFactur *= n;
            //    n--;
            //    Console.Write(" {0} ", n);
            //}
            //Console.Write("= {0} \n", nFactur);
        }
    }
}
