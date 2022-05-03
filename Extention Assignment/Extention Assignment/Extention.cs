using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_Assignment
{
    public static class Extention
    {
        public static Employee ToDataModel(this EmployeeViewModel employeeViewModel)
        {
            Employee employee = new Employee();
            employee.FullName = employeeViewModel.FirstName + " " + employeeViewModel.LastName;
            employee.FullAddress = employeeViewModel.Address1 + " " + employeeViewModel.Address2 + " " + employeeViewModel.City;

            return employee;
        }
    }
}
