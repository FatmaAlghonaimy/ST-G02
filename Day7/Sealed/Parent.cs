using System;
using System.Collections.Generic;
using System.Text;

namespace Day7.Sealed
{
    internal class Parent
    {
        private int salary;
        public virtual int Salary { get; set; }
        public virtual void MyFunc()
        {
            Console.WriteLine("I'm Parent");
        }

    }

    class Child : Parent {
        public override int Salary { get => base.Salary; set => base.Salary = value; }
        public sealed override void MyFunc()
        {
            Console.WriteLine("I'm Child");
        }
    }

    sealed class GrandChild : Child {
        public new int Salary { get => base.Salary; set => base.Salary = value; } //hiding
        public new void MyFunc()
        {
            Console.WriteLine("I'm Grand Child");
        }
    }
    //class GrandChild2 : GrandChild
    //{
    //    public new int Salary { get => base.Salary; set => base.Salary = value; } //hiding
    //    public new void MyFunc()
    //    {
    //        Console.WriteLine("I'm Grand Child 2");
    //    }

    //}

}
