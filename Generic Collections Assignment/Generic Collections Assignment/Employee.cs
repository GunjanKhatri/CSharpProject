using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_Assignment
{
    class Employee
    {
        public string EmployeeName { get; set; }

        public int EmployeeId { get; set; }
        public double Salary { get; set; }

        public Employee(int EmployeeId , string EmployeeName, double Salary)
        {
            this.EmployeeId = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.Salary = Salary;
        }
    }
}
