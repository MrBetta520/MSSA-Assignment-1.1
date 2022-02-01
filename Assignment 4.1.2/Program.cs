using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Leap Year check!");
            Console.WriteLine("If you want to check a year whether leap or not, please enter y or Y. Any key to quit.");
            Console.WriteLine();
            try
            {
                char choice = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

                while (choice == 'y' || choice == 'Y')
                {
                    Console.WriteLine("Please enter a year.");
                    Console.WriteLine();
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(LeapYear(year) ? $"{year} is leap year!" : $"{year} is not leap year!");
                    Console.ResetColor();

                    Console.WriteLine();

                    Console.WriteLine("Do you want to check another year? If yes, press y or Y. Otherwise, any key to quit.");
                    Console.WriteLine();
                    choice = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.StackTrace);
                Console.ResetColor();
            }
            finally
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Thank you for using this project! GoodBye!");
            }

            Console.ReadLine();
        }

        static bool LeapYear(int year)
        {
            bool result;
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0 && year % 100 == 0))
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
