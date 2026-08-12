using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.Interfaces
{
    internal class ClassInterface : IType
    {
        public int MyProperty { get; set; } //generation of backing filed
        //private int myproperty;
        public void MyMethod()
        {
            Console.WriteLine("HEllo from Class interface");
        }
        public void MyMethod03()
        {
            Console.WriteLine("HEllo from Class interface");
        }
    }
}
