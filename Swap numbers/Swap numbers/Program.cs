using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Please enter a number1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a number2");
            num2 = Convert.ToInt32(Console.ReadLine());

            num3 = num1;
            num1 = num2;
            num2 = num3;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.ReadKey();
        }
    }
}
