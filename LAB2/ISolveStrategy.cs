using System.Numerics;

public interface ISolveStrategy
{
    Complex[] Solve(double[] coefficients);
}
