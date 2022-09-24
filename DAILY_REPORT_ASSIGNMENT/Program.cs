using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAILY_REPORT_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy"); //Prints to console "The Tech Academy"
            Console.WriteLine("Student Daily Report"); //Prints to console "Student Daily Report"
            Console.WriteLine("What is your name?"); //Prints to console the question "What is your name?"
            string yourName = Console.ReadLine(); //Stores user response to previous question in string variable "yourName"
            Console.WriteLine("What course are you on?"); //Prints to console the question "What course are you on?"
            string yourCurrentCourse = Console.ReadLine(); //Stores user response to the previous question in string variable "yourCurrentCourse"
            Console.WriteLine("What page number?"); //Prints to console the question "What page number?"
            int yourPageNumber = Convert.ToInt32(Console.ReadLine()); //Converts user response to the previous question into integer and stores in integer variable yourPageNumber
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\". "); //Prints to console the question "Do you need help with anything? Please answer "true" or "false"."
            bool helpMe = Convert.ToBoolean(Console.ReadLine()); //Converts user response to the previous question into a boolean helpMe
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics."); //Prints to console the question "Were there any positive experiences you'd like to share? Please give specifics."
            string positiveFeedback = Console.ReadLine(); //Stores user response to the previous question into string positiveFeedback
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific."); //Prints to console the question "Is there any other feedback you'd like to provide? Please be specific."
            string otherFeedback = Console.ReadLine(); //Stores user response to the previous question into string otherFeedback
            Console.WriteLine("How many hours did your study today?"); //Prints to console the question "How many hours did your study today?"
            int hoursStudied = Convert.ToInt32(Console.ReadLine()); //Converts user response to the previous question into integer and stores in integer variable hoursStudied
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!"); //Prints to console "Thank you for your answers. An instructor will respond to this shortly. Have a great day!"
            Console.Read();
        }
    }
}
