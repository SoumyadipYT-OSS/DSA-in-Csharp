
using static System.Console;

namespace _02_ClimbStairs;


public class Program
{
    static void Main()
    {
        WriteLine("Climb Stairs problem");

        WriteLine("Number of ways to climb 2 stairs: " + Algorithm.ClimbStairs(2));
        WriteLine("Number of ways to climb 4 stairs: " + Algorithm.ClimbStairs(4));
        WriteLine("Number of ways to climb 5 stairs: " + Algorithm.ClimbStairs(5));
    }
}
