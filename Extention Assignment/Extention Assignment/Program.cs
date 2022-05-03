using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeViewModel e = new EmployeeViewModel();
            e.FirstName = "Gunjan";
            e.LastName = "Advani";
            e.Address1 = "abc";
            e.Address2 = "warasia";
            e.City = "Vadodara";

            var d = e.ToDataModel();

            Console.WriteLine(d.FullName);
            Console.WriteLine(d.FullAddress);

            Console.ReadKey();
        }
    }
}
