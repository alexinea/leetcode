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

        static int RomanToInt(string s)
        {
            /*
             * 基本字符： 　　I、V、X、L、C、D、M
             * 相应的阿拉伯数字表示为：
             * 1．5、10、50、100、500、1000
             * (1)相同的数字连写，所表示的数等于这些数字相加得到的数，如：Ⅲ = 3；
             * (2)小的数字在大的数字的右边，所表示的数等于这些数字相加得到的数， 如：Ⅷ = 8；Ⅻ = 12；
             * (3)小的数字，（限于Ⅰ、X 和C）在大的数字的左边，所表示的数等于大数减小数得到的数，如：Ⅳ= 4；Ⅸ= 9；
             * */

            s = s.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(s))
                return 0;

            int ret = 0;
            string j = "IXC";
            Dictionary<char, int> map = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
            for (var i = s.Length - 1; i >= 0; i--)
            {
                ret += map[s[i]];
                if (j.IndexOf(s[i]) > -1 && i + 1 < s.Length && map[s[i]] < map[s[i + 1]])
                    ret = ret - map[s[i]] * 2;
            }

            return ret;
        }
    }
}
