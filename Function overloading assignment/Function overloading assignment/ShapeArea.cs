using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_overloading_assignment
{
    class ShapeArea
    {
        public void Area(double radius)
        {
            const double pi = 3.14;

            Console.WriteLine(pi * radius * radius);
        }

        public void Area(double tbase, double height)
        {
            Console.WriteLine((tbase * height) / 2);
        }

        public void Area(int length, int breadth)
        {
            Console.WriteLine(length*breadth);
        }
    }
}
