using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Generics
{
    internal class Helper<T>
    {
        public static void Swap (ref T x,ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static int SearchArray (T[] arr , T value)
        {
            if (arr is not null)
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(value))
                    return i;
            }
            return -1;
        }
    }
}
