﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;

class ConsoleAppExperiments_III
{
    static void Main(string[] args)
    {
        //закръгляне на число
        //double precise = 8.7654321;
        //double round3 = Math.Round(precise, 3);
        //double round1 = Math.Round(precise, 1);
        //Console.WriteLine(precise + string.Format("{0,20}", "(without rounding)"));
        //Console.WriteLine(round3 + string.Format("{0,29}", "(three digits rounding)"));
        //Console.WriteLine(round1 + string.Format("{0,28}", "(one digit rounding)"));

        string abc = "(3+5.3)*2.7-ln(22)/pow(2.2,-1.7)";
        for (int i = 0; i < abc.Length; i++)
        {
            Console.WriteLine($"{abc[i]} = " + " / "
                            + char.IsDigit(abc[i]) + " / "
                            + char.IsPunctuation(abc[i]) + " / "
                            + char.IsSeparator(abc[i]) + " / "
                            + char.IsControl(abc[i]) + " / ");
        }


        //търсене в архив и проерка за избягване на exception в един if()
        string[] mathematicalFunctions = { "ln", "sqrt", "pow" };
        Stack<string> operatorsStack = new Stack<string>();

        if (operatorsStack.Count > 0 && (Array.IndexOf(mathematicalFunctions, operatorsStack.Peek())) > -1) //при "съкратения" булев израз "&&" (логическо И), се проверява първото условие и ако е вярно, чак тогава се минава към второто. Това предпазва от exception, ако например, НЯМАШЕ елемент в Stack-a.
        {

        }
    }

}
