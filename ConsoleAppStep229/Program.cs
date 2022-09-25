using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStep229
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do a boolean comparison using a while statement.
            int countDown = 100;
            while (countDown < 0)
            {
                Console.WriteLine(countDown);
                countDown--;
            }

            //Do a boolean comparison using a do while statement.
            int countUp = 0;
            do
            {
                Console.WriteLine(countUp);
                countUp++;
            }
            while (countUp < 100);
                
            //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. 
        }
    }
}
