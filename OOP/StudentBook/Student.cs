using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPattern
{
    public class Student
    {
        public string FirstName;            //field
        public string LastName;             //field
        public int Age;                     //field
        public static string Information;   //static field

        public Student()  //Constructor
        {
            Information = "This is digital book for Students.";
        }
    }
}
