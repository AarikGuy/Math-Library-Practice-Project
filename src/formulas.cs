using System;
using MathLibrary;

namespace MathLibrary;

/// <inheritdoc/>
public class Formulas : Operations, FormulasInterface
{
    public double AreaOfCircle(double radius)
    {
        return Squared(radius) * Pi;
    }

    public double BinomialCoefficient(double n, double k)
    {
        double numerator = Factorial(n);
        double denominator = Factorial(k) * Factorial(n - k);

        return numerator / denominator;
    }

    public double[] Quadratic(double a, double b, double c)
    {
        throw new NotImplementedException();
    }
}