using ConsoleApp1.Abstraction;


using ConsoleApp1.Generics;
using ConsoleApp1.Operators_Overloading;
using System.Collections;
using static ConsoleApp1.ListGenerator;

namespace ConsoleApp1
{
    

    internal class Program
    {
        
        static void Main(string[] args)
        {

            //var Result = from PrdGroup in
            //                (from P in ProductList
            //                 where P.UnitsInStock > 0
            //                 group P by P.Category)
            //            where PrdGroup.Count() > 10
            //            select PrdGroup; ;

            //var Result =  from P in ProductList
            //              where P.UnitsInStock > 0
            //              group P by P.Category
            //              into PrdGroup
            //              where PrdGroup.Count() > 10
            //              select PrdGroup; ;

            var Result = ProductList.TakeWhile(P => P.UnitsInStock>0);

            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }



        }
    }
}
