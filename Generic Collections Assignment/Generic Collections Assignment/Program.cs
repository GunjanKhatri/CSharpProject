using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1,"Gunjan", 23450);
            Employee emp1 = new Employee(2, "Mana", 23450);
            Employee emp2 = new Employee(3, "Jitu", 23450);

            EmployeeDAL empCall = new EmployeeDAL();
            bool result= empCall.AddEmployee(emp);
            result = empCall.AddEmployee(emp1);
            result = empCall.AddEmployee(emp2);

            result= empCall.DeleteEmployee(2);
            Console.WriteLine(empCall.SearchEmployee(1));
            var employees= empCall.GetAllEmployees();

            foreach(var employee in employees)
            {
                Console.WriteLine(employee.EmployeeName);
            }

            //Alpanumeric list
            string s = "Hello3412World";
            List<char> AlphaList = new List<char>();
            List<char> DigiList = new List<char>();

            foreach (var c in s)
            {
                if ((Convert.ToInt32(c) >= 65 && Convert.ToInt32(c) <= 90) ||
                    (Convert.ToInt32(c) >= 97 && Convert.ToInt32(c) <= 122))
                {
                    AlphaList.Add(c);
                }
                else if (Convert.ToInt32(c) >= 48 && Convert.ToInt32(c) <= 57)
                {
                    DigiList.Add(c);
                }
            }
            AlphaList.Sort();
            DigiList.Sort();
            foreach (var c in AlphaList)
            {
                Console.WriteLine(c);
            }
            foreach(var c in DigiList)
            {
                Console.WriteLine(c);
            }
            
                    Console.ReadKey();
        }
    }
}
