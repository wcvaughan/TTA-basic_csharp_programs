using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Program
    {
        public void Main(string[] args)
        {
            //Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
            //The methods should do some math operation on the received parameter.Put this class in a separate.cs file in the application.


            //In the Main() program, ask the user what number they want to do the math operations on.
            
            Console.WriteLine("We've got some math stuff, if you give me a number we can do stuff to it. So what about it? Give us a number!");
            
            int userSubmit = Convert.ToInt32(Console.ReadLine());
            
            //Call each method in turn, passing the user input to the method.Display the returned integer to the screen.
            
            _ = new mathStuff();
            
            Console.WriteLine(mathStuff.AddTwoNumbers(mathStuff n, mathStuff userSubmit));
            
            Console.WriteLine(mathStuff.MultiplyTwoNumbers(mathStuff n, mathStuff userSubmit));
            
            Console.WriteLine(mathStuff.FanFav(mathStuff n, mathStuff userSubmit));
            
            //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
        }
    }
}
