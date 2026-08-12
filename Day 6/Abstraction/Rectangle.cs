using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.Abstraction
{
    internal class Rectangle : RecBase
    {
        public Rectangle(int dim1, int dim2) : base(dim1, dim2)
        {

        }
        public override int Preimeter
        {
            get { return (Dim01 + Dim02)*2; }
            //set {  Dim01 = value; } //invlaid only valid in interface
        }
        //public override decimal CalcArea()
        //{
        //    return Dim02 * Dim01;
        //}
    }
}
