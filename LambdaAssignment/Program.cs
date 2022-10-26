using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //In the Main() method, create a list of at least 10 employees.At least two employees should have the first name “Joe”.

            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee()
            {
                fName = "Fannie",
                lName = "Mae",
                Id = 1
            });

            employees.Add(new Employee()
            {
                fName = "Sephiroth",
                lName = "Shinra",
                Id = 2
            });

            employees.Add(new Employee()
            {
                fName = "Cloud",
                lName = "Strife",
                Id = 3
            });

            employees.Add(new Employee()
            {
                fName = "Tifa",
                lName = "Lockhart",
                Id = 4
            });

            employees.Add(new Employee()
            {
                fName = "Barret",
                lName = "Wallace",
                Id = 5
            });

            employees.Add(new Employee()
            {
                fName = "Aerith",
                lName = "Gainsborough",
                Id = 6
            });

            employees.Add(new Employee()
            {
                fName = "Cid",
                lName = "Highwind",
                Id = 7
            });

            employees.Add(new Employee()
            {
                fName = "Joe",
                lName = "Bogus",
                Id = 8
            });

            employees.Add(new Employee()
            {
                fName = "Joe",
                lName = "Smack",
                Id = 9
            });

            employees.Add(new Employee()
            {
                fName = "Glee",
                lName = "McShmee",
                Id = 10
            });

            //Using a foreach loop, create a new list of all employees with the first name “Joe”. 
            //In your comparison statement, remember to reference the property of the object you are checking.


            List<Employee> joeEmployees = new List<Employee>();

            //foreach (Employee employee in employees)
            //{
            //    if (employee.fName == "Joe")
            //    {
            //        joeEmployees.Add(employee);
            //    }
            //}
            //foreach (Employee employee1 in joeEmployees)
            //{
            //    Console.WriteLine(employee1.lName + ", " + employee1.fName);
            //}

            //Perform the same action again, but this time with a lambda expression.

            var joeEmployees1 = employees.FindAll(name => (name.fName == "Joe")).ToList();

            foreach (Employee employee1 in joeEmployees)
            {
                Console.WriteLine(employee1.lName + ", " + employee1.fName);
            }

        }
    }
}
