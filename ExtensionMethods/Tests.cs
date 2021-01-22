using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Tests
    {
        static void Main(string[] args)
        {
            //Using Anonymous Type.
            var students = new[]
            {
                new { FirstName = "Jon", LastName = "Brown", Age = 23 },
                new { FirstName = "Ivan", LastName = "Stefanov", Age = 19 },
                new { FirstName = "Vera", LastName = "Georgieva", Age =  45 },
                new { FirstName = "Vera", LastName = "Aleksieva", Age = 17 }
            };

            //Creating extension method and add "ForEach" loop functionality in collections.
            students.ForEach(Console.WriteLine);
        }
    }
}
