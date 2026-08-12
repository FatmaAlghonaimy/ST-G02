using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.Interfaces
{
    internal interface IType  //
    {
        //contract??

        //no field , ctor, static members
        //1- property signature??
        internal int MyProperty { get;  }  //autmoatic proprty
        //backing field
        // private int myProerty

        //2- method signature
        public void MyMethod();

        //3 default implemeented method

        //c#8 
        public void MyMethod02(string name)
        {
            Console.WriteLine("This is the interface defualt implemented method");
        }
    }
}
