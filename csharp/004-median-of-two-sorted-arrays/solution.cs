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

        static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1 == null && nums2 == null)
                return 0D;
            int[] mixedNums;
            if (nums1 == null || nums1.Length == 0)
                mixedNums = nums2;
            else if (nums2 == null || nums2.Length == 0)
                mixedNums = nums1;
            else
            {
                mixedNums = new int[nums1.Length + nums2.Length];
                nums1.CopyTo(mixedNums,0);
                nums2.CopyTo(mixedNums,nums1.Length);
            }

            if (mixedNums == null || mixedNums.Length == 0)
                return 0D;

            List<int> list = new List<int>(mixedNums);
            list.Sort();
            if (list.Count % 2 == 1)
                return list[(list.Count - 1) / 2];

            var l = list[list.Count / 2 - 1];
            var r = list[list.Count / 2];
            return ((double)(l + r)) / 2;
        }
    }

}
