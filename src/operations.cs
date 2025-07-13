using System;
using MathLibrary;

namespace MathLibrary;

public class Operations : OperationsInterface
{
    public const double Pi = 3.14159265;
    public const double e = 2.718281828459045;

    /**
    Takes an existing number x, the coefficient and lets 
    users specify what number they want as their power to the coefficient
    */
    public double Power(double x, double y)
    {
        double retVal = 1;

        // If the exponent is not a whole number than use Newton's Method.
        if (y % 1 != 0)
        {



            // This solves fractional powers that can use the sqrt rule
            // a^m/n ==> sqrt(a^m) e.g: 5^3/2 ==> sqrt(5^3) ==> sqrt(125) ==> 11.1803


            // Solves square roots
            return NewtonsMethod(x, y);
        }


        //This only works if the numbers are whole
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

    //Helper method to help approximate decimal powers
    //This method only works if it's in the square root form i.e. 5^(3/4) ==> 4sqrt(125)
    //I need to essentially write logs/lns for this to work
    //TODO: Fix this code because this isn't correct. Needed to implement Log for this to work.
    public double NewtonsMethod(double num, double power)
    {
        double retVal = 1;

        for (int i = 0; i < 5; i++)
        {
            retVal = power * (retVal + (num / retVal));
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
        if (x < 0)
        {
            throw new ArithmeticException("The square root of any negative number would produce an imaginary number.");
        }
        return Power(x, 1.0 / 2.0);
    }

    public double Factorial(double x)
    {
        if (x < 0)
        {
            throw new ArithmeticException("You can't calculate the factorial of a negative.\n" +
            "Factorial is defined as the product of all positive integers less than or equal\n" +
            " to a non-negative integer.");
        }

        double retVal = 1;

        while (x > 0)
        {
            retVal *= x;

            x--;
        }

        return retVal;

    }

    public double Log(double value, double baseVal)
    {
        double iter = baseVal;
        double counter = 1;

        //TODO: implement special case of when the return value will be a decimal.

        //Implement log(ab) = log(a) + log(b)

        //Implement log(a/b) = log(a) - log(b)

        //Implement log(a^n) = n*log(a)

        //This works only if the answers are whole numbers.
        while (iter != value)
        {
            iter *= baseVal;
            counter++;
        }

        return counter;
    }

    public double Ln(double x)
    {
        double numerator = x - 1;
        double retVal = 0;

        // 1 edge case
        if (x == 1)
        {
            return 0;
        }

        // Negatives edge case
        if (x < 0)
        {
            throw new ArithmeticException("The log function is defined only for positive real numbers.");
        }

        // Taylor Series

        // This only works for numbers that output a value that is lower than 1... for the most part. e.g. ln(2.71) should ==> .9969 but output NaN.
        for (int i = 1; i <= 10000; i++)
        {
            if (i % 2 == 0)
            {
                retVal -= Power(numerator, i) / i;
            }
            else
            {
                retVal += Power(numerator, i) / i;
            }


        }

        return retVal;

    }
}