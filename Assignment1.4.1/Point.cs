using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4._1
{
    struct Point
    {
        private double _x;
        private double _y;

        //public Point(double x, double y)
        //{
        //    this._x = x;
        //    this._y = y;
        //}

        public double X
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }
        public double Y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }
    }
}
