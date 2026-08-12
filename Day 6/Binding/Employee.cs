using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.Binding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        #region Ctor
        public Employee(int id, string? name, int age)
        {
            Id = id;
            Name = name;
            Age = age;

        }
        #endregion

        #region Methods
        public virtual void GetEmployeeType()
        {
            Console.WriteLine("Im Employee");
        }
        public virtual void GetEmployeeData()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age:{Age}");
        }
        #endregion
    }
}
