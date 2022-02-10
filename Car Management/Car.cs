using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Management
{
    [Serializable]
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public float Price { get; set; }

        public Car(string make, string model, float price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }
    }

    
}
