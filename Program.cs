using System.Diagnostics;
using System.Reflection;
using ProjectEuler.Helpers;

var problemNum = "Problem02";

Console.WriteLine($"Project Euler: {problemNum}");

var solvers = from t in Assembly.GetExecutingAssembly().GetTypes()
                where t.GetInterfaces().Contains(typeof(ISolver))
                         && t.GetConstructor(Type.EmptyTypes) != null
                select Activator.CreateInstance(t) as ISolver;

var problem = solvers.First(x => x.ToString()!.Contains(problemNum));

var sw = Stopwatch.StartNew();

Console.WriteLine($"Solution: {problem.Solve()}");

sw.Stop();

Console.WriteLine($"Time: {sw.ElapsedMilliseconds}ms");
