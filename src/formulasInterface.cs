using System.Reflection.Metadata;

public interface FormulasInterface
{
    const double Pi = 3.14159265;
    public double[] Quadratic(double a, double b, double c);
    public double BinomialCoefficient(double n, double k);
    public double AreaOfCircle(double radius);
    
}