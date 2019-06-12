using System;
using Pfernandes.MathBasic.Core;

namespace Pfernandes.MathBasic.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var quadraticEquation = new QuadraticEquation();

            Console.WriteLine("Digite A");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite B");
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite C");
            var c = double.Parse(Console.ReadLine());

            var x = quadraticEquation.Solve(a, b, c);
            
            Console.WriteLine($"X1: {x.x1:N}");
            Console.WriteLine($"X2: {x.x2:N}");
        }
    }
}
