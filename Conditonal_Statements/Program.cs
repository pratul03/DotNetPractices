using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditonal_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "20";
            int a = Convert.ToInt32(s);
            //if statement
            //type checking of indentifier/variable s 
            if( s.GetType() == typeof(string))
            {
             Console.WriteLine("The total length of the string s is : {0}",s.Length);
            }
            else {
             Console.WriteLine("Debanjan bobor");
            }

            
            Console.Write("Enter your age :");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 0 || age > 110)
            {
                Console.WriteLine("Invalid age--");
            }
            else if (age>0 && age<= 10)
            {
                Console.WriteLine("You are {0} years old child.",age);
            }
            else if (age > 10 && age <= 18)
            {
                Console.WriteLine("You are {0} years old teenager.", age);
            }
            else if(age > 18 && age <= 30)
            {
                Console.WriteLine("You are {0} years old Adult.", age);
            }
            else
            {
                Console.WriteLine("You are {0} years old enough for calculating your age.", age);
            }

            // Ternary Operator.
            
            Console.Write("Enter any number to check if it is even or odd :");
            int num = Convert.ToInt32(Console.ReadLine());
            string res = (num < 0) ? "Invalid number" : (num % 2 == 0) ? "Even number" : "Odd number";
            Console.WriteLine("The number {0} is {1}",num,res);

        }
    }
}
