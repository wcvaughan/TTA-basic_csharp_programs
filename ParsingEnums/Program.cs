using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        public enum DayOfTheWeek
        {
            Monday=1,
            Tuesday=2,
            Wednesday=3,
            Thursday=4,
            Friday=5,
            Saturday=6,
            Sunday=7
        }

        static void Main(string[] args)
        {
            //Create an enum for the days of the week.

            //Prompt the user to enter the current day of the week.

            Console.WriteLine("What is today?");

            //Assign the value to a variable of that enum data type you just created.
            try
            {
                string userToday = Console.ReadLine();
                DayOfTheWeek userDay = (DayOfTheWeek)Enum.Parse(typeof(DayOfTheWeek), userToday);
                Console.WriteLine("Today is " + userToday);
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
            //Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.

            //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.


        }
    
    }

}
