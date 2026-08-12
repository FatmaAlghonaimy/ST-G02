using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.BuiltinInterface
{
    internal class Employee: ICloneable, IComparable<Employee>
    {
            
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }


        #endregion

        #region CTor
        public Employee()
        {

        }

        public Employee(Employee employee) //emp1
        {
            this.Id = employee.Id; //emp2 ==emp1    
            this.Name = employee.Name;
            this.Salary = employee.Salary;
        }
        #endregion

        #region MEthods
        public override string ToString()
        {
            return $"Id = {Id} , Name = {Name} , Salary = {Salary:c}";
        }
        #endregion

        #region ICLonable
        public object Clone()
        {
            //emp02 = (Employee)emp01.Clone();
            return new Employee(this);
            //return new Employee
            //{
            //    Id = this.Id,
            //    Name = this.Name,
            //    Salary = this.Salary
            //};
        }
        #endregion

        //public int CompareTo(object? obj)
        //{
        //    throw new NotImplementedException();
        //}

        public int CompareTo(Employee? other)
        {
            //first > second return +
            // first < second return -
            // 0 first == second

            //if (this.Salary > other?.Salary)
            //{
            //    return -1;
            //}
            //else if(this.Salary < other?.Salary)
            //{
            //    return 1;
            //}
            //return 0;

            //return -1*this.Salary.CompareTo(other?.Salary);
            return other?.Salary.CompareTo(this.Salary) ?? 0;

        }

    }
}
