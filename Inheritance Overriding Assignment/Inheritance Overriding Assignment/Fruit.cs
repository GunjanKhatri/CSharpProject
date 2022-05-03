using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overriding_Assignment
{
    class Fruit
    {
        public string name;
        public int size;
        public string taste;

        public virtual void eat()
        {
            Console.WriteLine(name);
            Console.WriteLine(taste);
        }
    }
}
