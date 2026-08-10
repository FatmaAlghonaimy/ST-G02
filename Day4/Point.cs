using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Day4
{
    internal struct Point
    {
        #region Attributes
        public int x;
        public int y;

        #endregion

        #region Ctor

        //special function
        //the same name 
        //return type

        //ctor overloading 

        //c#14     c#10  c#11 .net 7 
        public Point() //defualt ctor 
        {
            x = default;
            y = default;
        }
        public Point(int _x, int _y) {  //full ctor 
            x = _x;
            y = _y;
        }
        public Point(int _x) {   
            x = _x;
            y = _x;
        }
        #endregion
        public override string ToString()
        {
            return $"X : {x}, Y:{y}";
        }
        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return x ;
        }
    }
}
