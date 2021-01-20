using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression_LINQ_GroupBy
{
    class LambdaExpression_LINQ_GroupBy
    {
        static void Main(string[] args)
        {
            //Using Anonymous Type.
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

            //Group Student by their ages.
            var studentsByGroups = listOfStudents.GroupBy(student => student.Age).ToList();

            foreach (var currentGroup in studentsByGroups)
            {
                Console.WriteLine(currentGroup.Key);  //Get grouping criteria
                foreach (var student in currentGroup)
                {
                    Console.WriteLine(student.FirstName + " " + student.LastName);
                }
            }
        }
    }
}
