using System;
using System.Collections.Generic;
using System.Text;

namespace Day5.OperatorOverloading
{
   //represent user in db 
   //poco 
    internal class User
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Guid? SecurityStamp { get; set; }
    }
}
