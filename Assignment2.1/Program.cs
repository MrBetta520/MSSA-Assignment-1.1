using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Yang's calculator.");
            Console.WriteLine("Please enter y or Y to continue. Enter any other to quit.");
            char choice = Convert.ToChar(Console.ReadLine());

            while (choice == 'y' || choice == 'Y')
            {
                decisionMake();
                Console.WriteLine("Please enter y or Y to continue. Enter any other to quit.");
                choice = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Thank you for your support. Goodbye!");
            Console.ReadLine();
        }

        static void decisionMake()
        {
            Console.WriteLine("Please choose which calculation you want to make.");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    areaOfCircle();
                    Console.ReadLine();
                    break;

                case 2:
                    areaOfSquare();
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please choose 1, or 2.");
                    Console.ReadLine();
                    break;
            }
        }

        static void areaOfCircle()
        {
            Circle c = new Circle();
            Console.WriteLine("Please enter the redius of the circle.");
            try
            {
                c.redius = Convert.ToDouble(Console.ReadLine());
                c.AreaCalculate();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter a number.");
                Console.WriteLine(ex.StackTrace);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        static void areaOfSquare()
        {
            Square s = new Square();
            Console.WriteLine("Please enter the side of the square.");
            try
            {
                s.lengthOfSide = Convert.ToDouble(Console.ReadLine());
                s.AreaCalculate();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter a number.");
                Console.WriteLine(ex.StackTrace);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
