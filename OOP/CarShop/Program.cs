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


            //BONUS
			//All customer as one (create array of our object)            
			Customer[] customers = new Customer[] { customerBlago, customerSlavi, customerIvan};
			foreach (var customer in customers)
			{
				Console.WriteLine();
				Print(customer.FirstName, customer.LastName, customer.Age, customer.CustomerCarModel);
			}
		}

		static void Print(string firstName, string lastName, int age, string customerCarModel)
        {
            Console.WriteLine(firstName + " "
                            + lastName
                            + $", Age: {age}"
                            + $", Buy car: {customerCarModel}");
        }
    }
}
