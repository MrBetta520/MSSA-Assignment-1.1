using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer for the array size.");
            int size = Convert.ToInt32(Console.ReadLine());
            arrayTest(size);

            Console.ReadLine();
        }

        static void arrayTest(int length)
        {
            int[] a1 = new int[length];
            
            for (int i = 0; i < length; i++)
            {
                Console.Write($"element - {i+1}: ");
                a1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The values store into the array are: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(a1[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("The values store into the array in reverse are: ");

            for (int i = length -1; i >= 0; i--)
            {
                Console.Write(a1[i] + " ");
            }
            
        }
    }
}
