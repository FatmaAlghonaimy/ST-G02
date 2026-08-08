using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    internal class Test
    {
        //access modifier 
        public static void PrintShape( string Shape, int count = 10) //last paratmeter
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(Shape);
            }
        }

        //public void PrintShape()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine(":) ");
        //    }
        //}
    }
}
