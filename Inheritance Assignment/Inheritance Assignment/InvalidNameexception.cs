using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    public class InvalidNameexception: Exception
    {
        public InvalidNameexception() { }

        public InvalidNameexception(string name) : base(String.Format("Invalid Name: {0}", name)) { }
    }
}
