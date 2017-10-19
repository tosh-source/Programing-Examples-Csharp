using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class InputOutput_fromKeyBoard
{
    static void Main()
    {
        //I.
        Console.Write("Please enter some key of keyboard: ");
        ConsoleKeyInfo someKey = Console.ReadKey();   //.ReadKey, чете само ЕДИН символ (първият въведен) от клавиатурата!
        Console.WriteLine("\n" + "Key: [{0}]", someKey.Key);
        Console.WriteLine("KeyChar: [{0}]", someKey.KeyChar);
        Console.WriteLine("Special keys: [{0}]", someKey.Modifiers);
        Console.WriteLine("Key number: [{0}]", (int)someKey.Key);

        //Ia.catching Escape button
        Console.WriteLine("Please enter \"Escape\" key..");
        ConsoleKeyInfo someKey2 = Console.ReadKey();
        if (someKey2.Key == ConsoleKey.Escape)
        {
            Console.WriteLine(new string('_', 25));
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nYou press \"Escape\" key!");
            Console.ResetColor();
            Console.WriteLine(new string('_', 25));
        }
        else
        {
            Console.WriteLine("YOU HAVE NOT PRESS ESCAPE KEY!!!");
        }
        Console.WriteLine();

        //II.Елементарена методика за постоянно въвеждане от клавиатурата, посредством метода "Console.ReadKey()".
        while (true)
        {
            ConsoleKeyInfo abc = Console.ReadKey();
            Console.WriteLine(" | KeyChar: {0}", abc.KeyChar);
        }

    }
}
