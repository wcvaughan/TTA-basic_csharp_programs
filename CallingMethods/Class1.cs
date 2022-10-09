using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class mathStuff
    {
        int n;
        public static int AddTwoNumbers(int n, int userSubmit)
        {
            return = n + userSubmit;
        }

        public static int MultiplyTwoNumbers(int n, int userSubmit)
        {
            return n * userSubmit;
        }

        public static int FanFav(int n, int userSubmit)
        {
            return (n / userSubmit) * n + userSubmit * n;
        }
    }
}
