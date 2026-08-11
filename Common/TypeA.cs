using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class TypeA
    {
        private int x;
        internal int y;
        public int z;

        private protected int a;
        protected int b;
        internal protected int c;

        public void Test()
        {
            x = 1; //private 
            y = 1;
            z = 1;
            a = 1;
            b = 0;
            c = 0;
        }
    }
}
