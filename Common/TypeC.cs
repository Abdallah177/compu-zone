using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeC : TypeB
    {
        public int C { get; set; }
        public TypeC(int a , int b , int c) : base(a,b)
        {
            C= c;
        }

        public override void Fun02()
        {
            Console.WriteLine("Type0C");
        }
    }
}
