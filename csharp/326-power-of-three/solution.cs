using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        static bool IsPowerOfThree(int n)
        {
            var m = Math.Log10(n) / Math.Log10(3);
            return m == (int)m;
        }
    }
}
