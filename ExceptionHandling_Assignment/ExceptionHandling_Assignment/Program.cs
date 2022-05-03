using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string sname;
            int[] marks = new int[3];
            try
            {
                Console.WriteLine("Enter student name:");
                sname = Console.ReadLine();
                for(int i=0; i<marks.Length; i++)
                {
                    Console.WriteLine("Enter marks");
                    marks[i] = Convert.ToInt32(Console.ReadLine());
                    if (marks[i] < 0)
                        throw new NegativeNumberException(marks[i]);
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
