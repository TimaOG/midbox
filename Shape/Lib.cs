﻿namespace Shape
{
    public interface IShape
    {
        double CalculateArea();
    }
    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
    public class Triangle : IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Sides must be positive.");

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException("The provided sides do not form a triangle.");

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double CalculateArea()
        {
            double s = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
        }

        public bool IsRightAngled()
        {
            var sides = new[] { _sideA, _sideB, _sideC };
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1e-10;
        }
    }
}
