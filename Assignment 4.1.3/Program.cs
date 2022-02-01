using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to reverse a string?");
            Console.WriteLine("If yes, press y or Y. Otherwise, any key to quit.");


            try
            {
                char choice = Convert.ToChar(Console.ReadLine());

                while (choice == 'y' || choice == 'Y')
                {
                    Console.WriteLine("Please enter a string.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string s = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(reverseString(s));
                    Console.ResetColor();

                    Console.WriteLine("Do you want to reverse another string? If yes, press y or Y, otherwise, any key to quit.");
                    choice = Convert.ToChar(Console.ReadLine());
                }
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.StackTrace);
                Console.ResetColor();
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Thank you for using this app, Goodbye!");
            }

            Console.ReadLine();
        }

        static string reverseString(string s)
        {
            StringBuilder sb = new StringBuilder();

            for(int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }

    }
}
