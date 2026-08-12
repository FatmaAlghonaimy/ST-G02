using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.Interfaces.Example
{
    internal class Car: Vehicle, IMoveOnGround
    {
        public void Backward()
        {
            Console.WriteLine("MoveBackward");
        }
        public void Forward()
        {
            Console.WriteLine("Move Forward");
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
