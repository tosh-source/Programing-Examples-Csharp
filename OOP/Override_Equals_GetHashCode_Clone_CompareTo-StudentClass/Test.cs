using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Override_Equals_GetHashCode_Clone_CompareTo_StudentClass.Models;

namespace Override_Equals_GetHashCode_Clone_CompareTo_StudentClass
{
    class Test
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student {FirstName = "Ivan", LastName = "Ivanov"},
                new Student {FirstName = "Gradi", LastName = "Draganov"},
                new Student {FirstName = "Kiro", LastName = "Stefanov"},
            };

            //Use overwritten ToString().
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            //Clone students
            Student[] cloneStudents = (Student[])students.Clone();
            //Or cast with keyword "as" --> "students.Clone() as Student[]"  
            //NOTE: This will skip exception if cast is not successful and as return type we will have NULL!

            Console.WriteLine("Is equals: " + cloneStudents.Equals(students));
            Console.WriteLine("Is equals by ref: " + Student.ReferenceEquals(cloneStudents, students));

            //Use implemented GetHashCode() method.
            Console.WriteLine($"{cloneStudents.GetType().Name}.GetHashCode(): " + cloneStudents.GetHashCode());
            Console.WriteLine($"{students.GetType().Name}.GetHashCode(): " + students.GetHashCode() + "\n");

            //Compare two objects/students
            for (int current = 0; current < cloneStudents.Length; current++)
            {
                Console.WriteLine("Compare students, is equal: " 
                    + cloneStudents[current].CompareTo(students[current]));
            }

            cloneStudents[0] = new Student { FirstName = "Alex", LastName = "Smith" };

            for (int current = 0; current < cloneStudents.Length; current++)
            {
                Console.WriteLine("Compare students, is equal: "
                    + cloneStudents[current].CompareTo(students[current]));
            }
        }
    }
}
