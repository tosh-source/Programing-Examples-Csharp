using System;
using System.Collections.Generic;


namespace CarShop.CarShopClasses
{
    class Customer
    {
        //fields
        private string firstName;
        private string lastName;
        private int age;
        private string customerCarModel;
        private static string aboutCustomer;

        //Property FirstName
        public string FirstName
        {
            get  //Getter of the property "FirstName"
            {
                return this.firstName;
            }
            set //Setter of the property "FirstName"
            {
                this.firstName = value;
            }
        }
        //Property LastName
        public string LastName
        {
            get  //Getter of the property "LastName"
            {
                return this.lastName;
            }
            set  //Setter of the property "LastName"
            {
                this.lastName = value;
            }
        }
        //Property Age
        public int Age
        {
            get  //Getter of the property "Age"
            {
                return this.age;
            }
            set  //Setter of the property "Age"
            {
                this.age = value;
            }
        }
        //Property CustomerCarModel
        public string CustomerCarModel
        {
            get  //Getter of the property "CustomerCarModel"
            {
                return this.customerCarModel;
            }
            set  //Setter of the property "CustomerCarModel"
            {
                this.customerCarModel = value;
            }
        }


        //Property AboutCustomer
        public static string AboutCustomer
        {
            get  //Getter of the property "AboutCustomer"
            {
                aboutCustomer = "Information about all CarShop customers";
                return aboutCustomer;
            }
        }

        //Default Constructor with parameters
        public Customer(string firstName = "Unknown", string lastName = "Unknown", int age = 0, string customerCarModel = "Unknown") 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.customerCarModel = customerCarModel;
        }
    }
}
