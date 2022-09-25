using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to _____ Car inn-sewer-ants-poly-sea Company \nWe'll be asking a few questions to find out if you qualify");
            //What is your age ?
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            //Have you ever had a DUI?
            Console.WriteLine("Have you ever had a DUI? Please answer with true or false only, otherwise this whole thing will break. Then you'll never get your car inn-sewer-ants");
            bool hadDUI = bool.Parse(Console.ReadLine());
            //How many speeding tickets do you have?
            Console.WriteLine("How many speeding tickets have you had?");
            int userSpeedDemon = Convert.ToInt32(Console.ReadLine());
            //Applicants must be over 15 years old.
            bool isOldEnough = userAge > 15;
            //Applicants must not have any DUI’s.
            bool noDUI =  hadDUI == false;
            //Applicants must not have more than 3 speeding tickets.
            bool noSpeedDemon = userSpeedDemon < 3;
            //Is the applicant qualified?
            Console.WriteLine("Are you qualified?");
            Console.WriteLine(isOldEnough && noDUI && noSpeedDemon);
            Console.ReadLine();
        }
    }
}
