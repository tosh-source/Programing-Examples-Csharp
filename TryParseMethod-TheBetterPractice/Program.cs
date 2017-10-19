using System;


class TryParseMethod_TheBetterPractice
{
    static void Main()
    {
        string str = Console.ReadLine();
        int number;
        if (int.TryParse(str, out number))
        {
            Console.WriteLine("Valid number: {0}", number);
        }
        else
        {
            Console.WriteLine("Invalid number: {0}", str);
        }
    }
}


/* Малко по кратък, но по объркващ варянт:
 
        string str = Console.ReadLine();
        int number;
        bool parseSuccessOrNo = Int32.TryParse(str, out number);
        Console.WriteLine(parseSuccessOrNo ?
        "The number is: " + number : "Invalid number!");
*/