
using static System.Console;

namespace _03_GridUniquePath;

public class Program
{
    static void Main()
    {
        WriteLine("Grid Unique Path problem");
        int m = 3;
        int n = 3;
        WriteLine($"Column {m} x Row {n}");
        WriteLine($"Output: {Algorithm.FindGridUniquePath(m, n)}");
    }
}