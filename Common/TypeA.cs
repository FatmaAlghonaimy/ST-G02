using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public struct TypeA
    {
        private int x;
        internal int y;
        public int z;

        public void Test()
        {
            x = 1; //private 
            y = 1;
            z = 1;
        }
    }
}
