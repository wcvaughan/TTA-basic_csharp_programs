using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method of the console app, instantiate the class.

            var DosNumeros = new DosNumeros();

            //Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.

            Console.WriteLine("Give me two numerals that you thought of yesterday. But only one at a time. \nYou also could just give me one.");

            int userSub = Convert.ToInt32(Console.ReadLine());
            int userSub2 = Convert.ToInt32(Console.ReadLine());

            //Call the method in the class, passing in the one or two numbers entered.

            int result = DosNumeros.Algebraic(userSub, userSub2);

            Console.WriteLine(result);

            Console.ReadLine();

            //Try various combinations of numbers on the code, including having no second number.

            //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
        }
    }
}
