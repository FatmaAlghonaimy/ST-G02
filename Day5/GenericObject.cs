using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class GenericObject<T> where T : struct
    {
        public void Print<T>(T item)
        {
            Console.WriteLine(item);
        }
        public void Test()
        {
            Print(10);
            Print("Fatma");
            Print(3.14);
            Print<string>("nada");
            Print<int>(10);
            Print(true);
        }
    }
}
