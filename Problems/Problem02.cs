using System.Diagnostics;

namespace ProkectEuler.Problems;

internal static class Problem02
{
    internal static void Solve()
    {
        var sw = Stopwatch.StartNew();

        var max = 4000000;
        var current = 2;
        var sum = 0;
        var phi = 1.618034;

        while (current < max)
        {
            sum += current % 2 == 0 ? current : 0;
            current = (int)Math.Round(current * phi, MidpointRounding.AwayFromZero);
        }

        sw.Stop();

        Console.WriteLine($"Result: {sum}");
        Console.WriteLine($"Time: {sw.ElapsedMilliseconds} ms");
    }
}