using System;

namespace AbstractionAndLooseCoupled_Printer
{
    class StartProgram
    {
        static void Main(string[] args)
        {
            //Loose coupled Printer.  //NOTE: All classes here is in one file for easy understanding.
            
            var ivan = new Employee
            {
                NameOfEmployee = "Ivan Ivanov",
                Salary = 1200
            };

            var printEmployeeInformation = new Printer();
            printEmployeeInformation.StartPrint(ivan);


            var message = new Page { Message = "Show this message to all clients!" };
            var messageToPrint = new Printer();
            messageToPrint.StartPrint(message);
        }
    }
}

interface IInforationProvader
{
    string GetData();
}

class Printer  //Loose coupled Printer. This class can print every other object that implement "IInforationProvader" and his method "GetData()".
{
    public void StartPrint(IInforationProvader inforation)
    {
        Console.WriteLine(inforation.GetData());
    }
}

class Employee : IInforationProvader
{
    public string NameOfEmployee { get; set; }
    public int Salary { get; set; }

    public string GetData()
    {
        var result = string.Empty;

        result += NameOfEmployee + Environment.NewLine;
        result += Salary;

        return result;
    }
}

class Page : IInforationProvader
{
    public string Message { get; set; }

    public string GetData()
    {
        return Message;
    }
}

