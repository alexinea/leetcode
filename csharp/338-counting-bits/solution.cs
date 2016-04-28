using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5:");
            Display(CountBits(20));
            Console.ReadLine();
        }

        static void Display(int[] nums)
        {
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }

        static int[] CountBits(int num)
        {
            if (num < 0)
                return null;

            int[] nums = new int[num + 1];
            for (var i = 0; i <= num; i++)
            {
                var n = i;
                var counter = 0;
                while (n > 0)
                {
                    var mod = n % 2;
                    if (mod == 1) counter++;
                    n = (n - mod) / 2;
                }
                nums[i] = counter;
            }
            return nums;
        }
    }

}
