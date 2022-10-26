using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, create an object of data type Number and assign an amount to it.

            Number number1 = new Number();

            number1.Amount = 5.5m;

            //Print this amount to the console.

            Console.WriteLine(number1.Amount);
            Console.ReadLine();

            //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
    }
}
}
