using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_T_
{
    //I.Delegates
    public delegate void TestDelegate(string text);
    //II.Generic Delegates
    public delegate int GenericDelegate<T>(T inputMethod);

    class Delegates
    {
        static void Main(string[] args)
        {
            //I.Test delegates
            var myDelegate = new TestDelegate(TextMethod);
            myDelegate("My Test Delegate!");

            //*multicast delegates
            myDelegate += new TestDelegate(SecondTextMethod);
            myDelegate("My SECOND test Delegate!");


            //II.Generic Delegates
            GenericDelegate<string> customIntParse = int.Parse;
            var getValuesFromDelegates = customIntParse("234");
            Console.WriteLine(getValuesFromDelegates);

            GenericDelegate<int> getIntFromMethod = IntegersMethod;
            getValuesFromDelegates = getIntFromMethod(45678);
            Console.WriteLine(getValuesFromDelegates);

            //*multicast delegates
            getValuesFromDelegates = customIntParse("100");
            getValuesFromDelegates += getIntFromMethod(20);
            Console.WriteLine("multicast delegates: {0}", getValuesFromDelegates);
        }

        public static int IntegersMethod(int integer)
        {
            return integer;
        }

        public static void TextMethod(string someText)
        {
            Console.WriteLine(someText);
        }

        public static void SecondTextMethod(string someText)
        {
            Console.WriteLine(someText);
        }
    }
}
