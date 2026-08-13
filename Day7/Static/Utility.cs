using System;
using System.Collections.Generic;
using System.Text;

namespace Day7.Static
{
    //concrete class 
    // hold concrete members , static members 
    // cant inherit from it ?
    //static members , const members
    static class Utility
    {
        //public const double pi = 3.14; //must be initializes in declaration time, cant be changed elsewhere
        //internally static 
        private static readonly double pi;
        public static double PI  //readonly
        {
            get
            {
                return pi;
            }
            //set
            //{
            //    pi = value;
            //}
        }
        //public int X { get; set; }
        //public int Y { get; set; }

        #region Ctor
        //private 
        //called only once before the first use to the class
        static Utility()
        {
            //to initialze static readonly properties
            //set up tasks 
            pi = 3.14;
            Console.WriteLine("Static Ctor");
        }
        //public Utility()
        //{
        //    X = 10; Y = 20;
        //    //pi = 15;
        //}

        #endregion

        #region Class member 
        public static double MeterToCM(double value)
        {
            //pi = 5;
            return value * 100;
        }
        public static double CalcCircleArea(double rad)
        {
            return rad * rad * pi;
        }
        #endregion

        #region Object member
        //public void Test()
        //{
        //    Console.WriteLine(pi);
        //    Console.WriteLine(PI);
        //}
        #endregion

    }


    ////extension methods
    //class Test : Utility
    //{

    //}
}
