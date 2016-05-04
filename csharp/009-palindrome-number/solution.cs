using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(0));//t
            Console.WriteLine(IsPalindrome(1));//t
            Console.WriteLine(IsPalindrome(11));//t
            Console.WriteLine(IsPalindrome(-1));//f
            Console.WriteLine(IsPalindrome(12321));//t
            Console.ReadLine();
        }

        static bool IsPalindrome(int x)
        {
            if (x < 0 || (x > 0 && x % 10 == 0))
                return false;

            long n = 0;
            long m = x;
            while (m >= 1)
            {
                n = n * 10 + m % 10;
                m /= 10;
            }

            return n == x;
        }
    }
}
