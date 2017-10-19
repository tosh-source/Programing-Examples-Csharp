using System;


class BooleanLogicalDemo
{
    static void Main()
    {
        int a = 1;
        int b = 2;

        bool greaterAB = (a > b);
        bool equalA1 = (a == 1);

        if (greaterAB)
        {
            Console.WriteLine("A > B");
        }
        else
        {
            Console.WriteLine("A <= B");
        }
        Console.WriteLine("greaterAB = " + greaterAB);
        Console.WriteLine("equalA1 = " + equalA1);
    }
}

