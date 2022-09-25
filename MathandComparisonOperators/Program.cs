using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathandComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine("Five plus Ten = " + total.ToString());
            Console.WriteLine(combined);
            Console.ReadLine();

            int difference = 10 - 5;
            Console.WriteLine("Ten minus Five = " + difference.ToString());
            Console.ReadLine();

            int product = 10 * 5;
            Console.WriteLine(product);
            Console.ReadLine();

            int quotient = 100 / 5;
            Console.WriteLine(quotient);
            Console.ReadLine();

            double quotientThree = 100 / 5;
            Console.WriteLine(quotient);
            Console.ReadLine();

            int quotientTwo = 100 % 17;
            Console.WriteLine(quotientTwo);
            Console.ReadLine();

            int remainder = 11 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();

            bool trueOrfalse = 12 > 5;
            Console.WriteLine(trueOrfalse.ToString());
            Console.ReadLine();

            bool trueOrfalseTwo = 12 < 5;
            Console.WriteLine(trueOrfalseTwo.ToString());
            Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 72;

            bool isWarm = currentTemperature > roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();

            bool isWarmTwo = currentTemperature >= roomTemperature;
            Console.WriteLine(isWarmTwo);
            Console.ReadLine();

            bool isWarmThree = currentTemperature != roomTemperature;
            Console.WriteLine(isWarmThree);
            Console.ReadLine();

        }
    }
}
