using System;
using System.Collections.Generic;
using System.Text;

namespace Day5.Inheritance
{
    internal class Child : Parent  //inheritance through el ctor
    {
        //public int X { get; set; } //do you want to hide???
        //public int Y { get; set; }
        public int Z { get; set; }

        public Child(int x, int y , int z): base(x, y)
        {
            Z = z;
            Console.WriteLine("Child ctor");
        }
        public override string ToString()
        {
            return $"Child X:{X}, Y:{Y}, Z:{Z}";
        }
        public new int Product() //do you want to hide --polymorphism
        {
            return base.Product()*Z;
        }
    }
}
