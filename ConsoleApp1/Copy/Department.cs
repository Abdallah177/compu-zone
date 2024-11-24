using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Copy
{
    internal class Department : ICloneable
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public object Clone()
        {
            return new Department()
            { 
                ID = ID,
                Name = Name
            };

        }


    }
}
