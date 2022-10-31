using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    public class NumException : Exception
    {
        public NumException()
            : base() { }
        public NumException(string message)
            : base(message) { }
    }
}
