using System;
using System.Text;

class SubstringExample
{
    static void Main()
    {
        //SubString method example
        Console.WriteLine("Please enter some integer, like: 123456789 and see the \".Substring\" method result..");
        string allnumbs = (string)(Console.ReadLine());
        ///////////////////////////////////////
        string num1 = allnumbs.Substring(0, 1);  //STRUCTURE--> stringName.Substring(int startIndex, int length)
        string num2 = allnumbs.Substring(1, 1);  
        string num3 = allnumbs.Substring(2);     //Start FROM third position from selected string (index[3]) to the END of string
        string num4 = allnumbs.Substring(3, 2);  //stringName.Substring(int startIndex, int length)--> Start from position 4 with next 2 chars from string.
        ///////////////////////////////////////
        Console.WriteLine("{0} {1} {2} {3}", num1, num2, num3, num4);

        //How to use .SubString() in StringBuilder(). 
        //There is NO special method with name "SubString" here. This function is covered FROM  
        //another method, ".ToString()", which is DIFFERENT from other "ToString" implementation.
        StringBuilder sb = new StringBuilder("This is a Test");
        /////////////////////////////////
        string test = sb.ToString(10, 4); //equivalent to -> .Substring(startIndex, length)
                                          /////////////////////////////////
        Console.WriteLine(test);   // output = Test
    }
}

/* Начин за визуализиране на определен част (в случая буквата "о", която е номер 5) от въведения стринг     
        string abc = "  Todor   ";
        Console.WriteLine(abc[5]);
*/
