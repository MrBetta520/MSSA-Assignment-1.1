using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = ArrayCreation();
            SortArray(a);
        }

        static int[] ArrayCreation()
        {
            Console.WriteLine("Please enter the array size.");
            int size = Int32.Parse(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine($"Please enter {size} integers.");
            for (int i = 0; i < size; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }

            return array;
        }

        static void SortArray(int[] a)
        {
            Console.WriteLine("Which kind of sorting do you want?");
            Console.WriteLine("1. Ascending");
            Console.WriteLine("2. Descending");
            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Ascending(a);
                    Console.ReadLine();
                    break;

                case 2:
                    Descending(a);
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Please press 1 or 2.");
                    Console.ReadLine();
                    break;
            }
        }

        static void Ascending (int[] a)
        {
            int temp = 0;
            for (int i = 0; i <= a.Length; i++)
            {
                for(int j = 0; j < (a.Length-1); j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            ArrayDisplay(a);
        }

        static void Descending (int[] a)
        {
            int temp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = (a.Length - 1); j > 0; j--)
                {
                    if (a[j] > a[j - 1])
                    {
                        temp = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = temp;
                    }
                }
            }
            ArrayDisplay(a);
        }

        static void ArrayDisplay(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
            Console.ReadLine();
        }
    }
}
