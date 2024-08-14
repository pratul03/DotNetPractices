using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a number to Check : ");
            //int num = Convert.ToInt32(Console.ReadLine());

            for (int num = 1; num <=15; num++)
            {
                if( num < 0)
                {
                    Console.WriteLine("Invalid");
                }else if( num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(num % 3 == 0 && num % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (num % 5 == 0 && num % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
