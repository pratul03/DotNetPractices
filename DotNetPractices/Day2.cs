using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices
{
    internal class Day2
    {
        static void Main(string[] args)
        {
            //datatype identifier = value;
            Console.WriteLine("=======INPUT======");
            string age = Console.ReadLine();
            int age2 = Convert.ToInt32(age);

            //
            Console.WriteLine("=======INPUT======");
            int age3 = Convert.ToInt32(Console.ReadLine());

            //
            Console.WriteLine();
            Console.WriteLine("Sibani is "+ age2 + " years old & Pratul is "+ age3 + " years old");
            Console.WriteLine();
            Console.WriteLine("Sibani is {0} years old & Pratul is {1} years old",age2,age3);
        }
        
    }
}
