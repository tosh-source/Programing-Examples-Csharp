using System;


class NumberInRange_withWhileLoop
{
    static void Main()
    {
        //Number in Range (with WhileLoop)
        int? Number = null;
        do
        {
            Console.Write("Please enter number in range (100…500):");
            Number = int.Parse(Console.ReadLine());
        } while (Number < 100 || Number > 500);

        //Друг метод събран на два реда:
        Console.Write("\nPlease enter number in range (100…500):");
        int num;
        while (!int.TryParse(Console.ReadLine(), out num) || num < 100 || num > 500) Console.WriteLine("Invalid number!!!");
    }
}
