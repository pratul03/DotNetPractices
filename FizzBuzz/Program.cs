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
            bool threeDiv = false;
            bool fiveDiv = false;
            for (int num = 1; num <=15; num++)
            {
                threeDiv = num % 3 == 0;
                fiveDiv = num % 5 == 0;
                if ( num < 0)
                {
                    Console.WriteLine("Invalid");
                }else if( threeDiv && fiveDiv )
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
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
