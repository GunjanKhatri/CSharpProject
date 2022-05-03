using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    public class Employee
    {
        public string employeeName { get; set; }
        public decimal basicSalary { get; set; }

        public decimal HRA { get; set; }
        public decimal DA { get; set; }
        public decimal tax { get; set; }
        public decimal grossPay { get; set; }
        public decimal netSalary { get; set; }

        public Employee(string empName, decimal basicSal)
        {
            employeeName = empName;
            basicSalary = basicSal;
        }

        public void CalculateNetPay()
        {
            HRA = Convert.ToDecimal(0.15) * basicSalary;
            DA = Convert.ToDecimal(0.10) * basicSalary;
            grossPay = basicSalary + HRA + DA;
            tax = Convert.ToDecimal(0.08) * grossPay;
            netSalary = grossPay - tax;
        }

        public void Display()
        {
            CalculateNetPay();
            Console.WriteLine(HRA);
            Console.WriteLine(DA);
            Console.WriteLine(grossPay);
            Console.WriteLine(tax);
            Console.WriteLine(netSalary);
            
        }
    }
}
