using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    public class Employee : Person
    {
        
        public Employee(double salary, string FirstName, string LastName, string EmailAddress, DateTime DateOfBirth) : base(FirstName,LastName,EmailAddress,DateOfBirth)
        {
            
            Salary = salary;
        }

        public double Salary { get; set; }
    }
}
