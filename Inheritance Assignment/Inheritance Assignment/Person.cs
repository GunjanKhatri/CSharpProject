using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        private string EmailAddress;
        private DateTime DateOfBirth;
        public bool IsAdult { get { return ((DateTime.Now.Subtract(DateOfBirth).Days) / 365) >= 18 ? true : false; } }
        public string SunSign { get {
                if((DateOfBirth.Month>= 3 && DateOfBirth.Month <= 4))
                {
                    return "Aries";
                }
                return "Gemini";
            } }
        public bool IsBirthday { get {
                return DateTime.Now == DateOfBirth ? true : false;  
            } }
        public string ScreenName { get { return FirstName + DateOfBirth.Month + DateOfBirth.Day; } }

        public Person(string FirstName, string LastName, string EmailAddress, DateTime DateOfBirth)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
            this.DateOfBirth = DateOfBirth;
        }

        public Person(string EmailAddress, DateTime DateOfBirth)
        {
            this.EmailAddress = EmailAddress;
            this.DateOfBirth = DateOfBirth;
        }
    }
}
