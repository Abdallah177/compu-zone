namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dynamic : is a C# KeyWord [ C# 4.0 Feature ]  

            dynamic Data;

            // the Compiler will skip type checking at compilation time 

            // CLR will resolve the actual Type of the Dynamic type variable at runtime
            //  and will be chanched based on the assigning value
            // Can be Intialize with Null .
            // After Intialization you can change it's Data Type .

            Data = "Ahmed" ;
            Data = 10 ;
            Data = 20.5 ;
            Data = true;



            //var obj = new { id = 10, name = "Ahmed", Salary = 20000 };

            //Console.WriteLine( obj.id);

            //Console.WriteLine( obj.Age);


            //dynamic obj01 = new { id = 10, name = "Ahmed", Salary = 20000 };

            //Console.WriteLine(obj01.id);

            //Console.WriteLine(obj01.Age);


        }
    }
}
