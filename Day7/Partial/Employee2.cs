using System;
using System.Collections.Generic;
using System.Text;

namespace Day7.Partial
{
    public partial class Employee
    {
        public int MyProperty { get; set; }
        public partial void Print()
        {
            Console.WriteLine("Hello From Second Partial Class");
        }
    }
}
