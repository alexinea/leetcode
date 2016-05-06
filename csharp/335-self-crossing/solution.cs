using System;
namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        static bool IsSelfCrossing(int[] x)
        {
            if (x.Length < 4)
                return false;

            for (int i = 0; i < x.Length - 3; i++)
            {
                if (x[i + 1] > x[i + 3])
                    continue;

                if (i < x.Length - 3 && x[i] >= x[i + 2] && x[i + 3] >= x[i + 1])
                    return true;

                if (i < x.Length - 4 && x[i + 1] == x[i + 3] && x[i] + x[i + 4] >= x[i + 2])
                    return true;

                if (i < x.Length - 5 && x[i + 1] + x[i + 5] >= x[i + 3] && x[i] + x[i + 4] >= x[2] && x[i + 1] < x[i + 3] && x[i + 4] < x[i + 2])
                    return true;
            }

            return false;
        }
    }
}
