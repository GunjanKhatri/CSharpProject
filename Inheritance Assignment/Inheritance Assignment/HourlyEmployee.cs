using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    public class HourlyEmployee: Person, IPayable
    {
        public double HoursWorked { get; set; }
        public double PayPerHour { get; set; }

        public HourlyEmployee(double hoursWorked,double payPerHour,string FirstName, string LastName, string EmailAddress, DateTime DateOfBirth) : base(FirstName, LastName, EmailAddress, DateOfBirth)
        {
            HoursWorked = hoursWorked;
            PayPerHour = payPerHour;
        }

        public void CalculatePay()
        {
            double TotalPay = 0;
            TotalPay = HoursWorked * PayPerHour;
            Console.WriteLine("Total Salary:" + TotalPay);
        }
    }
}
