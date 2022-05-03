using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_Assignment
{
    class EmployeeDAL
    {
        List<Employee> employees = new List<Employee>();
        public bool AddEmployee(Employee e)
        {
            employees.Add(e);
            return true;
        }

        public bool DeleteEmployee(int id)
        {
            employees.Remove(employees[id]);
            return true;
        }

        public string SearchEmployee(int id)
        {
            var e= employees.FirstOrDefault(y => y.EmployeeId == id)?.EmployeeName;
            return e;
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }
    }
}
