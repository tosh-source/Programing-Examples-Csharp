using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression_LINQ_II
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skip unneeded elements and take only wished ones.

            var listOfStudents = new[]
            {
            new { FirstName = "Ivan", LastName = "Dimov", Age = 20 },
            new { FirstName = "Dragan", LastName = "Tsankov", Age = 20 },
            new { FirstName = "Khan", LastName = "Asparuh", Age = 33},
            new { FirstName = "Jon", LastName = "Brown", Age = 20 },
            new { FirstName = "Ivan", LastName = "Stefanov", Age = 33 },
            new { FirstName = "Vera", LastName = "Georgieva", Age =  45 },
            new { FirstName = "Vera", LastName = "Aleksieva", Age = 17 }
            };

            var takeThreeStudents = listOfStudents.Skip(2)   //Skip first two objects
                                                  .Take(3);  //and take next three.

            foreach (var currentStudent in takeThreeStudents)
            {
                Console.WriteLine(currentStudent);
            }
        }
    }
}
