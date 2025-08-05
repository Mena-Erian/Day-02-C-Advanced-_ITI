using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car : IMoveable
    {
        public void Move()
        {
            Console.WriteLine("Car Move");
        }
    }
}
