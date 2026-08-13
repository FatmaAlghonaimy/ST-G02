using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    static class TestBuiltinDelegates
    {
        public static bool CheckPositive(int num)
        {
            return num > 0;
        }
        //public static string Print()
        //{
        //    return "Message";
        //}
        public static void Print(string name)
        {
            Console.WriteLine(name);
        }
        public static void Print()
        {
            Console.WriteLine("Hello");
        }
        public static string Casting(int num)
        {
            return num.ToString();
        }



    }
}
