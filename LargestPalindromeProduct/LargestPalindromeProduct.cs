// 4. A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
//  Find the largest palindrome made from the product of two 3-digit numbers.
using System;

internal class LargestPalindromeProduct
{
    private static void Main()
    {
        int largest = 0;
        int product = 0;
        int firstDigit = 999;
        int secondDigit = 999;
        int currentDigit = secondDigit;

        while (firstDigit > 0)
        {
            while (currentDigit > 0)
            {
                product = firstDigit * currentDigit;

                if (IsPalindrome(product) && largest < product)
                {
                    largest = product;
                }

                currentDigit--;
            }

            firstDigit--;
            currentDigit = secondDigit;
        }

        Console.WriteLine(largest); // 906609
    }

    private static bool IsPalindrome(int number)
    {
        int palindrome = number; // copied number into variable
        int reverse = 0;

        while (palindrome != 0)
        {
            int remainder = palindrome % 10;
            reverse = reverse * 10 + remainder;
            palindrome = palindrome / 10;
        }

        // if original and reverse of number is equal means number is palindrome
        if (number == reverse)
        {
            return true;
        }

        return false;
    }
}