using System;
using MathLibrary;

namespace MathLibrary;

public class Operations : OperationsInterface
{
    public static void Run()
    {
        Console.WriteLine("Test test test");
    }


    /**
    Takes an existing number x, the coefficient and lets 
    users specify what number they want as their power to the coefficient
    */
    public double Power(double x, double y)
    {
        double retVal = 1;



        for (double i = 1; i <= AbsoluteVal(y); i++)
        {
            //if y is positive
            if (y > 0)
            {
                retVal *= x;
            }
            //if y is negative
            if (y < 0)
            {
                retVal /= x;
            }
        }

        return retVal;
    }

    /**
    Returns the absolute value of the number specified
    */
    public double AbsoluteVal(double x)
    {
        if (x < 0)
        {
            return x * -1;
        }

        return x;
    }

    /**
    Returns the inverse of the number specified.
    */
    public double Inverse(double numToBeInversed)
    {
        if (numToBeInversed == 0)
        {
            throw new ArithmeticException("The inverse of 0 is undefined.");
        }
        return Power(numToBeInversed, -1);
    }

    public bool IsPrime(double x)
    {
        throw new NotImplementedException();
    }

    public double Squared(double x)
    {
        return x * x;
    }

    public double Cubed(double x)
    {
        return x * x * x;
    }

    public double SquareRoot(double x)
    {
        return Power(x, 1 / 2);
    }

    public double Factorial(double x)
    {
        throw new NotImplementedException();
    }

    public double Log(double value, double baseVal)
    {
        throw new NotImplementedException();
    }
}