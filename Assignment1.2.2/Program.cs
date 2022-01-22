using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number.");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(CompareNums(num1, num2));

            Console.ReadLine();

        }

        static string CompareNums (int num1, int num2)
        {
            string result;

            if (num1 == num2)
            {
                result = num1 + " and " + num2 + " are equal.";
            }
            else if(num1 > num2)
            {
                result = num1 + " is greater than " + num2;
            }
            else
            {
                result = num1 + " is less than " + num2;
            }

            return result;
        }
    }
}
