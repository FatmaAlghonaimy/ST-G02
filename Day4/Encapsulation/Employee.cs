using System;
using System.Collections.Generic;
using System.Text;

namespace Day4.Encapsulation
{
    internal struct Employee
    {
        private int id;
        string? name;
        //char gender; //f m F M 
        //public int Age { get; } //readonly 

        public Gender Gender {  get; set; }
        public Employee(int _id, string? _name)
        {
            Id = _id;
            SetName(_name);
            Age = 20; //set default
        }

        #region Setter and Getter

        public int GetID()
        {
            //Age = 50;
            return id;
            
        }
        public string? GetName()
        {
            return name;
        }


        public void SetID(int _id)
        {
            id = _id;
        }
        public void SetName(string? _name)
        {
            name = _name?.Length > 5 ? _name.Substring(0, 5) : _name;
        }
        #endregion

        #region Properties  //PascaCase

        public int Id  //full property
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string? Name //full property
        {
            get
            {
                return name;
            }
            set
            {
                //name = "nameeeeeeee"
                //ternary operator
                name = value?.Length > 5 ? value.Substring(0,5) : value;
            }
        }

        //automatic property
        public decimal Salary { get; set; } 
        public int Age { get; } 
        //private decimal salary; //backing field

        #endregion
    }
}
