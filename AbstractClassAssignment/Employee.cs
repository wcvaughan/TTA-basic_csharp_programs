using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Create another class called Employee and have it inherit from the Person class.
    //Create an Employee class with Id, FirstName and LastName properties. 

    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        //In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.
        //Remember that comparison operators must be overloaded in pairs.

        public static Employee operator ==(Employee employee, Employee employee1)
        {
            bool isSame = employee.Id == employee1.Id;
            Console.WriteLine("Duplicate found");
            return employee;
        }
        public static Employee operator!= (Employee employee, Employee employee1)
        {
            bool isSame = employee.Id != employee1.Id;
            Console.WriteLine("Not a duplicate");
            return employee;
        }

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
