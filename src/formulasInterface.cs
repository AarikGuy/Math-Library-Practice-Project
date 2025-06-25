using System.Reflection.Metadata;

public interface FormulasInterface
{
    const double Pi = 3.14159265;

    /// <summary>
    /// This is the quadratic formula. 
    /// This is used to help find the x intercepts of your function.
    /// </summary>
    /// <param name="a"> The leading coefficient (x^2)</param>
    /// <param name="b"> the 2nd coefficient (x)</param>
    /// <param name="c"> The constant</param>
    /// <returns>The x intercepts from left to right</returns>
    public double[] Quadratic(double a, double b, double c);

    /// <summary>
    /// This is the Binomial Coefficient formula or formally known as the 'n choose k' formula.
    /// This is used a lot in discrete math and certain parts of calculus.
    /// </summary>
    /// <param name="n"></param>
    /// <param name="k"></param>
    /// <returns>A double value</returns>
    public double BinomialCoefficient(double n, double k);

    /// <summary>
    /// Gets the area of a circle given it's radius
    /// </summary>
    /// <param name="radius"></param>
    /// <returns>The area</returns>
    public double AreaOfCircle(double radius);

}