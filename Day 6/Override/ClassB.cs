using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.Override
{
    internal class ClassB : ClassA
    {
        public int B { get; set; }
        public ClassB(int a, int b): base(a)
        {
            B = b;   
        }
        public new void MyFun01()  //mrthod hiding - compile time 
        {
            Console.WriteLine("This is my Func 1 From Class B");
        }
        public override void MyFun02()   //override - runtime
        {
            base.MyFun02();
            Console.WriteLine($" B:{B}");
        }
    }
}
