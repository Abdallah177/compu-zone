using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB : TypeA
    {

        public int B { get; set; }

        public TypeB(int _A , int _B ): base(_A)
        {
            B = _B ;
        }

        public new void Fun01()
        {
            Console.WriteLine("I'm Child");
        }

        public override void Fun02()
        {
            Console.WriteLine($"A : {A} , B : {B} ");
        }



    }
}
