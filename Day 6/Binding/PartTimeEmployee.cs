using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.Binding
{
    class PartTimeEmployee : Employee
    {
        public int CountOfHours { get; set; }
        public decimal HourRate { get; set; }

        public PartTimeEmployee(int id, string? name, int age, int Count, decimal hourRate) : base(id, name, age)
        {
            CountOfHours = Count;
            HourRate = hourRate;

        }
        #region Methods
        public override void GetEmployeeType()
        {
            Console.WriteLine("I'm PartTime Employee");
        }
        public override void GetEmployeeData()
        {
            base.GetEmployeeData();
            Console.WriteLine($"HourRate:{HourRate}, Count :{CountOfHours}");
        }
        #endregion
    }
}
