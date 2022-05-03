using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Enter number1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number2");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Pre-increment
            num2 = ++num1;

            Console.WriteLine("Num1 "+num1);
            Console.WriteLine("Num2 " + num2);

            //post-increment
            Console.WriteLine("Enter number1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number2");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            num2 = num1++;

            Console.WriteLine("Num1 " + num1);
            Console.WriteLine("Num2 " + num2);

            //Swap both numbers
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("Num1 " + num1);
            Console.WriteLine("Num2 " + num2);
            Console.ReadKey();


        }
    }
}
