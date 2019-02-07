using UnityEngine;

public class Fibonacci : MonoBehaviour
{
	// Use this for initialization
	void Start()
    {
        // Declare variables
        int n = 8;

        // Output the fibonacci-values in the short version.
        Debug.Log("---------- Short version ----------");
        Debug.LogFormat("' {0}. ' ' {1} '", n, MyMathFunctions.Fibonacci(n));

        // Output the fibonacci-values in the long version.
        Debug.Log("---------- Long version ----------");
        Debug.LogFormat("' {0}. ' ' {1} '", n, MyMathFunctions.FibonacciProcedural(n));
    }
}
