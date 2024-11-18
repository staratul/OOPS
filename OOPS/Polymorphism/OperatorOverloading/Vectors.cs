using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Polymorphism.OperatorOverloading
{
    public class Vectors
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Vectors operator +(Vectors v1, Vectors v2)
        {
            return new Vectors { X = v1.X + v2.X, Y = v1.Y + v2.Y };
        }
    }
}
