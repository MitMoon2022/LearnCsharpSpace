using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo2
{
    //base class for furnitures
    class Furniture
    {
        //color of the furniture
        public string Color { get; set; }
        //material of the furniture
        public string Material { get; set; }
        //default constructor
        public Furniture()
        {
            Color = "White";
            Material = "Wood";
        }

        //simple constructor
        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;
        }

    }



}
