using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    enum MonthOfAdmission
    {
        Jan,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dem
    }
    enum Grade
    {
        A,
        B,
        C,
        D
    }

    struct Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeAddress { get; set; }
        public MonthOfAdmission MonthOfAdmission { get; set; }
        public Grade Grade { get; set; }
        public Image image { get; set; }
    }
}
