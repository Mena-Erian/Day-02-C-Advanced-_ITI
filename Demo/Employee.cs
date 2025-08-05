using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee : IComparable
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int CompareTo(object? other)
        {
            //Employee? employee = other is Employee ? (Employee?)other : null;
            Employee? employee = other as Employee;
            if (employee == null) return 1;
            //if (ReferenceEquals(this, other)) return 0;

            //if (this.Id == employee.Id) return 0;
            //if (this.Id > employee.Id) return 1;
            //return -1;
            return (this.Id == employee.Id) ? 0 : (this.Id > employee.Id) ? 1 : -1;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}";
        }
    }
}
