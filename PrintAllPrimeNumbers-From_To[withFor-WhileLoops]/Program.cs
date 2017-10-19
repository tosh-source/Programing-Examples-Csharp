using System;


class PrintAllPrimeNumbers_From_To_withFor_WhileLoops
{
    static void Main()
    { //Print all prime numbers in the interval from [n], to [m]
        Console.Write("from = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("to   = ");
        int m = int.Parse(Console.ReadLine());
        if ((n > 1) && (n < m))
        {
            for (int num = n; num <= m; num++)
            {
                bool prime = true;
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(num);
                while (divider <= maxDivider)
                {
                    if (num % divider == 0)
                    {
                        prime = false;
                        break;
                    }
                    divider++;
                }
                if (prime)
                {
                    Console.Write("{0} ", num);
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid range!");
        }
    }
}


//Втори вариянт на програмата. Но тук я написах с два "for" цикъла, вместо с един "for" и един "while".
//
//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());
//
//for (int num = n; num <= m; num++)
//{
//    int minDivider = 2;
//    int maxDivider = (int)(Math.Sqrt(num));
//    bool prime = true;
//
//    for (int i = minDivider; i <= maxDivider; i++)
//    {
//        if (num % i == 0)
//        {
//            prime = false;
//            break;
//        }
//    }
//
//    if (prime)
//    {
//        Console.Write(num + " ");
//    }
//}
//Console.WriteLine();
