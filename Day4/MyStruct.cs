using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    //class -  struct - interface - enum - record
    // internal - private - public 
    //internal
    internal struct MyStruct
    {
        //attributes
        //default access modifier // private

        public int x; //private 


        //methods [Constructor - Getter setter]
        internal void MyFunction()
        {

        }

        //properties [full property - automatic -- indexer]

        int MyProperty { get; set; }

        //4- events 

        //access modifiers
        //private public internal 

    }
}
