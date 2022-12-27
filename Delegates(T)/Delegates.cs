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

            //Ia.multicast delegates
            myDelegate += new TestDelegate(SecondTextMethod);
            myDelegate += new TestDelegate(ThirdColoredTextMethod);
            myDelegate("My SECOND test Delegate!");   //<- Call delegate (and run all assigned method one by one).
            //NOTE: Delegates run methods in the same order in which they are assigned.

            //II.Generic Delegates
            GenericDelegate<string> customIntParse = int.Parse;
            var getValuesFromDelegates = customIntParse("234");
            Console.WriteLine(getValuesFromDelegates);

            GenericDelegate<int> getIntFromMethod = IntegersMethod;
            getValuesFromDelegates = getIntFromMethod(45678);
            Console.WriteLine(getValuesFromDelegates);

            //Get and calculate results from different delegates to one common variable.
            getValuesFromDelegates = customIntParse("100");
            getValuesFromDelegates += getIntFromMethod(20);  //<-- Don't mistake this "+=" with multicast functionality in delegates (see above)!! Here we just add two integers and get result from this addition.
            Console.WriteLine("multicast delegates: {0}", getValuesFromDelegates);


            //III. Use predefined delegates, Action<T1,T2,T3> and Func<T1,T2,TResult>
            //NOTE: "Action" is generic predefined void delegate.
            //NOTE: "Func" is generic predefined delegate with return type TResult.
            Console.WriteLine("\n" + "Use same methods from example \"I.Test delegates\"");
            ////////////////////////////////////////////////
            Action<string> myDelegateAsAction = TextMethod;
            myDelegateAsAction += SecondTextMethod;
            myDelegateAsAction += ThirdColoredTextMethod;
            myDelegateAsAction("My SECOND test Delegate!");
            ////////////////////////////////////////////////
            
            Console.WriteLine("\n" + "Use same methods from example \"II.Generic Delegates\"");
            ////////////////////////////////////////////////
            Func<string, int> customIntParseAsFunc = int.Parse;
            getValuesFromDelegates = customIntParseAsFunc("234");
            Console.WriteLine(getValuesFromDelegates);
            ////////////////////////////////////////////////
        }

        public static void TextMethod(string someText)
        {
            Console.WriteLine(someText);
        }

        public static void SecondTextMethod(string someText)
        {
            Console.WriteLine(someText);
        }

        public static void ThirdColoredTextMethod(string someText)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(someText);
            Console.ResetColor();
        }

        public static int IntegersMethod(int integer)
        {
            return integer;
        }
    }
}
