// 3. The prime factors of 13195 are 5, 7, 13 and 29.
//  What is the largest prime factor of the number 600851475143 ?
using System;

internal class LargestPrimeFactor
{
    private static void Main()
    {
        long number = 600851475143;
        long prime = 2;
        long largest = 0;

        while (number > 1)
        {
            if (number % prime == 0)
            {
                if (largest < prime)
                {
                    largest = prime;
                }

                number /= prime;
                prime = 2;
            }
            else
            {
                prime++;
            }
        }

        Console.WriteLine(largest); // 6857
    }
}