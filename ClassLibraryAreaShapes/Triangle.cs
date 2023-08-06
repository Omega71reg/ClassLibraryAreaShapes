using System;
using System.Security.Policy;

namespace ClassLibraryAreaShapes
{
    public class Triangle : IData
    {
        public double A, B, C;
        public bool Rectangular() => ((A * A + B * B == C * C) || (A * A + C * C == B * B) || (C * C + B * B == A * A));
        public Triangle(double a, double b, double c) { A = a; B = b; C = c;

            if (A <= 0 || B <= 0 || C <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть больше нуля.");
            }

            if (!IsValidTriangle(A, B, C))
            {
                throw new ArgumentException("Невозможно построить треугольник с заданными сторонами.");
            }
        }
        private bool IsValidTriangle(double A, double B, double C)
        {
            return (A + B > C) && (A + C > B) && (B + C > A);
        }
        private double P() => (A + B + C) / 2;
        public double Area()
        {                
            double S = Math.Sqrt(P() * (P() - A) * (P() - B) * (P() - C));
            return S;
        }
    }
}
