using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplicationStep185
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes an input from the user, multiplies it by 50, then prints the result to the console. (Note: make sure your code can take inputs larger than 10, 000, 000).
            Console.WriteLine("Give me a number, I WANT A NUMBER! I will multiply it by 50. You can make this one a big number");
            double theyGaveIT = Convert.ToInt32(Console.ReadLine()) * 50;
            Console.WriteLine(theyGaveIT);
            Console.ReadLine();
            //Takes an input from the user, adds 25 to it, then prints the result to the console.
            Console.WriteLine("Give me a number, I WANT A NUMBER! I will add 25 to it.");
            Console.WriteLine(Convert.ToInt32(Console.ReadLine()) + 25);
            Console.ReadLine();
            //Takes an input from the user, divides it by 12.5, then prints the result to the console.
            Console.WriteLine("You have not given anything worth computing. Provide adequate enumeration. I will divide it by 12.5");
            Console.WriteLine(Convert.ToInt32(Console.ReadLine()) / 12.5);
            Console.ReadLine();
            //Takes an input from the user, checks if it is greater than 50, then prints the true / false result to the console.
            Console.WriteLine("Give me a number between 1 and 100. Maybe then I will find appreciation for your existence. I'll check if it's greater than 50");
            bool isGreater = Convert.ToInt32(Console.ReadLine()) > 50;
            Console.WriteLine(isGreater);
            Console.ReadLine();
            //Takes an input from the user, divides it by 7, then prints the remainder to the console(tip: think % operator).
            Console.WriteLine("This one is hard. Give me ANY whole number. Make it easy. I'm gonna divide it by 7, and give you back anything left over");
            Console.WriteLine(Convert.ToInt32(Console.ReadLine()) % 7);
            Console.ReadLine();
            //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
        }
    }
}
