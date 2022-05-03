using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan f = new Fan();
            f.SPEED = 2;
            f.Radius = 6.7;
            f.Color = "White";
            f.ON = true;

            f.ToString();
            Console.ReadKey();
        }
    }
}
