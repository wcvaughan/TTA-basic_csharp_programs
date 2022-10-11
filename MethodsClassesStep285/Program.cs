using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsClassesStep285
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.

            //In the Main() method, instantiate that class.
            var OverLoaded = new OverLoaded();

            //Have the user enter a number. Call the method on that number. Display the output to the screen.
            //It should be the entered number, divided by two.
            Console.WriteLine("I like numbers. Feed me!");

            int userNum = Convert.ToInt32(Console.ReadLine());

            OverLoaded.OogyBoogy(userNum);

            Console.ReadLine();

            //Create a method with output parameters.

            //Overload a method.

            //Declare a class to be static.

            //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
        }
    }
}
