using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.Interfaces.Example
{
    internal class Airplane:Vehicle, IMoveOnAir, IMoveOnGround
    {
        //by defualt cant have access modifier
        void IMoveOnAir.Forward()
        {
            Console.WriteLine("Move Forward on Air");
        }
        void IMoveOnGround.Forward()
        {
            Console.WriteLine("Move Forward on Ground");
        }
        public void Backward()
        {
            Console.WriteLine("Move Backward");
        }
        public void Left()
        {
            Console.WriteLine("Move Left");
        }
        public void Right()
        {
            Console.WriteLine("Move Right");
        }
    }
}
