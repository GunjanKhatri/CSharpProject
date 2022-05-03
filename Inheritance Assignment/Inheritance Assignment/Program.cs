using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(2000, "Gunjan", "Advani", "test@test.com", Convert.ToDateTime("07/11/1990"));
            Console.WriteLine(emp.IsAdult);
            Console.WriteLine(emp.IsBirthday);
            Console.WriteLine(emp.SunSign);
            Console.WriteLine(emp.ScreenName);

            HourlyEmployee tempEmp = new HourlyEmployee(7, 1000, "Gunjan", "Advani", "test@test.com", Convert.ToDateTime("07/11/1990"));
            PermanentEmployee perEmp = new PermanentEmployee(6000,5000,1000,7000,"Gunjan", "Advani", "test@test.com", Convert.ToDateTime("07/11/1990"));

            tempEmp.CalculatePay();
            perEmp.CalculatePay();

            Person p = new Person("test@test.com", Convert.ToDateTime("07/11/1990"));
            Console.WriteLine("Enter first name");
            p.FirstName = Console.ReadLine();
            ValidateName(p.FirstName);
            Console.WriteLine("Enter last name");
            p.LastName = Console.ReadLine();
            ValidateName(p.LastName);

            Console.ReadKey();
        }

        private static void ValidateName(string std)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(std))
                throw new InvalidNameexception(std);
            else if(std == string.Empty || std==null)
                throw new InvalidNameexception();
        }
    }
}
