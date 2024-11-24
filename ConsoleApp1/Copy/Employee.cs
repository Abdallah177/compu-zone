using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Copy
{
    internal class Employee : ICloneable , IComparable
    {
        #region Properites
        public int ID { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public Department department { get; set; }


        #endregion

        public object Clone()
        {
            return new Employee()
            {
                ID = this.ID,
                Name = this.Name,
                Salary = this.Salary,
                department = (Department)this.department.Clone()
            };
        }
        public int CompareTo(object? obj)
        {
            Employee? emp = obj as Employee;

            return Salary.CompareTo(emp.Salary);
        }
    }
}
