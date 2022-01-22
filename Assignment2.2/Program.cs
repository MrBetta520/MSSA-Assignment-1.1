using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment2._2._1
{
    class Program
    {
        static string fileName;
        static string path = "C:\\Files\\";
        static void Main(string[] args)
        {
            ColorfulAnimation();
            Console.WriteLine("\nWelcome to this program.");
            
            Console.WriteLine("\nPress y if you want to enter information.");
            char choice = Convert.ToChar(Console.ReadLine());

            while(choice == 'y' || choice == 'Y')
            {
                try
                {
                    Console.WriteLine("\nPlease enter a file name.");
                    fileName = Console.ReadLine() + ".txt";
                    path += fileName;
                    string info = EnterInformation();
                    AppendLines(path, info);
                    ReadFromFile(path);
                    Console.WriteLine("Created at " + DateTime.Now);

                    Console.WriteLine("\nIf you want enter more infomation, press Y or y. Press any other to quit.");
                    choice = Convert.ToChar(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("" + ex.Message + " " + ex.Source + " " + DateTime.Now);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
 
            Console.ReadLine();
        }

        static string EnterInformation()
        {
            
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();
                
            Console.WriteLine("Please enter your age.");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your street.");
            string street = Console.ReadLine();

            Console.WriteLine("Please enter your city.");
            string city = Console.ReadLine();

            Console.WriteLine("Please enter your state.");
            string state = Console.ReadLine();

            Console.WriteLine("Please enter your zip code.");
            int zipCode = Convert.ToInt32(Console.ReadLine());

            string address = street + ", " + city + ", " + state + ", " + zipCode;
            string personalInfo = $"\n\nName: {name} \nAge: {age} \nAddress: {address}";

            return personalInfo;
        }

        static void AppendLines(string path, string data)
        {
            File.AppendAllText(path, data);
        }

        static void ReadFromFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string data = sr.ReadToEnd();
            Console.WriteLine(data);
            sr.Close();
        }
        static void ColorfulAnimation()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Clear();

                    Console.Write("       . . . . o o o o o o", Color.LightGray);
                    for (int s = 0; s < j / 2; s++)
                    {
                        Console.Write(" o", Color.LightGray);
                    }
                    Console.WriteLine();

                    var margin = "".PadLeft(j);
                    Console.WriteLine(margin + "                _____      o", Color.LightGray);
                    Console.WriteLine(margin + "       ____====  ]OO|_n_n__][.", Color.DeepSkyBlue);
                    Console.WriteLine(margin + "      [________]_|__|________)< ", Color.DeepSkyBlue);
                    Console.WriteLine(margin + "       oo    oo  'oo OOOO-| oo\\_", Color.Blue);
                    Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+", Color.Silver);

                    Thread.Sleep(200);
                }
            }
        }
    }
}
