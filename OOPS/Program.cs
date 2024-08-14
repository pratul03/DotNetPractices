using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
//Reaference variable of Class Student
            Student obj1 = new Student(); //Creating object of class Student
            obj1.name = "Pratul";
            obj1.rollNo = 1;
            obj1.email = "pratulmakar02@gmail.com";
            obj1.Display();
            //static method can be called without creating object reference
            Console.WriteLine(Student.age(20));
            Student.method1();
        }
    }

    class Student
    {
        public static int age(int age)
        {
            return age;
        }
        //instance variables
        public string name;
        public int rollNo;
        public string email;

        public void Display()// public method/function display
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Email: " + email);
        }
        // We can not use non-static variable in static method without creating object reference
        public static void method1()
        {
            Student obj = new Student();
            obj.name = "Pratul";
            Console.WriteLine(obj.name);
        }
    }
}
