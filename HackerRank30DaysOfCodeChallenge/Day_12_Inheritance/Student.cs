namespace Day_12_Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class Student
    {
        protected string firstName;
        protected string lastName;
        int phone;
        public Student(string fname, string lname, int p)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.phone = p;

        }
        public void display()
        {// display the details of the student
            Console.WriteLine("First Name: " + this.firstName + "\nLast Name: " + this.lastName + "\nPhone: " + this.phone);
        }

    }
}
