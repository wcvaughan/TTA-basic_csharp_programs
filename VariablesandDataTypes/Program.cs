using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesandDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //   // This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudy = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char randomLetter = 'X';
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.234234;

            float secondsLeft = 2.4f;

            short temperatureOnMars = -341;

            string myName = "frank";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(questionMark);
            Console.ReadLine();

            int A = 10;
            int B = 45;
            //Add two numbers and display the output in the console.
            Console.WriteLine(A+B);
            //Subtract two numbers and display the output in the console.
            Console.WriteLine(A+B);
            //Multiply two numbers and display the output in the console.
            Console.WriteLine(A*B);
            //Divide two numbers and display the output in the console.
            Console.WriteLine(A/B);
            Console.WriteLine(A%B);
            Console.ReadLine();

            string quoteOne = "This is the first part of the sentence ";
            string quoteTwo = "and this is the rest of it";
            string fullQuote = quoteOne + quoteTwo;
            Console.WriteLine(fullQuote);
            Console.ReadLine();

        }
    }
}
