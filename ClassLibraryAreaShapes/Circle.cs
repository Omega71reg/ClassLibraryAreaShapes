using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAreaShapes
{
    public class Circle : IData
    {
        private double R;
        private const double PI = Math.PI;
        public Circle(double r) { R = r; }
        public double Area() => R > 0 ? PI * R * R : 0;
    }
}
