using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstraction
{
    internal abstract class Shape
    {
        public decimal Dim01 { get; set; }

        public decimal Dim02 { get; set; }


        public abstract decimal CalcArea();
    }
}
