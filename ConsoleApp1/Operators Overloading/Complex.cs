using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Operators_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }

        public int Imag { get; set; }


        public static Complex operator + (Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real??0) +(right?.Real??0),
                Imag= (left?.Imag??0) +(right?.Imag??0)

                // left?.Real 
                // left != null ? left.Real : null 
            };
        }

        public override string ToString()
        {
            return $"{Real}+{Imag}i";
        }
    }
}
