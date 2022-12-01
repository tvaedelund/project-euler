using ProjectEuler.Helpers;

namespace ProjectEuler.Problems;

public class Problem02 : ISolver
{
    public object Solve()
    {
        var max = 4000000;
        var current = 2;
        var sum = 0;
        var phi = 1.618034;

        while (current < max)
        {
            sum += current % 2 == 0 ? current : 0;
            current = (int)Math.Round(current * phi, MidpointRounding.AwayFromZero);
        }

        return sum;
    }
}