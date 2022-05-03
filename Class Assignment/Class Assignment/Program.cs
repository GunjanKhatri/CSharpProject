using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Ford", "2022", "Fiaz", "Germany");
            c.DisplayCar();

            Employee emp = new Employee("Gunjan", 1200000);
            emp.Display();
            Console.ReadKey();
        }
    }
}
