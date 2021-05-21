using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using MyCat;

class Reflection
{
    public static string newLine = Environment.NewLine;

    static void Main(string[] args)
    {
        //Reflection is possibility to get types, methods, properties from some kind of object at runtime.

        //1.Use Reflection for INSTANCE of unknown class.
        var cat = new Cat { Name = "Gosho", Color = "White" };

        Console.WriteLine("Type: " + cat.GetType().Name + newLine);

        var objProperties = cat.GetType().GetProperties();
        foreach (var property in objProperties)
        {
            Console.WriteLine("Property Name: "
                                + property.Name + ": "
                                + property.GetValue(cat));
        }

        Console.WriteLine();
        Console.WriteLine("GetMethod: " + cat.GetType().GetMethod("SayMiauuu"));
        Console.WriteLine("GetProperty: " + cat.GetType().GetProperty("Color").Name);

        //2.Use Reflection for unknown class.
        var objMethods = typeof(Cat).GetMethods();

        Console.WriteLine(newLine + "Class "
                                  + typeof(Cat).Name
                                  + " have: ");
        foreach (var currentMethod in objMethods)
        {
            Console.WriteLine("Method Name: " + currentMethod.Name);
        }
    }
}

//more examples with 'typeof', look in project: typeof_Example/TypeOfExample.cs
//see video --> Обща система от типове в .NET (CTS) - 25 март 2015 - Ивайло.mp4 (time: 1:07:27)
// https://www.infoworld.com/article/3027240/how-to-work-with-reflection-in-c.html