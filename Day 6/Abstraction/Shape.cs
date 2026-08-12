using Day_6.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.Abstraction
{
    //container for common code?
    //any abstract member inside non abstract class
    //contain abstract , non abstract
    abstract class Shape //: IType //abstract class can implement interface
    {
        public int Dim01 { get; set; }
        public int Dim02 { get; set; }
        public static int X { get; set; }

        protected Shape(int dim01, int dim02) //valid  //cant create instance 
        {
            Dim01 = dim01;
            Dim02 = dim02;
        }

        #region abstract
        public abstract int Preimeter { get; }  //internally virtual  override 
        public abstract decimal CalcArea();
        #endregion

        public void MyMethodShape()
        {
            Console.WriteLine("Message");
        }
    }

    abstract class RecBase : Shape
    {
        protected RecBase(int dim1, int dim2) : base(dim1, dim2)
        {

        }
        public override decimal CalcArea()
        {
            return Dim02 * Dim01;
        }
    }
}
