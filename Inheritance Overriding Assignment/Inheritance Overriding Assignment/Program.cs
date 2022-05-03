using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overriding_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit apple = new Apple();
            Fruit orange = new Orange();

            apple.name = "Apple";
            apple.taste = "sweet";

            orange.name = "Orange";
            orange.taste = "tangy";

            apple.eat();
            orange.eat();

            Console.ReadKey();
        }
    }
}
