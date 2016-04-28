using System;
using System.Text;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 0, 1, 0, 3, 12 };
            Display(nums);
            MoveZeroes(nums);
            Display(nums);
            Console.WriteLine("------------------------------------");
            nums = new int[] { 0, 0, 1 };
            Display(nums);
            MoveZeroes(nums);
            Display(nums);

            Console.ReadLine();
        }

        static void Display(int[] nums)
        {
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void MoveZeroes(int[] nums)
        {
            var size = nums.Length;
            if (size == 0)
                return;

            var nonZeroSize = size;
            var index = 0;
            while (index < nonZeroSize)
            {
                if (nums[index] == 0)
                {
                    for (var i = index; i < nonZeroSize - 1; i++)
                    {
                        nums[i] = nums[i + 1];
                    }
                    nums[--nonZeroSize] = 0;
                }

                if (nums[index] != 0)
                    index++;
            }
        }


    }
}
