using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice = 'y';

            while (choice == 'y' || choice == 'Y')
            {
                CallMenu();
                Console.WriteLine("If you want to continue to perform calculation, press y or Y. If you want to quit, press n or N.");
      
                choice = Convert.ToChar(Console.ReadLine());
            }
        }

        static void CallMenu()
        {
            Console.WriteLine("Which operation do you want to perform today?");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Multiplication");
            Console.WriteLine("3. Subtraction");
            Console.WriteLine("4. Division");
            Console.WriteLine("Enter your choice");
            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Addition();
                    Console.ReadLine();
                    break;

                case 2:
                    Multiplication();
                    Console.ReadLine();
                    break;

                case 3:
                    Subtraction();
                    Console.ReadLine();
                    break;

                case 4:
                    Division();
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Please enter number 1, 2, 3 and 4.");
                    Console.ReadLine();
                    break;
            }
        }

        static void Addition ()
        {
            int num1, num2, result;

            Console.WriteLine("Please enter a number.");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number.");
            num2 = Int32.Parse(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is {result}.");
        }
        static void Multiplication()
        {
            int num1, num2, result;

            Console.WriteLine("Please enter a number.");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number.");
            num2 = Int32.Parse(Console.ReadLine());
            result = num1 * num2;
            Console.WriteLine($"The conduct of {num1} and {num2} is {result}.");
        }
        static void Subtraction()
        {
            int num1, num2, result;

            Console.WriteLine("Please enter a number.");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number.");
            num2 = Int32.Parse(Console.ReadLine());
            result = num1 - num2;
            Console.WriteLine($"The difference of {num1} and {num2} is {result}.");
        }
        static void Division()
        {
            int num1, num2, quotient, remainder;

            Console.WriteLine("Please enter a number.");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number.");
            num2 = Int32.Parse(Console.ReadLine());
            quotient = num1 / num2;
            remainder = num1 % num2;
            Console.WriteLine($"The quotient of {num1} and {num2} is {quotient}, the remainder of {num1} and {num2} is {remainder}.");
        }
    }
}
