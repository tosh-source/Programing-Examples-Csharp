using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCat2_advanced_setter_example
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat("Tony", 3);
            Console.WriteLine("First cat: {0} is on: {1} years", firstCat.Name, firstCat.Age);

            Cat secondCat = new Cat("Ivan", -1);  //<- This will NOT throw Exception, which is wrong! Cat can not be at age "-1"!
            Console.WriteLine("Second cat: {0} is on: {1} years", secondCat.Name, secondCat.Age);

            Cat thirdCat = new Cat(null, 2);  //<- This will throw Exception, which IS correct! <- BETTER practice!
            Console.WriteLine("Third cat: {0} is on: {1} years", thirdCat.Name, thirdCat.Age);
        }
    }
}
