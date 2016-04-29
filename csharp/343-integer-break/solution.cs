using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        static int IntegerBreak(int n)
        {
            if (n < 2)
                return 0;
            if (n < 4)
                return n - 1;

            int ret = 1;
            while (n > 2)
            {
                ret *= 3;
                n -= 3;
            }

            if (n == 1) return (ret / 3) * 4;
            if (n == 2) return ret * 2;
            return ret;
        }
    }
}
