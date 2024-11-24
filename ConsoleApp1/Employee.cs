using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class Employee : IComparable
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public Employee(int id , string name , double salary)
        {
            ID= id;
            Name= name ;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Id = {ID} , Name = {Name} , Salary = {Salary}";
        }

        public override bool Equals(object? obj)
        {
            Employee? employee = obj as Employee;
            return (ID == employee?.ID)&&(Name==employee?.Name)&&(Salary==employee?.Salary);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ID,Name,Salary);
        }

        public int CompareTo(object? obj)
        {
            // as Casting Operator  ;
            /// Casting Will Succeed , If and only if obj is "Point"
            /// If Casting Failed , Will Return Null , No Exeption Will be Thrown .

            Employee? emp = obj as Employee;

            if (emp is null) return 1;

            return Salary.CompareTo(emp?.Salary);
        }
    }
}
