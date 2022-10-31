using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints the current date and time to the console.
            DateTime currentDateTime = new DateTime();
            Console.WriteLine(DateTime.Now);

            //Asks the user for a number.
            Console.WriteLine("Give me a number");
            int x = Convert.ToInt32(Console.ReadLine());

            //Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.WriteLine("It will be: {0} in {1} hours", DateTime.Now.AddHours(x), x);
            Console.ReadLine();
            //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

        }
    }
}
