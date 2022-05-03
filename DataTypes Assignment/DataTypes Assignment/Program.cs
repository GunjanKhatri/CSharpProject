using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Area of Square
            int side;
            float area;

            Console.WriteLine("Enter the side of square");
            side= Convert.ToInt32(Console.ReadLine());

            area = side * side;

            Console.WriteLine("Area of square is:" + area);
            Console.WriteLine();

            //find number of digits and alphabets in a string
            string test = "My age is 26";
            int alpha = 0;
            int num = 0;

            for(int i=0;i<test.Length; i++)
            {
                if((Convert.ToInt32(test[i])>=65 && Convert.ToInt32(test[i])<=90) || 
                    (Convert.ToInt32(test[i])>=97 && Convert.ToInt32(test[i]) <= 122))
                {
                    alpha++;
                }
                else if(Convert.ToInt32(test[i])>=48 && Convert.ToInt32(test[i]) <= 57)
                {
                    num++;
                }
            }

            Console.WriteLine("Total alphabet count is:" + alpha);
            Console.WriteLine("Total digit count is:" + num);
            Console.WriteLine();

            //Increment each character in a string by 1
            string str = "ABCD123";
            string temp =String.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                temp += Convert.ToChar(Convert.ToInt32(str[i] +1));
            }

            Console.WriteLine("New string is :" + temp);
            Console.WriteLine();

            //UpperCase to Lowercase or vice versa
            string toggle = String.Empty;
            string str1 = "HELLO world";

            for (int i = 0; i < str1.Length; i++)
            {
                if ((Convert.ToInt32(str1[i]) >= 65 && Convert.ToInt32(str1[i]) <= 90))
                {
                    toggle += Convert.ToChar(Convert.ToInt32(str1[i]) + 32);
                }
                else if (Convert.ToInt32(str1[i]) >= 97 && Convert.ToInt32(str1[i]) <= 122)
                {
                    toggle += Convert.ToChar(Convert.ToInt32(str1[i]) - 32);
                }
            }
            Console.WriteLine("Toggled string is:" + toggle);
            Console.WriteLine();

            //Reverse the string
            string reverse = String.Empty;

            Console.WriteLine("Enter string");
            str1 = (Console.ReadLine());

            for(int i=str1.Length-1; i >=0; i--)
            {
                reverse += str1[i];
            }

            Console.WriteLine("The reverse of the string is:" + reverse);

            //extract the part of string from 2nd position till end
            temp = String.Empty;
            for (int i = 1; i <str1.Length; i++)
            {
                temp += str1[i];
            }
            Console.WriteLine("The extract part of string from 2nd position till end " + temp);
            Console.WriteLine();

            //replace any given char with $
            char c;
            temp = String.Empty;

            Console.WriteLine("Enter a char you want to replace");
            c = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < str1.Length; i++)
            {
                if(str1[i] == c)
                {
                    temp += '$';
                }
                else
                {
                    temp += str1[i];
                }
            }
            Console.WriteLine("The new string is:" + temp);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
