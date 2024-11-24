using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Static
{
    internal class Utillity
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Utillity(int _x , int _y)
        {
            X = _x;
            Y = _y;
        }

        private static double pi;


        // Class Member Proberty : Static Property
        // *** Static Property Get and Set One of these :
        //            1. Static Attribute
        //            2. Constant
        public static double PI
        {
            get { return pi; }
            set { pi = value; }
        }

    }
}
