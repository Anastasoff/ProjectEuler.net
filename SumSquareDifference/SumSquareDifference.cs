/*
The sum of the squares of the first ten natural numbers is, 1^2 + 2^2 + ... + 10^2 = 385
The square of the sum of the first ten natural numbers is, (1 + 2 + ... + 10)^2 = 55^2 = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
*/

using System;

internal class SumSquareDifference
{
    private static void Main()
    {
        int SumOfTheSquares = 0;
        for (int i = 1; i <= 100; i++)
        {
            SumOfTheSquares += (int)Math.Pow(i, 2);
        }
        Console.WriteLine(SumOfTheSquares);

        int SquareOfTheSum = 0;
        for (int i = 1; i <= 100; i++)
        {
            SquareOfTheSum += i;
        }
        SquareOfTheSum = (int)Math.Pow(SquareOfTheSum, 2);
        Console.WriteLine(SquareOfTheSum);

        Console.WriteLine(SquareOfTheSum - SumOfTheSquares);
    }
}