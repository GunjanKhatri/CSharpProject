using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_overloading_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeArea rect, triangle, circle;
            rect=new ShapeArea();
            triangle = new ShapeArea();
            circle = new ShapeArea();

            rect.Area(5, 4);
            triangle.Area(2, 2);
            circle.Area(2);

            Console.ReadKey();
        }
    }
}
