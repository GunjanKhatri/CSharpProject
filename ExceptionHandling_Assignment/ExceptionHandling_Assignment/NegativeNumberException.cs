using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_Assignment
{
    public class NegativeNumberException:Exception
    {
        public NegativeNumberException() { }

        public NegativeNumberException(int num): base(String.Format("The number {0} is negative", num))
        {

        }
    }
}
