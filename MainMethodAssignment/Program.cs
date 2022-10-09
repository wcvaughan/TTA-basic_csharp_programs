using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var MathOV = new MathOV();

            Console.WriteLine("Give me your digit");

            int x = Convert.ToInt32(Console.ReadLine());

            int result = MathOV.Moth(x);

            Console.WriteLine(result);

            Console.WriteLine("Give me another digit");

            int y = Convert.ToInt32(Console.ReadLine());

            int result1 = MathOV.Moth(y);

            Console.WriteLine(result1);

            Console.WriteLine("Last time, write me a number");

            string lmno = Console.ReadLine();

            string result2 = MathOV.Moth(lmno);

            Console.ReadLine();
        }
    }
}
