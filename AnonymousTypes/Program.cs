using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create anonymous types
            var pets = new[]
            {
                new { Name="Sharo", Age=8 },
                new { Name="Rex", Age=4 },
                new { Name="Strela", Age=1 },
                new { Name="Bora", Age=3 }
            };

            var orderedPets = pets.OrderBy(pet => pet.Age);

            foreach (var currentPet in orderedPets)
            {
                Console.WriteLine(currentPet);
            }
        }
    }
}
