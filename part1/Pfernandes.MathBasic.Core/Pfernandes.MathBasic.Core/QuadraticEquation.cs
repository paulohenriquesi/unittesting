
using System;

namespace Pfernandes.MathBasic.Core
{
    public class QuadraticEquation
    {
        public (double x1, double x2) Solve(double a, double b, double c)
        {
            if(a == 0)
                throw new ArgumentException("a must not be zero", nameof(a));

            var insideRoot = (b * b) - 4 * a * c;
            var root = Math.Sqrt(insideRoot);

            var x1 = (-b + root) / (2 * a);
            var x2 = (-b - root) / (2 * a);

            return (x1, x2);
        }
    }
}