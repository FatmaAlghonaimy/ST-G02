using Day_6.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.Abstraction
{
    internal class Test:Shape,IType
    {
        public Test():base(0,0)
        {
            
        }
        public override int Preimeter => throw new NotImplementedException();

        public int MyProperty
        {
            get; set;
        }

        public override decimal CalcArea()
        {
            return 0;
        }

        public void MyMethod()
        {
            throw new NotImplementedException();
        }
        public void TestMEthod()
        {
        }
    }
}
