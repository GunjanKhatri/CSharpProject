using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    public class PermanentEmployee :Person, IPayable
    {
        public double HRA { get; set; }
        public double DA { get; set; }
        public double Tax { get; set; }
        public double NetPay { get; set; }
        public double TotalPay { get; set; }

        public PermanentEmployee(double HRA, double DA, double Tax, double NetPay, string FirstName, string LastName, string EmailAddress, DateTime DateOfBirth) : base(FirstName, LastName, EmailAddress, DateOfBirth)
        {
            this.HRA = HRA;
            this.DA = DA;
            this.Tax = Tax;
            this.NetPay = NetPay;
            
        }

        public void CalculatePay()
        {
            TotalPay = NetPay + HRA + DA - Tax;
            Console.WriteLine($"Total Pay: {TotalPay}");
        }
    }
}
