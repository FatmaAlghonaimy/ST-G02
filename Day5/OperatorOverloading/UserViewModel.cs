using System;
using System.Collections.Generic;
using System.Text;

namespace Day5.OperatorOverloading
{
    internal class UserViewModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LnameName { get; set; }

        public static implicit operator UserViewModel(User user)
        {
            string[]? names = user?.FullName?.Split(' ');
            return new UserViewModel
            {
                Id = user?.Id ?? 0,
                FirstName = names?[0] ?? string.Empty,
                LnameName = names?[1] ?? string.Empty,

            };
        }
        public override string ToString()
        {
            return $"Id{Id}, FirstName{FirstName}, Last{LnameName}";
        }
    }
}
