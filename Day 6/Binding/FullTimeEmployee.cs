using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.Binding
{
    internal class FullTimeEmployee:Employee
    {
        public decimal Salary { get; set; }

        public FullTimeEmployee(int id, string? name, int age, decimal salary) : base(id, name, age)
        {
            Salary = salary;

        }
        #region Methods
        public override void GetEmployeeType()
        {
            Console.WriteLine("Im FullTime Employee");
        }
        public override void GetEmployeeData()
        {
            base.GetEmployeeData();
            Console.WriteLine($"salary:{Salary}");
        }
        #endregion
    }
}
