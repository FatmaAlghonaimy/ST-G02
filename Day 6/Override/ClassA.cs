using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.Override
{
    internal class ClassA
    {
        public int A { get; set; }
        public ClassA(int a)
        {
            A = a;
        }
        public void MyFun01() {
            Console.WriteLine("This is my Func 1 From Class A");
        }
        public virtual void MyFun02() {  //virtual , override, abstract
            Console.WriteLine($"This is my Func 2 and A : {A}");
        }
    }
}
