using ProjectEuler.Helpers;
using System.Diagnostics;

namespace ProjectEuler.Problems;

public class Problem03 : ISolver
{
    public object Solve()
    {
        return MathHelpers.FindFactorials(600851475143).Max();
    }
}