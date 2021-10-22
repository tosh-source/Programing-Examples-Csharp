using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_Equals_GetHashCode_Clone_CompareTo_StudentClass.Models
{
    class Student
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SocialSecurityNumber { get; set; } //Student Social Security Number (SSN. E.g. "000-00-0000" 

        public Student() : this(string.Empty, string.Empty, string.Empty, 0)
        {
        }

        public Student(string firstName, string middleName, string lastName, int socialSecurityNumber)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialSecurityNumber = SocialSecurityNumber;
        }

        public override bool Equals(object obj)
        {
            var student = obj as Student;

            if (student != null &&
                   this.FirstName == student.FirstName &&
                   this.MiddleName == student.MiddleName &&
                   this.LastName == student.LastName &&
                   this.SocialSecurityNumber == student.SocialSecurityNumber)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override int GetHashCode()
        {
            int hashCode = 743017444;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MiddleName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + SocialSecurityNumber.GetHashCode();
            return hashCode;
        }
    }
}
