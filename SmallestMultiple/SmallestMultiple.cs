// 5. 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
//  What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

using System;
class SmallestMultiple
{
    static void Main(string[] args)
    {
        checked
        {
            int counter = 1;
            while (true)
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (counter % i != 0)
                    {
                        break;
                    }

                    if (i == 20)
                    {
                        Console.WriteLine(counter); // 232792560
                        return;
                    }
                }

                counter++;
            }
        }
    }
}

