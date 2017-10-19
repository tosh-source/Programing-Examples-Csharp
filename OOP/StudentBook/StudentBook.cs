using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentPattern;

class StudentBook
{
    static void Main()
    {
        Student studentGosho = new Student();
        studentGosho.FirstName = "Georgi";
        studentGosho.LastName = "Ivanov";
        studentGosho.Age = 20;

        Console.WriteLine(studentGosho.FirstName + " "
                        + studentGosho.LastName + ", Age: "
                        + studentGosho.Age);

        Console.WriteLine(Student.Information);
    }
}

