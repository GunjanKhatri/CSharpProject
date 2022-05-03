using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Static_assignment
{
    public class Calc
    {
        public int add()
        {
            var n1 = RandomHelper.randint(1, 10);
            var n2 = RandomHelper.randdouble(1, 8);

            return Convert.ToInt32(n1 + n2);
        }
    }
}
