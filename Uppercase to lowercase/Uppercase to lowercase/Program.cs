using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppercase_to_lowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            char test = 'Z';

            int ascii = test + 32;

            Console.WriteLine(Convert.ToChar(ascii));
            Console.ReadKey();
        }
    }
}
