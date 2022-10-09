using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MathOV
    {

        //Create a class. In that class, create a method that will take in an integer,
        //create a math operation for this integer(addition, subtraction, etc.), then return the answer as an integer.

        public int Moth(int x)
        {
            return (x + 42);
        }

        //Add a second method to the class with the same name that will take in a decimal,
        //create a different math operation for it, then return the answer as an integer.
        public double Moth(double y)
        {
            return Convert.ToInt32(42 - y);
        }

        //Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible,
        //do a different math operation to it, then return the answer as an integer.

        public string Moth(string lmno)
        {
            int l = int.Parse(lmno);
            return l * 42;
        }
    }
}
