using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsClassesStep285
{
    class OverLoaded
    {
        //Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.
        public void OogyBoogy(int given)
        {
            int getItAway = given / 2;
            Console.WriteLine(getItAway);
        }

        public void OogyBoogy(int given, out int getItAway2)
        {
            int getItAway = given / 2;
            getItAway2 = 0;
        }

        //In the Main() method, instantiate that class.

        //Have the user enter a number. Call the method on that number.
        //Display the output to the screen. It should be the entered number, divided by two.

        //Create a method with output parameters.

        //Overload a method.

        //Declare a class to be static.

        //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
    }
}
