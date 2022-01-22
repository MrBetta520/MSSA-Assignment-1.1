using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1
{
    abstract class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public virtual void AreaCalculate()
        {
            Console.WriteLine("Let's do some math.");
        }
    }

    class Circle : Shape
    {
        public double redius { get; set; }

        public override void AreaCalculate()
        {
            double area = Math.PI * Math.Pow(redius, 2);
            string areaString = String.Format("The area of this circle is {0:0.00}.", area);
            Console.WriteLine(areaString);
        }
    }

    class Square : Shape
    {
        public double lengthOfSide { get; set; }
        public override void AreaCalculate()
        {
            double area = Math.Pow(lengthOfSide, 2);
            string areaString = String.Format("The area of this square is {0:0.00}.", area);
            Console.WriteLine(areaString);
        }
    }
}
