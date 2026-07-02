/*
    ALGORITHMS (Find largest number among three) 

     Designing the algorithm
Now let's design the algorithm with the help of the above pre-requisites:

START

1. Read three numbers: num1, num2, num3

2. If num1 > num2 and num1 > num3, then

       largest = num1

   Else if num2 > num3, then

       largest = num2

   Else

       largest = num3

3. Print largest

END

 */

using System;
using static System.Console;

class _01_IntroAlgorithms 
{
    static void Main() 
    {
        int num1 = 15, num2 = 18, num3 = 12;
        int largest = 0;

        if (num1 > num2 && num1 > num3)
            largest = num1;
        else if (num2 > num3)
            largest = num2;
        else
            largest = num3;

        WriteLine($"Largest number: {largest}");
    }
}