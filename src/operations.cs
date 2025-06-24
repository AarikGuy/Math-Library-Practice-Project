using System;
using MathLibrary;

namespace MathLibrary;

public class Operations
{
    public static void Run()
    {
        Console.WriteLine("Test test test");
    }


    /**
    Takes an existing number x, the coefficient and lets 
    users specify what number they want as their power to the coefficient
    */
    public int Power(int x, int y)
    {
        int retVal = 1;

        for (int i = 0; i < y; i++)
        {
            retVal *= x;
        }

        return retVal;
    }

    public double Inverse(int numToBeInversed)
    {
      return Power(numToBeInversed, -1);
    }
}