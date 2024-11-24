using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Player
    {

        public string Name { get; set; }

        public string Team { get; set; }
        public Player(string name, string team)
        {
            Name = name;
            Team = team;
        }

        public override string ToString()
            => $" Name : {Name} , Team : {Team}";

        public void Run ()
         =>   Console.WriteLine($"{this} is Running to >>>> ");
        
        
        


    }
}
