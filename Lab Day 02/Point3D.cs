using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.First_Task
{
    internal class Point3D : IComparable<Point3D>, ICloneable
    {
        #region Properties
        public int X { get;  set; }
        public int Y { get; private set; }
        public int Z { get; private set; }
        #endregion

        #region Constructors
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3D(int x, int y) : this(x, y, 0)
        {
        }
        public Point3D(int x) : this(x, 0, 0)
        {
        }
        public Point3D()
        {
        }
        #endregion


        #region Methods
        public int CompareTo(Point3D? other)
        {
            if (other is null) return 1;

            #region Another implemntation
            ////int resultX = X.CompareTo(other.X);
            ////int resultY = Y.CompareTo(other.Y);
            ////int resultZ = Z.CompareTo(other.Z);

            ////if (resultX == 0 && resultY == 0 && resultZ == 0) return 0;

            ////return (resultX + resultY + resultZ) > 0 ? -1 : 1;

            //double p1 = X * X + Y * Y + Z * Z;
            //double p2 = other.X * other.X + other.Y * other.Y + other.Z * other.Z;
            #endregion

            int resultX = X.CompareTo(other.X);
            if (resultX != 0) return resultX;

            int resultY = Y.CompareTo(other.Y);
            if (resultY != 0) return resultY;

            return Z.CompareTo(other.Z);
        }
        public static void Print(Point3D[] points)
        {
            foreach (Point3D point in points)
                Console.WriteLine(point);
        }
        public void Print()
        {
            Console.WriteLine(this);
        }

        public object Clone()
        {
            return new Point3D(this.X, this.Y, this.Z);
        }

        #region Overriding [ToString, Equals, GetHashCode]
        public override bool Equals(object? obj)
        {
            if (obj is null) return false;

            Point3D other = (Point3D)obj;

            return this.X == other.X && this.Y == other.Y && this.Z == other.Z;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z); // based on equailty
        }
        public override string ToString()
        {
            return $"Point Coordiantes: ({X},{Y},{Z})";
        }
        #endregion
        #endregion

    }
}
