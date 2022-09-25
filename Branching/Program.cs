using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            //The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //The user must then be prompted for the package weight.
            Console.WriteLine("How much does your package weigh? Please use the conveniently located scale at your own home.");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            //If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express.Have a good day.” At this point the program would end.
            string weightResult = packageWeight > 50 ? "Package too heavy to be shipped via Package Express.Have a good day." : "Wonderful! Continue";
            Console.WriteLine(weightResult);
            //The user must then be prompted for the package width.
            Console.WriteLine("What is the width of your package?");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            //Then the package height.
            Console.WriteLine("Now your package height.");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            //Then the package length.
            Console.WriteLine("Now your package length.");
            int packageLength = Convert.ToInt32(Console.ReadLine());
            //If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
            string dimensionsResult = (packageWidth + packageHeight + packageLength) > 50 ? "Package too big to be shipped via Package Express." : "We are THRILLED to ship your package";
            //Next, multiply the three dimensions(height, width, &length) together, and multiply the product by the weight.Finally, divide the outcome by 100.
            int finalOutcome = ((packageWidth * packageHeight * packageLength) * packageWeight) / 100;
            //The result of that calculation is the quote.

            //Display the quote to the user as a dollar amount.
            Console.WriteLine("Your final quote is $" + finalOutcome);
            Console.ReadLine();
        }
    }
}
