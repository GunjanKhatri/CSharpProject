using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_concepts
{
    class Student
    {
        public string name;
        public int id;
        public int[] subject =new int[6];
        float percentage;

        public void getInput()
        {
            Console.WriteLine("Enter Student id");
            id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student name");
            name = (Console.ReadLine());

            for(int i=0; i < subject.Length; i++)
            {
                Console.WriteLine("Enter Student subject marks");
                subject[i] = Convert.ToInt32(Console.ReadLine());
            }
           
        }

        public void calculatePercentage()
        {
            int sum = 0;
            foreach(var mark in subject)
            {
                sum += mark;
            }
            percentage = (sum / subject.Length) ;
            Console.WriteLine("Percentage is :" + percentage);
            Console.ReadKey();
        }
    }
}
