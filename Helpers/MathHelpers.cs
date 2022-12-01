namespace ProjectEuler.Helpers;

public static class MathHelpers
{
    // https://en.wikipedia.org/wiki/Trial_division
    public static List<long> FindFactorials(long n)
    {
        var a = new List<long>();
        while (n % 2 == 0)
        {
            a.Add(2);
            n /= 2;
        }
        var f = 3;
        while (f * f <= n)
        {
            if (n % f == 0)
            {
                a.Add(f);
                n /= f;
            }
            else
            {
                f += 2;
            }
        }
        if (n != 1)
        {
            a.Add(n);
        }

        return a;
    }

    public static bool IsPrimeNumber(long n)
    {
        if (n % 2 == 0 || n % 3 == 0)
        {
            return false;
        }

        for (var i = 4L; i < Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}