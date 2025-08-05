using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Day_02
{
    interface IPayable
    {
        decimal Salary { get; set; }
        void ShowPayment()
        {
            Console.WriteLine($"Salary is{Salary}");
        }
    }
}
