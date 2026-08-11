using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    //internal public
    internal class Car
    {
        //private 
        //attribute methhods properties events
        // public private internal protected p p internl p

        #region Attributes
        int id;
        string? name;
        double speed;
        #endregion

        #region Propertires
        public int Id { get { return id; } set { id = value; } }
        public string? Name { get { return name; } set { name = value; } }
        public double Speed { get { return speed; } set { speed = value; } }
        #endregion

        //public Car()
        //{
        //    id = default;
        //    name = default;
        //    speed = default;
        //}


        //ctor overloading 
        //differnt logic

        //ctor chaining
        public Car(int id, string? name, double speed)
        {
            this.id = id;
            this.name = name;
            this.speed = speed;
            Console.WriteLine("first ctor");
        }
        //new Car(10, name)
        public Car(int id, string? name):this(id, name, 200)
        {
            Console.WriteLine("second ctor");
        }
        //ne car(10)
        public Car(int id): this(id, "Default Model")
        {
            Console.WriteLine("Third ctor");
        }
        public override string ToString()
        {
            return $"ID:{Id}, Model :{Name}, Speed:{Speed}";
        }
    }
}
