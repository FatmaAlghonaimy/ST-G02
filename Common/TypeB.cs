using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class TypeB: TypeA
    {
        //private int x;
        //internal int y;
        //public int z;

        //private protected int a;
        //protected int b;
        //internal protected int c;
        public TypeB()
        {
            //x = 1;    //invalid
            //y = 2;  //internal
            //z = 3; //public 

            //a = 4; //private inside the same assembly
            //b = 5; //private 
            //c = 6; //internal 
        }
    }
}
