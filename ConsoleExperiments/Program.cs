using System;

class AgeAfter10Years
{
    static void Main()
    {
        //Problem 15. Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
        string input;
        DateTime birthday;
        Console.WriteLine("Enter Your Birthday in this Format(YYYY-MM-DD): ");
        input = Console.ReadLine();
        birthday = Convert.ToDateTime(input);
        DateTime today = DateTime.Today;
        int age = today.Year - birthday.Year;
        if (birthday > today.AddYears(-age)) age--;
        Console.WriteLine("Now, you are {0} years old.", age);
        age = age + 10;
        Console.WriteLine("After 10 years you will be {0} years old", age);
    }
}