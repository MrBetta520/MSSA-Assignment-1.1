using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4._2
{
    class Student
    {
        private int studentId;
        private string studentFname;
        private string studentLname;
        private char studentGrade;

        public int StudentId
        {
            get;set;
        }
        public string StudentFname
        {
            get;set;
        }
        public string StudentLname
        {
            get;set;
        }
        public char StudentGrade
        {
            get;set;
        }

        public void displayStudent()
        {
            Console.WriteLine($"Student's ID is {this.StudentId}, name is {this.StudentFname} {this.StudentLname}, grade is {this.StudentGrade}.");
        }
    }
}
