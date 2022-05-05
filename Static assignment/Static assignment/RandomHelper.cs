using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_assignment
{
    public class RandomHelper
    {
        public static int randint(int num1, int num2)
        {
            Random rnd = new Random();
            int num = rnd.Next(num1,num2+1);
            return num;
        }

        public static double randdouble(int num1, int num2)
        {
            Random rnd = new Random();
            double num = rnd.Next(num1, num2);
            return num;
        }
    }
}
