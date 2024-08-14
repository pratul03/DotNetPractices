using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NumericFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money1 = 100D / 24.9D;
            Console.WriteLine(money1);

            //string formatting
            Console.WriteLine(string.Format("{0:0.00}", money1)); // its works same as below
            Console.WriteLine("{0:0}",money1);
            Console.WriteLine("{0:0.0}", money1);
            Console.WriteLine("{0:0.00}", money1);
            ///

            double money = -10D / 3D;
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            ///Globalization
            ///
            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-IN")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));



        }
    }
}
