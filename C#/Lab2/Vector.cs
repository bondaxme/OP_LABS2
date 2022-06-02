using System;

namespace lab2
{
    public class Vector
    {
        private double x;
        private double y;
        private double z;

        public Vector(double X, double Y, double Z)
        {
            x = X;
            y = Y;
            z = Z;
        }

        public double GetLength()
        {
            double length = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
            return Math.Round(length, 2);
        }

        public void OutputVector()
        {
            Console.WriteLine($"Vector coordinates: ({x}; {y}; {z}),  vector length: {GetLength()}");
        }
    }
}