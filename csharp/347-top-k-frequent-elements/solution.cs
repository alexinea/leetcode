using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        static IList<int> TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var key = nums[i];
                if (d.ContainsKey(key))
                    d[key]++;
                else
                    d.Add(key, 0);
            }
            return d.OrderByDescending(o => o.Value).Select(s => s.Key).Take(k).ToList();
        }
    }
}
