using System;
using System.Collections.Generic;
using System.Text;

namespace Day7.Partial
{
    //EF generate 
    public partial class Employee
    {
        //private var id;
        //public var Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public partial void Print();
        public void Test()
        {
            Console.WriteLine("Hello from Class Employee");
            Print();
        }
    }
}
