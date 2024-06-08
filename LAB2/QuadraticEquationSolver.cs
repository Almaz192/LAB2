using System;
using System.Numerics;

public class QuadraticEquationSolver : ISolveStrategy
{
    public Complex[] Solve(double[] coefficients)
    {
        double a = coefficients[2], b = coefficients[1], c = coefficients[0];
        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return new Complex[] { new Complex(root1, 0), new Complex(root2, 0) };
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            return new Complex[] { new Complex(root, 0) };
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            return new Complex[] { new Complex(realPart, imaginaryPart), new Complex(realPart, -imaginaryPart) };
        }
    }
}
