using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user for a number.

            Console.WriteLine("Give me your valuable digit.");

            //Logs that number to a text file.

            int userNum = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter file = new StreamWriter(@"C:\Users\chris\Logs\log2.txt", true))
            {
                file.WriteLine(userNum);
            }

            //Prints the text file back to the user.

            Console.WriteLine("Here is the numbers you gave me");

            Console.WriteLine(File.ReadAllText(@"C:\Users\chris\Logs\log2.txt"));

            Console.ReadLine();

            //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

        }
    }
}
