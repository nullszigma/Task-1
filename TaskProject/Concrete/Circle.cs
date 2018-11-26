using System;
using TaskProject.Abstract;

namespace TaskProject.Concrete
{
    public class Circle : Figure
    {
        public double Radius { get;}

        /// <exception cref="ArgumentOutOfRangeException">Thrown when radius is set to be less than zero</exception>
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius), "Value cannot be less than zero");
            }

            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.Round(Math.PI * Radius * Radius, 2);
        }
    }
}