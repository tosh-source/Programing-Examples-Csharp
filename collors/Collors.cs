using System;


class Collors
{
    static void Main()
    {
        Console.Title = "color test program";
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        //Console.WindowWidth = 100;  //Ако зададем дължина и височина на конзолата, непосредствено след командата за оцветяване 
        //Console.WindowHeight = 28;  //("Console.BackgroundColor"), тогава се оцветява целия екран на консолата, не само полето зад текста!
        Console.WriteLine("Console color test");
        Console.WriteLine("Console color test 2");
        Console.ResetColor();

        Console.WriteLine("Console color reset test");
    }
}
