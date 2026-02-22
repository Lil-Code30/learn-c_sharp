namespace Mise_en_application_05_A.Exercises;

public class Exercises
{
    public static int PGCD(int m, int n)
    {
        if(m == 0)
        {
            return n;
        }

        return PGCD(m, n % m);
    }

    public static void Dec2Bin(int n)
    {
        if ( n > 1)
        {
            Dec2Bin(n / 2);
        }

        Console.Write(n % 2);
    }
}