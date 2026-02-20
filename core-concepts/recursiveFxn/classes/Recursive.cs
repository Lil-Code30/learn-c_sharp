namespace recursiveFxn.classes;

public class Recursive
{
    public static int Somme(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n + Somme(n - 1);
        }
    }
    
    // factorial
    public static int Factorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
    
    // power
    public static int Power(int n, int power)
    {
        if (power == 0)
        {
            return 1;
        }

        return n * Power(n, power - 1);
    }
    
    // Fibonacci
    public static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    
    // Ackermann 
    public static int Ackermann(int n, int m)
    {
        if (m == 0)
        {
            return n + 1;
        } else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m , n - 1));
        }
    }
}