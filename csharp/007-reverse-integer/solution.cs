using System;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(123));
            Console.WriteLine(Reverse(-123));
            Console.WriteLine(Reverse(-2147483648));
            Console.ReadLine();
        }

        static int Reverse(int x)
        {
            if (x > -10 && x < 10)
                return x;

            bool isNegative = x < 0;
            long abs = Math.Abs((long)x);
            long ret = 0;

            while (abs >= 1)
            {
                ret = ret * 10 + abs % 10;
                abs /= 10;
            }

            if (ret > Int32.MaxValue)
                return 0;

            return isNegative ? (int)ret * -1 : (int)ret;
        }
    }
}
