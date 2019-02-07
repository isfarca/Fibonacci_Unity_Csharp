using UnityEngine;

public class MyMathFunctions
{
    /// <summary>
    /// Algorithm from fibonacci (short version).
    /// </summary>
    /// <param name="n">Number of passes.</param>
    /// <returns>End result from fibonacci.</returns>
    public static int Fibonacci(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    /// <summary>
    /// Algorithm from fibonacci (long version).
    /// </summary>
    /// <param name="n">Number of passes.</param>
    /// <returns>End result from fibonacci.</returns>
    public static int FibonacciProcedural(int n)
    {
        // Declare variables
        int a = 1;
        int b = 1;
        int temp;

        for (int i = 0; i < n; i++)
        {
            temp = a;
            a = b;
            b = b + temp;
        }

        return a;
    }
}
