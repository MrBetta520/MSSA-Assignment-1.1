using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteorbucks
{
        enum Milk
        {
            Milk2P,
            Almond,
            Breve,
            Coconut,
            HeavyCream,
            NonfatMilk,
            OatMilk,
            Soy,
            WholeMilk
        }
        enum Temp
        {
            ExtraHot,
            SteamedHot,
            Warm,
            Ice
        }
        enum Topping
        {
            No_Salted_Brown_Butter_Topping,
            Light_Salted_Brown_Butter_Topping,
            Salted_Brown_Butter_Topping,
            Extra_Salted_Brown_Butter_Topping,
            Sub_Stitute_Salted_Brown
        }
        enum Size
        {
            Small,
            Midium,
            Large,
            Extra_Large
        }
        abstract class Beverages
        {
            public string Name { get; set; }
            public float Price { get; set; }
            public Size size { get; set; }
           
            
        }

        class Coffee : Beverages
        {
            public Temp temp { get; set; }
            public Topping topping { get; set; }
            public Milk milk { get; set; }
            public Image image { get; set; }
        }
    
}
