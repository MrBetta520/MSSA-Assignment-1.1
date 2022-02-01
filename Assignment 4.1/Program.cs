using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReturnEvenNumvers());
            Console.ReadLine();
        }

        static string ReturnEvenNumvers ()
        {
            StringBuilder s = new StringBuilder();
            for(int i = 2; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    s.Append(i.ToString() + " ");
                }
            }

            return s.ToString();
        }
    }
}
