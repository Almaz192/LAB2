using System;

public class Complex
{
    // Static constants
    public static readonly Complex Zero = new Complex(0, 0);
    public static readonly Complex One = new Complex(1, 0);
    public static readonly Complex ImaginaryOne = new Complex(0, 1);

    // Properties for real and imaginary parts
    public double X { get; }
    public double Y { get; }

    // Constructors
    public Complex(double x = 0, double y = 0) { X = x; Y = y; }

    // Methods
    public static Complex Re(double x) => new Complex(x, 0);
    public static Complex Im(double y) => new Complex(0, y);
    public static Complex Sqrt(double value) => new Complex(Math.Sqrt(value), 0);

    // Euclidean length of the vector (X, Y)
    public double Magnitude => Math.Sqrt(X * X + Y * Y);

    // Arithmetic operations
    public static Complex operator +(Complex a, Complex b) => new Complex(a.X + b.X, a.Y + b.Y);
    public static Complex operator -(Complex a, Complex b) => new Complex(a.X - b.X, a.Y - b.Y);
    public static Complex operator *(Complex a, Complex b) =>
        new Complex(a.X * b.X - a.Y * b.Y, a.X * b.Y + a.Y * b.X);

    public static Complex operator /(Complex a, Complex b)
    {
        if (b.X == 0 && b.Y == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        double denom = b.X * b.X + b.Y * b.Y;
        return new Complex((a.X * b.X + a.Y * b.Y) / denom, (a.Y * b.X - a.X * b.Y) / denom);
    }

    public static Complex operator +(Complex a) => a;
    public static Complex operator -(Complex a) => new Complex(-a.X, -a.Y);

    // String representation
    public override string ToString() => $"{X} + {Y}i";

    // Equality members
    public override bool Equals(object obj) =>
        obj is Complex other && X == other.X && Y == other.Y;

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + X.GetHashCode();
            hash = hash * 23 + Y.GetHashCode();
            return hash;
        }
    }

}
