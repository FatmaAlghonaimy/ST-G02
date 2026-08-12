using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.Abstraction
{
    internal class Circle: Shape, I2dDraw
    {
        public Circle(int Raduis): base(Raduis, Raduis)
        {
            
        }
        public override int Preimeter
        {
            get { return 2 * Dim01 * (int)Math.PI; }
        }
        public override decimal CalcArea()
        {
            return Dim01 * (int)Math.PI* Dim01;
        }
        public void Draw()
        {

        }

    }
}
