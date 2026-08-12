using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.Override
{
    internal class ClassC:ClassB
    {
        public int C { get; set; }
        public ClassC(int a , int b, int c): base(a,b)
        {
            C = c;
            
        }
        public new void MyFun01()
        {
            Console.WriteLine("This is MyFun01 from (ClassC)");
        }
        public override void MyFun02()   //new level of virtuality
        {
            base.MyFun02();
            Console.Write($" C:{C}");
        } 
    }
}
