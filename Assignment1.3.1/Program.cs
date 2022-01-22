using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice = 'y';

            while(choice == 'y' || choice == 'Y')
            {
                AreaCalculation();
                Console.WriteLine("If you want to continue calculation, press y or Y. Press any other button to quit.");

                choice = Convert.ToChar(Console.ReadLine());
            }
        }

        static void AreaCalculation()
        {
            Console.WriteLine("Please select one operation you want to do.");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Rectangle");
            Console.WriteLine("Enter your choice");

            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Triangle();
                    Console.ReadLine();
                    break;
                case 2:
                    Square();
                    Console.ReadLine();
                    break;
                case 3:
                    Rectangle();
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please enter 1, 2 or 3.");
                    Console.ReadLine();
                    break;                
            }
           
            
        }
        static void Triangle()
        {
            double num1, num2, result;

            Console.WriteLine("Please enter the length of triangle.");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the height of triangle.");
            num2 = Convert.ToDouble(Console.ReadLine());

            result = 0.5 * num1 * num2;
            Console.WriteLine($"The area of this triangle is: {result}.");
        }

        static void Square()
        {
            double num, result;

            Console.WriteLine("Please enter the length of the square.");
            num = Convert.ToDouble(Console.ReadLine());

            result = Math.Pow(num, 2);
            Console.WriteLine($"The area of this square is: {result}.");
        }

        static void Rectangle()
        {
            double length, width, result;

            Console.WriteLine("Please enter the length of the rectangle.");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the width of the rectangle.");
            width = Convert.ToDouble(Console.ReadLine());

            result = length * width;
            Console.WriteLine($"The area of this rectangle is: {result}.");
        }
    }
}
