using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Assignment
{
    public delegate void MyDelegate(List<Employee> employees);
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { empId = 1, name = "GUNJAN" });
            employees.Add(new Employee() { empId = 2, name = "JITU" });

            MyDelegate del = EmployeeSave;
            del(employees);

            del = SendEmail;
            del(employees);

            Console.ReadKey();
        }

        static void EmployeeSave(List<Employee> employees)
        {
            foreach(var emp in employees)
            {
                Console.WriteLine(emp.name);
            }

            Console.WriteLine("Employees are saved");

        }

        static void SendEmail(List<Employee> employees)
        {

            Console.WriteLine("Mail sent");
        }
    }
}
   