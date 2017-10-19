using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String.Trim
{
    class Program
    {
        static void Main(string[] args)
        {
            //I.Remove "white-spaces" from string with method ".Trim()" //Премахване на празните полета от стринг(в това число влизат и символите за нов ред и за табулации)
            //////////////////////////////////////////////////
            string userName = "  \n\n  \t  Jonie English    ";
            string correctUserData = userName.Trim();  //without ".Trim()" we have two new lines, tabulation and some white-spaces.
            //////////////////////////////////////////////////
            Console.WriteLine(correctUserData);
            //
            //If we want to remove the white spaces only at the beginning or in end of the
            //string, we can use the methods TrimStart(...) and TrimEnd(...)
            //
            //Ia.Advanced function on .Trim() //методът Trim(), може да премахва/зачиства и подадени от нас символи
            ////////////////////////////////////////////////////////////////////
            string userName2 = "   111 $ %    David Allen  ### s    ";
            char[] unneededChars = new char[] { ' ', '1', '$', '%', '#', 's' };
            string correctUserData2 = userName2.Trim(unneededChars);
            ////////////////////////////////////////////////////////////////////
            Console.WriteLine(correctUserData2);

            //II.ОСОБЕНОСТИ на метода .Trim()
            //ще се опитаме да изтрием всички празни места, '0'-ли и 'а'-та...
            ////////////////////////////////////////////////////////////////////////////////
            string test = "00000aaaaaa0000aaaaaa  B  aaaaa   00000a0a0a0a0a0a0a someString";
            char[] trimParameters = { ' ', '0', 'a' };
            string result = test.TrimStart(trimParameters);
            Console.WriteLine(result);
            ////////////////////////////////////////////////////////////////////////////////
            //ВАЖНО! – ".Trim()" методът работи до момента в койо не срещне символ РАЗЛИЧЕН от посочените 
            //за "трим"-ване, в случая това е буквата "В", след нея той ПРЕКРАТЯВА по-нататъшни операции!
            //
            //Възможно решние е с метода .Replace()
            ///////////////////////////////////////
            string result2 = test.Replace(" ", "")
                                 .Replace("0", "")
                                 .Replace("a", "");
            ///////////////////////////////////////
            Console.WriteLine(result2);

        }
    }
}
