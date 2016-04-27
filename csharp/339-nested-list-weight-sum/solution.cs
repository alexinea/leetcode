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
            object[] nums = { 1, 2, 5, new object[] { 1, 3, 5, new object[] { 1, 5 } }, 4, 1, 5 };
            Console.WriteLine(GetSum(nums)); //=> 33
            Console.ReadLine();
        }

        static int GetSum(object[] nums)
        {
            List<int> all = new List<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                object obj = nums[i];
                var type = obj.GetType();
                if (type == typeof(int))
                    all.Add(Int32.Parse(obj.ToString()));
                else if (type.IsArray)
                {
                    object[] objs = obj as object[];
                    if (objs != null)
                        all.Add(GetSum(objs));
                }
            }
            return all.Sum();
        }


    }
}
