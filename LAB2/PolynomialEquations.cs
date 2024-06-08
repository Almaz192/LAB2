using System;
using System.Numerics;

public class PolynomialEquation : IEquation
{
    private double[] _coefficients;
    private ISolveStrategy _strategy;

    public PolynomialEquation(double[] coefficients)
    {
        _coefficients = Equations.RemoveLeadingZeros(coefficients);
        _strategy = Equations.SelectStrategy(_coefficients);
    }

    public int Dimension => _coefficients.Length;
    public double[] Coefficients => (double[])_coefficients.Clone();

    public Complex[] FindRoots()
    {
        if (_strategy == null)
            throw new Exception("Unknown type of equation.");
        return _strategy.Solve(_coefficients);
    }
}
