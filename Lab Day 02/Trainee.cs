using Lab_Day_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Day_02
{
    internal class Trainee : IPayable, IComparable, IComparer<Trainee>
    {
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        #endregion

        public int CompareTo(object? other)
        {
            Trainee? employee = other as Trainee;
            if (employee == null) return 1;
            return (this.Id == employee.Id) ? 0 : (this.Id > employee.Id) ? 1 : -1;
        }
        
        public int Compare(Trainee? x, Trainee? y) => x?.Salary.CompareTo(y?.Salary ?? default) ?? default;
        public override string ToString() => $"ID: {Id}, Name: {Name}";
    }
}
