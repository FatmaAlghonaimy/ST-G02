using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6.BuiltinInterface
{
    internal class EmployeeNameComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return string.Compare(x?.Name, y?.Name);
        }
    }
    internal class EmployeeIDComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return 1;
            //return int.Compare(x?.Id, y?.Id);
        }
    }
}
