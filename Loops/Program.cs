using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For each loop
            /*string a = "Sibani";
            foreach (char i in a) {
                Console.Write(i);
                Console.Write(" ");
            }*/

            /* For Loop 
            Console.Write("Enter max number you want to sum : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 0; i <=num; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum upto number {0} is :{1}",num,sum);*/

            /* While Loop */

            Console.Write("Enter any number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter any number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int res = num1 * num2;

            Console.Write("What is the value of {0} * {1} ?",num1,num2);
            int actualAnswer = 0;

            while ( res != actualAnswer)
            {
                Console.WriteLine("Enter your answer : ");
                string answer = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answer);

                if (res != actualAnswer)
                {
                    Console.WriteLine("Invaild answer!");
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine("Correct answer!");

        }
    }
}
