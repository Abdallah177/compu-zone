using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Refree
    {
        public string Name { get; set; }
        public Refree(string name)
        {
            Name = name;
        }

        public override string? ToString()
            => $"Refree : {Name}";

        public void Look()
        {
            Console.WriteLine($"{this} looks at >>> ");
        }
    }
}
