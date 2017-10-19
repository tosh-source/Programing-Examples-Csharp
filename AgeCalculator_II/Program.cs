using System;
class Program
{
    static void Main()
    {
        // using DateTime and its methods AddYears() for adding years to the result and Substract() -> for substract birth year and current year
        Console.Write("Enter your birthday in format(dd.mm.yyyy): ");
        DateTime userBirthday = DateTime.Parse(Console.ReadLine());
        long resulut = DateTime.Today.Subtract(userBirthday).Ticks;
        Console.WriteLine("You are {0} years old.", new DateTime(resulut).Year - 1);
        Console.WriteLine("After 10 years uou will be {0} years old.", new DateTime(resulut).AddYears(10).Year - 1);
    }
}