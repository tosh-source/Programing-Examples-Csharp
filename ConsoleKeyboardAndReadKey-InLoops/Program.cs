using System;



class ConsoleKeyboardAndReadKey_InLoops
{
    static void Main()
    {
        while(true)
        {
            if (Console.KeyAvailable)
             {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine("The name of the key is: " + key.Key);
             }
        }            
    }
}

