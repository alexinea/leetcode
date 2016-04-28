using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MissingNumber(new[] { 1, 2, 3, 5, 6, 4, 7, 0 }));
            Console.ReadLine();
        }

        static int MissingNumber(int[] nums)
        {
            List<int> list = nums.ToList();
            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != i)
                    return i;
            }
            return nums.Length;
        }
    }

}
