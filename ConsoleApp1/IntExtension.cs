using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class IntExtension
    {
        // 12345
        // 5
        public static int Reverse (int value)
        {
            int R, Result = 0 ;
            while (value > 0)
            {
                 R = value%10 ;
                 value/=10 ;
                 Result = Result*10 + R ;
            }
            return Result ;
        }
    }
}
