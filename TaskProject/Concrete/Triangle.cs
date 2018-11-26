using System;
using TaskProject.Abstract;

namespace TaskProject.Concrete
{
    public class Triangle : Figure
    {
        public int A { get; }
        public int B { get; }
        public int C { get; }

        /// <exception cref="ArgumentOutOfRangeException">Thrown when side is set to be less than zero 
        /// or more than sum of other two sides</exception>
        public Triangle(int a, int b, int c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentOutOfRangeException("Value", "Side cannot be less than zero");
            }

            if (a > b + c || b > a + c || c > a + b)
            {
                throw new ArgumentOutOfRangeException("Value", "Side cannot be longer than sum of other two sides");
            }              

            A = a;
            B = b;
            C = c;
        }

        public override double GetArea()
        {
            var p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        
        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            return
                A * A == B * B + C * C ||
                B * B == A * A + C * C ||
                C * C == A * A + B * B;
        }
    }
}