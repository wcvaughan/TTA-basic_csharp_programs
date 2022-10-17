using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create an abstract class called Person with two properties: string firstName and string lastName.

            //Give it the method SayName().

            //Create another class called Employee and have it inherit from the Person class.

            //Implement the SayName() method inside of the Employee class.

            //Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”. Call the SayName() method on the object.
            Employee employee = new Employee();
            
            employee.firstName = "Sample";
            
            employee.lastName = "Student";

            employee.SayName();

            Console.ReadLine();

            //Create an interface called IQuittable and have it define a void method called Quit().

            //Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.

            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            //Hint: an object can be of an interface type if it implements that specific interface.
            IQuittable quittable = new Employee();
            quittable.Quit(employee);
            Console.ReadLine();

            //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
        }
    }
}
