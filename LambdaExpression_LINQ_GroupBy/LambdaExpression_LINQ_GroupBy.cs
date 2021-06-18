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
            //I. Group Students by ages, using LINQ extension methods.
            Console.WriteLine("Group Students by ages.");

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
            //NOTE: 'GroupBy' should always be in last position in queries! Example: .Where() -> .OrderBy() -> GroupBy()

            foreach (var currentGroup in studentsByGroups)
            {
                Console.WriteLine(currentGroup.Key);  //Get grouping criteria
                foreach (var student in currentGroup)
                {
                    Console.WriteLine(student.FirstName + " " + student.LastName);
                }
            }

            //II.Group numbers by their remainder, using LINQ query keywords.
            var divisor = 5;
            Console.WriteLine(Environment.NewLine + 
                              $"Group numbers by their remainder, when divided by {divisor}.");

            var arrayOfNumbers = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var groupsOfNumbers =
                from number in arrayOfNumbers
                group number by number % divisor into newGroup
                select new { Remainder = newGroup.Key, Numbers = newGroup };

            foreach (var currentGroupOfNumbers in groupsOfNumbers)
            {
                Console.WriteLine($"Remainder: {currentGroupOfNumbers.Remainder}");
                foreach (var number in currentGroupOfNumbers.Numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
