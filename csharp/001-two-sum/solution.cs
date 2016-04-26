using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 4, 7, 2, 7, 2, 11, 15, 2 };
            var ret = TwoSum(nums, 9);
            Console.WriteLine("ret[0] = " + ret[0]);
            Console.WriteLine("ret[1] = " + ret[1]);
            Console.ReadLine();
        }

        static int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] { i, j };
                    }
                }
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}
