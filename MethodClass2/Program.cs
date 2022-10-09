using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a class. In that class, create a void method that takes two integers as parameters.
            //Have the method do a math operation on the first integer and display the second integer to the screen.

            //In the Main() method of the console app, instantiate the class.
            var void2par = new void2par();
            //Call the method in the class, passing in two numbers.
            Console.WriteLine("We're gonna do two numbers, 5 and 500");
            int a = 5;

            int b = 500;

            int result = void2par.Parapow(a, b);
            //Call the method in the class, specifying the parameters by name.
            int result2 = void2par.Parapow(a: a, b: b);

            //Add comments to each line or block of your code to explain what it does exactly,
            //so that another developer could read and understand your code.

        }
    }
}
