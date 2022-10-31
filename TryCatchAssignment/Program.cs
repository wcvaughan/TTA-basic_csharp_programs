using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exceptions must be handled using “try/catch.”
            try
            {
                bool validAnswer = false;
                int userAge = 0;
                //Ask the user for their age.
                while (!validAnswer)
                {
                    Console.WriteLine("How many times have you circumvented Sol?");
                    validAnswer = int.TryParse(Console.ReadLine(), out userAge);
                    if (!validAnswer) Console.WriteLine("You must enter a whole number.");
                }
                if (userAge < 0)
                {
                    throw new NumException();
                }
                if (userAge == 0)
                {
                    throw new NumException();
                }
                //Display the year the user was born.
                var currentYear = DateTime.Now;
                Console.WriteLine("The year you began your journey was {0}", currentYear.Year - userAge);
                Console.ReadLine();
            }
            //Display appropriate error messages if the user enters zero or negative numbers.
            catch (NumException)
            {
                Console.WriteLine("You cannot be unborn, or in your zeroth year.");
                Console.ReadLine();
                return;
            }
            //Display a general message if an exception was caused by anything else.
            catch (Exception)
            {
                Console.WriteLine("You did not provide the answer I expected.");
                Console.ReadLine();
                return;
            }
            //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
        }
    }
}
