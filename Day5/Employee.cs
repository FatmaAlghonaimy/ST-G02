using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    enum Branch:byte
    {
        None,
        HR = 10,
        IT = 20,
        Finance = 30,
        Marketing =40
    }
    [Flags]
    enum Permission : byte
    {
        Read=1,   //0000 0001
        Write = 2,//0000 0010
        Update =4 , //0000 0100
        Delete = 8, //0000 1000       0011
        //Test= 16,
    }
    internal struct Employee
    {
        public int Id { get; set; } //4byte
        public string? Name { get; set; } //4byte 
        public Branch Branch { get; set; } // 1 byte
        public Permission Permission { get; set; } // 1 byte
        //4 permisiion  read write update delete 
        //public bool[] Permissions { get; set; } = new bool[4]; // 0 1 0 0   //4byte , 4 byte
        public Employee(int id, string? name, Branch branch)
        {
            Id = id;
            Name = name;
            Branch = branch;
            
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Branch:{Branch}, Permissions {Permission}";
        }
    }
}
