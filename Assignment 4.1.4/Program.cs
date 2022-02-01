using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            string s = Console.ReadLine();

            Console.WriteLine();
            Console.Write($"\"{s}\" ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"contains {CountSpaceNums(s)} spaces.");
            Console.ReadLine();
        }

        //static int CountSpaceNums(string s)
        //{
        //    int count = 0;

        //    char[] charArray = s.ToCharArray();

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if(s[i] == ' ')
        //        {
        //            count++;
        //        }
        //    }

        //    return count;
        //}
        static int CountSpaceNums(string s)
        {
            int count = 0;

            string[] sa = s.Split();

            count = sa.Length - 1;

            return count;
        }
    }
}
