using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.IO;

class ConsoleAppExperiments_II
{
    static void Main()
    {
        bool contOrNot = true;
        while (contOrNot)
        {
            

            ////Намиране на нечетни числа от 0 до 10 посредством функцията "деление с остатък".
            ////////////////////////////////////////////////////
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine("The number is odd!");
            //    }
            //}
            ////////////////////////////////////////////////////

            //---------------------------
            contOrNot = ContinueMethod();
            //---------------------------
        }
    }
    //-----------------------------
    static bool ContinueMethod()
    {
        //bool contOrNot = true;
        Console.Write("Continue? Y/n (or simply press enter): ");
        string userChoice = Console.ReadLine();
        if ((userChoice == "N") || (userChoice == "n"))
        {
            return false;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(new string('=', 30));
            Console.ResetColor();
            return true;
        }
    }
    //-----------------------------
    //Methods..

}