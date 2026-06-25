using static System.Console;

namespace _01_Factorial;

public class Program
{
    protected static int Fact(int n)
    {
        if (n < 0)
            return -1;

        else if (n == 0  ||  n <= 1)
            return 1;

        else
            return n * Fact(n - 1);
    }

    static void Main()
    {
        WriteLine("Calculate Factorial");
        Write("Input an integer: ");
        int num = Convert.ToInt32(ReadLine());
        WriteLine(Fact(num));
    }
}