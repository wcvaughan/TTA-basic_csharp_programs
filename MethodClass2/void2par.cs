using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass2
{
    class void2par
    {
        public void Parapow(int a, int b)
        {
            int stored = a + 525000;
            Console.WriteLine(b);

        }
        //Call the method in the class, passing in two numbers.
        int a = 5;

        int b = 500;

        int result = void2par.Parapow(a, b);
        //Call the method in the class, specifying the parameters by name.
        int result2 = void2par.Parapow(a: a, b: b);

    }
}
