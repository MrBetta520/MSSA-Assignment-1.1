using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] nums = new int[10];

            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                nums[i - 1] = i;
            }

            Console.WriteLine("The first 10 natural number is: ");
            foreach(int num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("  ");
            Console.WriteLine($"The Sum is: {sum}");

            Console.ReadLine();
        }
    }
}
