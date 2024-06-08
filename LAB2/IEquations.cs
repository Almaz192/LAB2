using System.Numerics;

public interface IEquation
{
    int Dimension { get; }
    double[] Coefficients { get; }
    Complex[] FindRoots();
}
