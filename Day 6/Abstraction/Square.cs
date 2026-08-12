using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.Abstraction
{
    internal class Square: RecBase, I2dDraw, I3dDraw
    {
        public Square(int dim): base(dim, dim)
        {
            
        }
        public override int Preimeter
        {
            get { return Dim01 * 4; }
            //set {  Dim01 = value; } //invlaid only valid in interface
        }
        //public override decimal CalcArea()
        //{
        //    return Dim02 * Dim01;
        //}

        void I2dDraw.Draw()
        {
            throw new NotImplementedException();
        }
        void I3dDraw.Draw()
        {
            throw new NotImplementedException();
        }
    }

}
