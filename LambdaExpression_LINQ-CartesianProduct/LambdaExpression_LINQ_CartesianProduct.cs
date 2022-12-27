using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression_LINQ_CartesianProduct
{
    class LambdaExpression_LINQ_CartesianProduct
    {
        static void Main(string[] args)
        {
            var cars = new[] { "BMW", "Mercedes", "Ferrari", "Lamborghini" };
            var enginesHorsepower = new[] { 165, 200, 220, 360, 400 };  //Type of engines with different horse powers.

            //Use LINQ syntax.
            var equippedCars =
                from car in cars
                from engine in enginesHorsepower
                select new { Car = car, Engine = engine };

            Console.WriteLine("Cartesian product by using LINQ:");
            foreach (var currentCar in equippedCars)
            {
                Console.WriteLine("Car {0}, with engine with {1} horsepower. ", currentCar.Car, currentCar.Engine);
            }

            //Use expression methods.
            var equippedCarsByExtMethods = cars
                .SelectMany(car => enginesHorsepower, (c, e) => new { Car = c, Engine = e });

            Console.WriteLine("\n" + "Cartesian product by using lambda expression methods:");
            foreach (var currentCar in equippedCarsByExtMethods)
            {
                Console.WriteLine("Car {0}, with engine with {1} horsepower. ", currentCar.Car, currentCar.Engine);
            }
        }
    }
}

//Lambda Expression joins two arrays, and gets cartesian product.: https://linqsamples.com/linq-to-objects/projection/SelectMany-lambda-csharp

//Just for reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
//Different ways of using SelectMany(): https://stackoverflow.com/questions/4283866/different-ways-of-using-selectmany#4284201