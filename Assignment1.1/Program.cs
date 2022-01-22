using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            decimal age;
            string firstName;
            string address;

            Console.WriteLine("Please enter your name.");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your age in whole number.");
            age = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter your street address.");
            address = Console.ReadLine();

            Console.WriteLine("Your information: ");
            Console.WriteLine($"Your name is {firstName}, your age is {age}, your address is {address}.");
            Console.ReadLine();

        }
    }
}
