using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //number of elements
            string[] str = new string[] { "Hi", "Hello", "Hi", "World", "Hi" };
            int count = 0;
            foreach(var s in str)
            {
                count++;
            }

            Console.WriteLine("Total elements: "+count);

            //reverse an array
            int[] num = new int[10];
            int[] numReverse = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                
                    Console.WriteLine("Enter a number");
                    num[i] = Convert.ToInt32(Console.ReadLine());
                                 
             }
            for (int i = 0; i < num.Length; i++)
            {
                    numReverse[i] = num[num.Length-i -1];
               
            }
            foreach (var no in numReverse)
            {
                Console.WriteLine(no);
            }

            //sum of elements in array
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            Console.WriteLine(sum);

            Console.ReadKey();
            
        }
    }
}
