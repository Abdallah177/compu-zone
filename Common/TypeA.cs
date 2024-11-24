using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeA
    {
        public int A { get; set; }

        public TypeA(int _A)
        {
            A = _A;
        }
        public void Fun01()
        {
            Console.WriteLine("I'm Parent");
        }

        public virtual void Fun02()
        {
            Console.WriteLine($"A : {A}");
        }



    }
}
