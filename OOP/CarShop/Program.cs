using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarShop.CarShopClasses;

namespace CarShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //First customer
            Customer customerIvan = new Customer();
            customerIvan.FirstName = "Ivan";
            customerIvan.LastName = "Ivanov";
            customerIvan.Age = 23;
            CarModels currentCarForSell = CarModels.BMV;
            customerIvan.CustomerCarModel = currentCarForSell.ToString();
            
            Print(customerIvan.FirstName, customerIvan.LastName, customerIvan.Age, customerIvan.CustomerCarModel);

            //Second customer
            Customer customerSlavi = new Customer("Slavi", "Hristov", 19, CarModels.Ferrari.ToString());
            Print(customerSlavi.FirstName, customerSlavi.LastName, customerSlavi.Age, customerSlavi.CustomerCarModel);

            //Third customer
            Customer customerBlago = new Customer("Blago", "Georgiev", customerCarModel: CarModels.Honda.ToString());  //using of optional parameters: "customerCarModel:" to skip "Age" value
            Print(customerBlago.FirstName, customerBlago.LastName, customerBlago.Age, customerBlago.CustomerCarModel);

        }

        static void Print(string FirstName, string LastName, int Age, string CustomerCarModel)
        {
            Console.WriteLine(FirstName + " "
                            + LastName
                            + $", Age: {Age}"
                            + $", Buy car: {CustomerCarModel}");
        }
    }
}
