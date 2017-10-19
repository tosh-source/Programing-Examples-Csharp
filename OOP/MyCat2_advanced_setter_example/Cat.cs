using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCat2_advanced_setter_example
{
    class Cat
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set //Setter should be "private" to guarantee that set of a cat name use ONLY setter "setName"! <- BETTER practice!
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentException("Invalid cat's name!!!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set //In normal structure of setter (with "public" access), value can be parsed in Constructor and SKIP all code here! <- WRONG practice!
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid cat's year!!!");
                }
                this.age = value;
            }
        }

        public Cat(string name, int age)
        {
            this.Name = name; //Use this structure of code to guarantee that set of a cat name use ONLY setter "setName"! <- BETTER practice!
            this.age = age;   //In normal structure of Constructor(and setter) value will be parsed here! <- WRONG practice!
        }
    }
}
