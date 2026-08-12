using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.Override
{
    internal class ClassD: ClassC
    {
        public int D { get; set; }
        public ClassD(int a, int b, int c, int d) : base(a, b, c)
        {
            D = d;
        }
        public new void MyFun01()
        {
            Console.WriteLine("This is MyFun01 from (ClassD)");
        }
        public override void MyFun02() 
        {
            base.MyFun02();
            Console.Write($" D:{D}");
        }
    }
}
