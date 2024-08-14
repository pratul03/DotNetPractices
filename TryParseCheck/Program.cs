using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success = true;
            while (success)
            {
                Console.WriteLine("Enter a number : ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    success = false;
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine("Failed to Convert.");
                }
            }
            
        }
    }
}
