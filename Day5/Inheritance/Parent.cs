using System;
using System.Collections.Generic;
using System.Text;

namespace Day5.Inheritance
{
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"Parent X : {X}, Y : {Y}";
        }
        public Parent(int x, int y)
        {
            X = x ;
            Y = y ;
            Console.WriteLine("Parent ctor");
            
        }
        public int Product()
        {
            return X * Y; 
        }
    }
}
