using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int result = program.Add(4, 5);
            Console.WriteLine(result);
            Program.run();
        }
        public static void run()
        {
            Console.WriteLine("Program started");
        }

        public int Add( int a, int b)
        {
            return a + b;
        }
    }
}
