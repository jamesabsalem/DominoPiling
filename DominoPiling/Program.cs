using System;

namespace DominoPiling
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()?.Split();
            var m = Convert.ToInt32(input[0]);
            var n = Convert.ToInt32(input[1]);

            int numberOfDominions = 0;

            if (m % 2 == 0)
            {
                numberOfDominions = m / 2 * n;
            }
            else if (n % 2 == 0)
            {
                numberOfDominions = n / 2 * m;
            }
            else if (m % 2 == 1)
            {
                numberOfDominions = (m / 2 * n) + (n / 2);
            }
            Console.WriteLine(numberOfDominions);

        }
    }
}
