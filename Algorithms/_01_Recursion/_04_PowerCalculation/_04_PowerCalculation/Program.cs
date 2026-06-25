
using static System.Console;

public class Program
{
    public static double PowerRecursion(double baseValue, int exponent)
    {
        if (exponent < 0)
            return 1.0 / Algo(baseValue, -exponent);

        return Algo(baseValue, exponent);
    }


    private static double Algo(double baseValue, int exponent)
    {
        if (exponent == 0)
            return 1.0;

        if (exponent == 1)
            return baseValue;

        double half = Algo(baseValue, exponent / 2);

        double result = half * half;

        // If exponent is ODD, multiply by baseValue once more
        if ((exponent & 1) == 1)
            return result *= baseValue;

        return result;
    }


    static void Main()
    {
        WriteLine("Power Calculation using recursion");
        Write("Enter an integer: ");
        double num = Convert.ToDouble(ReadLine());
        Write("Enter the exponent value: ");
        int expo = Convert.ToInt32(ReadLine());
        WriteLine($"Result: {PowerRecursion(num, expo)}");
    }
}