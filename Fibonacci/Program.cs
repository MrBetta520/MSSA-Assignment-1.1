using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            fibonacci(9);
            Console.ReadLine();
        }
        static void fibonacci (int length)
        {
            int temp = 0;
            int a = 0;
            int b = 1;
            Console.Write(a + " ");
            for (int i = 0; i < length - 1; i++)
            {
                temp = a;
                a = b;
                b = temp + a;
                Console.Write(a + " ");
            }

        }
    }
}
