using System;


class whileLoop_SumOfValue
{
    static void Main()
    {
        Console.Write("Please enter, the integer vlue n = ");
        string consoleInput = Console.ReadLine();
        int n = int.Parse(consoleInput);
        int number = 0;
        int sum = 0;
        Console.Write("The sum: ");
        while (number < n)
        {
            number++;
            sum += number;
            if (number == n)
            {
                Console.Write("{0}", number);
            }
            else
            {
                Console.Write("{0}+", number);
            }
        }
        Console.WriteLine(" = {0}", sum);
    }
}

