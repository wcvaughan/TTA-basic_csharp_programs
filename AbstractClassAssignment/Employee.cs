using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Create another class called Employee and have it inherit from the Person class.

    public class Employee : Person, IQuittable
    {
        //Implement the SayName() method inside of the Employee class.
        public override void SayName()
        {
            base.SayName();
        }
        //Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”. Call the SayName() method on the object.

        //Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
        public void Quit(Employee employee)
        {
            Console.WriteLine(employee.firstName + " has quit");
        }
    }
}
