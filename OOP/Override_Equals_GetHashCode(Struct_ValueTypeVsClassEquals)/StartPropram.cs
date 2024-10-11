using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_Equals_GetHashCode_Struct_ValueTypeVsClassEquals_
{
    class StartPropram
    {
        static void Main(string[] args)
        {
            //I.Test class Person with override methods Equals() and GetHashCode().
            var firstPerson = new Person("Wallace", 75);
            var secondPerson = new Person("", 42);
            secondPerson.Name = "Wallace";
            secondPerson.Age = 75;

            CompareTwoInstances(firstPerson, secondPerson);

            //II.Test class Person with NO override methods Equals() and GetHashCode().
            var firstPersonWithNoEquals = new PersonWithNoEquals("Wallace", 75);
            var secondPersonWithNoEquals = new PersonWithNoEquals("", 42);
            secondPersonWithNoEquals.Name = "Wallace";
            secondPersonWithNoEquals.Age = 75;

            CompareTwoInstances(firstPersonWithNoEquals, secondPersonWithNoEquals);

            //III. Test structs WITHOUT override ANY methods Equals() or GetHashCode().
            //NOTE: All structs are Value Types, because implicitly inherit System.ValueType.
            var firstPersonAsValueType = new PersonAsValuType("Wallace", 75);
            var secondPersonAsValueType = new PersonAsValuType("", 42);
            secondPersonAsValueType.Name = "Wallace";
            secondPersonAsValueType.Age = 75;

            CompareTwoInstances(firstPersonAsValueType, secondPersonAsValueType);
        }

        public static void CompareTwoInstances<T>(T firstPerson, T secondPerson)
        {
            if (secondPerson.Equals(firstPerson))
            {
                Console.WriteLine("firstPerson and secondPerson have the same values. Reference method .Equals() is used.");
            }
            if (Object.Equals(secondPerson, firstPerson))
            {
                Console.WriteLine("firstPerson and secondPerson have the same values. Static method Object.Equals() is used.");
            }
            else
            {
                Console.WriteLine("Instance and static methods Equals() can't compare this two equal objects!");
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Name == person.Name &&
                   Age == person.Age;
        }

        public override int GetHashCode()
        {
            int hashCode = -1360180430;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            return hashCode;
        }
    }

    public class PersonWithNoEquals
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public PersonWithNoEquals(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public struct PersonAsValuType
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public PersonAsValuType(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}

//More info about Struct Instances vs. Class Instances: https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/objects
//Moreinfo about override Equals Method in C#: https://dotnettutorials.net/lesson/why-we-should-override-equals-method/
