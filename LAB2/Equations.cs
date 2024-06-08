using System;

public static class Equations
{
    public static double[] RemoveLeadingZeros(double[] coefficients)
    {
        int i = coefficients.Length - 1;
        while (i >= 0 && coefficients[i] == 0) i--;
        if (i < 0) return new double[] { 0 };
        double[] result = new double[i + 1];
        Array.Copy(coefficients, result, i + 1);
        return result;
    }

    public static ISolveStrategy SelectStrategy(double[] coefficients)
    {
        switch (coefficients.Length)
        {
            case 2:
                return new LinearEquationSolver();
            case 3:
                return new QuadraticEquationSolver();
            default:
                throw new Exception("Unknown type of equation");
        }
    }
}
