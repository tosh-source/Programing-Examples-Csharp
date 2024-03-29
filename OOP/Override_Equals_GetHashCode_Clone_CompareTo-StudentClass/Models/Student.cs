﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_Equals_GetHashCode_Clone_CompareTo_StudentClass.Models
{
    class Student : ICloneable, IComparable<Student>
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
            this.SocialSecurityNumber = socialSecurityNumber;
        }

        public override string ToString()
        {
            var result = string.Empty;
            var newLine = Environment.NewLine;

            result += "Student name: " + this.FirstName + " " + this.MiddleName + " " + this.LastName + newLine;
            result += "SocialSecurityNumber: " + this.SocialSecurityNumber + newLine;

            return result;
        }

        public override bool Equals(object obj) //*
        {
            var student = obj as Student;  //Using keyword "as" will try to cast object. If fail the object will be null. In this situation standard direct cast ((Student) obj) will throw an exception!

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

        public override int GetHashCode() //*
        {
            int hashCode = 743017444;

            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.MiddleName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.LastName);
            hashCode = hashCode * -1521134295 + this.SocialSecurityNumber.GetHashCode();

            return hashCode;
        }

        public object Clone()
        {
            //Shallow copy with MemberwiseClone().
            //Work only for ValueTypes NOT for reference one!
            var clonedStudent = this.MemberwiseClone() as Student;

            //Deep copy.
            //TRY THIS: Comment the code (in region) below and use GetHashCode() to compare two Student objects.
            //In our class we have only primitive values (ValueTypes), so for that reason MemberwiseClone() is enough for now. 
            #region DeepCopy
            clonedStudent.FirstName = string.Copy(this.FirstName);
            clonedStudent.MiddleName = string.Copy(this.MiddleName);
            clonedStudent.LastName = string.Copy(this.LastName);
            clonedStudent.SocialSecurityNumber = this.SocialSecurityNumber;
            #endregion

            return clonedStudent;
        }

        public int CompareTo(Student otherStudent) //Condition**
        {
            var firstCriteria = (this.FirstName + this.MiddleName + this.LastName)
                .CompareTo(otherStudent.FirstName + otherStudent.MiddleName + otherStudent.LastName);
            var secondCriteria = this.SocialSecurityNumber.CompareTo(otherStudent.SocialSecurityNumber);

            if (firstCriteria == 1)  //If 1 -> FIRST object is bigger!
            {
                if (secondCriteria == 0) //isEqual
                {
                    return firstCriteria;
                }
                else
                {
                    return secondCriteria;
                }
            }
            else if (firstCriteria == -1)  //if -1 -> SECOND object is bigger!
            {
                if (secondCriteria == 0) //isEqual
                {
                    return firstCriteria;
                }
                else
                {
                    return secondCriteria;
                }
            }
            else if (firstCriteria == 0)
            {
                return secondCriteria;
            }
            else
            {
                throw new ArgumentException("Provided students cannot be compared!");
            }
        }

        public static bool operator ==(Student firstStudent, Student secondStudent) //***
        {
            return Student.Equals(firstStudent, secondStudent);
        }
        public static bool operator !=(Student firstStudent, Student secondStudent) //***
        {
            return Student.Equals(firstStudent, secondStudent);
        }
    }
}

//More about override .Equals() and GetHashCode(), see video: "Обща система от типове в .NET (CTS) - 25 март 2015 - Ивайло" in time: |0:57:05 - 1:02:40|

//* This methods can be auto generated by VS! Select all fields/properties and right click mouse button -> Quick actions -> Generate .Equals() and GetHashCode().

//Condition** --> Compare by names, then by Social Security Number. NOTE: Students may have same names, but Social Security Number should be different. If not, and the Social Security Numbers are equals -> check again by names (return firstCriteria).

//*** Good practice:
//================
//1. It's better to override reference .Equals() first! NOTE: .GetHashCode() is needed for .Equals()!
//2. After that you can use STATIC method object.Equals(). This will avoid copy/paste code.
//2a.REMEMBER to use STATIC method object.Equals()/Student.Equals() when overload operators (== and !=) !!! 
//2a.If reference .Equals()/firstStudent.Equals() is used instead in static operator ==/!=, the program behavior will be unpredictable and an a exception can be thrown!
