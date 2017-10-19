using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCat
{
    public class Cat
    {
        //field
        private string name;
        //field
        private string color;

        public string Name  //Property "Name"
        {
            get
            {   //Getter of the property "Name"
                return this.name;
            }
            set
            {   //Setter of the property "Name"
                this.name = value;
            }
        }

        public string Color  //Property "Color"
        {
            get
            {   //Getter of the property "Color"
                return this.color;
            }
            set
            {   //Setter of the property "Color"
                this.color = value;
            }
        }

        //Constructor - Default constructor
        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }
        //Constructor with parameters
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        //Method Miauuu
        public void SayMiauuu()
        {
            Console.WriteLine("{0} said: Miauuuuuuuu!", name);
        }

        static void Main(string[] args)
        {
            Cat myFirstCat = new Cat();
            myFirstCat.Name = "Tony";
            Console.WriteLine("Cat {0} is {1}.", myFirstCat.Name, myFirstCat.Color);
            myFirstCat.SayMiauuu();

            Cat mySecondCat = new Cat("Pepy", "red");
            mySecondCat.SayMiauuu();
            Console.WriteLine("Cat {0} is {1}.", mySecondCat.Name, mySecondCat.Color);

            Cat thirdCat = new Cat();
            thirdCat.Name = "Alfred";
            Console.WriteLine("The name of my third cat is {0}.", thirdCat.Name);
            thirdCat.SayMiauuu();

        }
    }
}
