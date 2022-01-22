using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Compare Points.");
            Console.WriteLine("If you want to continue, press y or Y. Press any letter to quit.");
            try
            {
                char choice = Convert.ToChar(Console.ReadLine());

                while (choice == 'y' || choice == 'Y')
                {
                    comparePoints();

                    Console.WriteLine("Do you still want continue? Please press y or Y. Press any letter to quit.");

                    choice = Convert.ToChar(Console.ReadLine());
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter number only!\n");
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Thank you for using this application! Goodbye!");
                Console.ReadLine();
            }
        }

        // This function is used to create x coordinate of point 1. 
        static double createPoint1()
        {
            Point point1 = new Point();
            Console.WriteLine("Please enter a X coordinate number for Point 1. ");
            point1.X = Convert.ToDouble(Console.ReadLine());

            return point1.X;
        }

        // This function is used to create x coordinate of point 2.
        static double createPoint2()
        {
            Point point2 = new Point();
            Console.WriteLine("Please enter a X coordinate number for Point 1. ");
            point2.X = Convert.ToDouble(Console.ReadLine());

            return point2.X;
        }

        // This function is used to compare two points.
        static void comparePoints()
        {
            double point1 = createPoint1();
            double point2 = createPoint2();

            if (point1 > point2)
            {
                Console.WriteLine("Point 1 is on the right side of Point 2.");
            }
            else if (point1 < point2)
            {
                Console.WriteLine("Point 1 is on the left side Point 2.");
            }
            else
            {
                Console.WriteLine("Point 1 and Point 2 are on the same x axis.");
            }

            Console.ReadLine();
        }
    }
}
