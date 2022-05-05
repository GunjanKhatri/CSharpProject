using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Statements_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //palindrome
            string reverse = String.Empty;
            string str1;

            Console.WriteLine("Enter string");
            str1 = (Console.ReadLine());

            for (int i = str1.Length - 1; i >= 0; i--)
            {
                reverse += str1[i];
            }

            if (str1 == reverse)
            {
                Console.WriteLine("The string is palindrome");
            }
            else
            {
                Console.WriteLine("The string is not palindrome");
            }

            Console.WriteLine();

            //char is alphabet or digit
            char c;
            
            Console.WriteLine("Enter a char");
            c = Convert.ToChar(Console.ReadLine());

            
                if ((Convert.ToInt32(c) >= 65 && Convert.ToInt32(c)<=90) ||
                    (Convert.ToInt32(c) >= 97 && Convert.ToInt32(c) <= 122))
                {
                Console.WriteLine("The char is alphabet");
                }
                else if (Convert.ToInt32(c) >= 48 && Convert.ToInt32(c) <= 57)
                {
                Console.WriteLine("The char is digit");
                }
                        
            Console.WriteLine();

            //find no of occurances
            int num1, num2;
            int count = 0;
            Console.WriteLine("Enter number");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter a number you want to find");
            num2 = Convert.ToInt32(Console.ReadLine());

            while (num1 > 0)
            {
                if (num1 % 10 == num2)
                {
                    count++;
                }
                num1 = num1 / 10;
            }
            Console.WriteLine(num2 +" occurs " +count+ " times");

            //Given a positive integer N and a digit D. The task is to find out the place value of a digit D in the given number N. 
            int D = 5;
            int N = 85932;
            int total = 1, rem = 0;

            while (true) {
                rem = N % 10;
                N = N / 10;
                if (rem == D)
                {
                    //value = total * rem;
                    break;
                }
                total = total * 10;
            }

            if(total==1)
            Console.WriteLine("Digit is in units place");
            else if(total ==10)
                Console.WriteLine("Digit is in tens place");
            else if (total == 100)
                Console.WriteLine("Digit is in hundreds place");
            else if (total == 1000)
                Console.WriteLine("Digit is in thousands place");
            else if (total == 10000)
                Console.WriteLine("Digit is in ten thousands place");

            Console.ReadKey();
        }
    }
}
