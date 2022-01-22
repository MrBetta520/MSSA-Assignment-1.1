using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Management System.");
            
            try
            {
                char choice = 'y';
                while (choice == 'y' || choice == 'Y')
                {
                    CallMenu();
                    Console.WriteLine("If you want to input more student information, press y or Y. Otherwise, press any to quit.");

                    choice = Convert.ToChar(Console.ReadLine());
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for using this system, Goodbey!");
                Console.ReadLine();
            }
        }

        static void InputStudentInfo()
        {
            Student student = new Student();
            Console.WriteLine("Please enter student's ID.");
            student.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter student's last name.");
            student.StudentLname = Console.ReadLine();
            Console.WriteLine("Please enter student's first name.");
            student.StudentFname = Console.ReadLine();
            Console.WriteLine("Please enter student's grade. The grade must be A, B, C, D.");
            student.StudentGrade = Convert.ToChar(Console.ReadLine());

            while (student.StudentGrade != 'A' && student.StudentGrade != 'a' &&
                   student.StudentGrade != 'B' && student.StudentGrade != 'b' &&
                   student.StudentGrade != 'C' && student.StudentGrade != 'c' &&
                   student.StudentGrade != 'D' && student.StudentGrade != 'd')
            {
                Console.WriteLine("Please enter A, B, C, or D");
                student.StudentGrade = Convert.ToChar(Console.ReadLine());
            }

            student.displayStudent();
        }
        static void CallMenu()
        {
            Console.WriteLine("If you want to input student's information, press 1, any other letter to quit.");
            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    InputStudentInfo();
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Please press 1.");
                    Console.ReadLine();
                    break;
            }
        }
    }
    
}
