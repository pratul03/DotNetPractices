﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
            }
        }
    }
}
