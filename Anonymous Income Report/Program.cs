using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            //The program must start by printing “Anonymous Income Comparison Program” to the screen.
            Console.WriteLine("Anonymous Income Comparison Program");
            //It must then print “Person 1” to the screen and get the following details from user input:
            //Hourly Rate
            //Hours worked per week
            Console.WriteLine("Please, Person 1, tell me your hourly rate.");
            decimal personOneHourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("And now, Person 1, how many horus do you work in a week?");
            int personOneHoursWorked = Convert.ToInt32(Console.ReadLine());
            //It must then print “Person 2” to the screen and then get the following details from user input:
            //Hourly rate
            //Hours worked per week
            Console.WriteLine("Please, Person 2, tell me your hourly rate.");
            decimal personTwoHourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("And now, Person 2, how many horus do you work in a week?");
            int personTwoHoursWorked = Convert.ToInt32(Console.ReadLine());
            //It must then print to the screen “Annual salary of Person 1:” and display the exact salary below it.
            Console.WriteLine("Person 1's annual salary is: " + personOneHourlyRate * personOneHoursWorked * 52);
            decimal personOneAnnualSalary = personOneHourlyRate * personOneHoursWorked * 52;
            //It must then print to the screen “Annual salary of Person 2:” and display the exact salary below it.
            Console.WriteLine("Person 2's annual salary is: " + personTwoHourlyRate * personTwoHoursWorked * 52);
            decimal personTwoAnnualSalary = personTwoHourlyRate * personTwoHoursWorked * 52;
            //It must then print to the screen “Does Person 1 make more money than Person 2 ?” and write the true or false value of this statement below it.
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool makesMore = personTwoAnnualSalary < personOneAnnualSalary;
            Console.WriteLine(makesMore);
            Console.ReadLine();
            //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
        }
    }
}
