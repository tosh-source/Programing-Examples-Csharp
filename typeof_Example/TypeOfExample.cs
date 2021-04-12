using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        //1. "typeof"
        Console.WriteLine(typeof(string).IsArray);      //питаме компилатора "string", масив ли е или не?.. отг: False --> (стринга е class)
        Console.WriteLine(typeof(Console).IsClass);     //питаме "Console", клас ли е или не?.. отг: True --> (class System.Console)
        Console.WriteLine(typeof(BigInteger).IsClass);  //...отг: False --> (BigInteger не е class)
        Console.WriteLine(typeof(int).IsClass);         //... отг: False --> (int не е class)
        Console.WriteLine(typeof(int).IsArray);         //... отг: False
        Console.WriteLine(typeof(int[]).IsArray);       //... отг: True
        Console.WriteLine(typeof(object).IsClass);

        Console.WriteLine(new string('*', 15));

        //2. със "is" (за разлика от "typeof") можем да проверим видът на променлива създадена от нас
        int someInt = 55;
        Console.WriteLine(someInt is object);       //отг: True
        Console.WriteLine(someInt is string);       //отг: False
        Console.WriteLine(someInt is Array);        //отг: False
        Console.WriteLine(someInt is int);          //отг: True
        Console.WriteLine(someInt is BigInteger);   //отг: False
        Console.WriteLine("abc" is object);         //отг: True
        Console.WriteLine("abc" is int);            //отг: False

        Console.WriteLine(new string('*', 15));

        //3. Още един метод за проверка на типа обект
        Console.WriteLine(8.GetType().FullName);                //System.Int32
        Console.WriteLine(7.GetType().Name);                    //Int32
        Console.WriteLine("some string".GetType().FullName);    //System.String

        Console.WriteLine(new string('*', 15));

        //4. Examples / Примери
        /////////////////////////////////////////
        object someObject = 123;
        if (someObject.GetType() == typeof(int))
        {
            Console.WriteLine("{0} is: {1}", someObject, someObject.GetType());
        }
        /////////////////////////////////////////
        /////////////////////////////////////////
        if (someObject is double)
        {
            Console.WriteLine("{0} is: double", someObject);
        }
        else if (someObject is int)
        {
            Console.WriteLine("{0} is: integer", someObject);
        }
        /////////////////////////////////////////

    }
}
/////////////////////////////////////////////////
//"typeof" takes a type name(which you specify at compile time).
/////////////////////////////////////////////////
//"GetType" gets the runtime type of an instance.
/////////////////////////////////////////////////
//"is" returns true if an instance is in the inheritance tree.
/////////////////////////////////////////////////

//Looking for Reflection? --> take a look in project: OOP/Reflection/Reflection.cs

//for more information: https://stackoverflow.com/questions/983030/type-checking-typeof-gettype-or-is
//for more information: https://stackoverflow.com/questions/17495402/typeoft-vs-object-gettype-performance?noredirect=1&lq=1
