using System;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert("ABC", 2));
            Console.WriteLine(Convert("ABC", 3));
            Console.ReadLine();
        }

        static string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;

            string[] scolls = new string[numRows];
            int idx = 0, cur = 0, mid = numRows - 2;

            while (idx < s.Length)
            {
                    for (cur = 0; cur < numRows && idx < s.Length; cur++) scolls[cur] += s[idx++];
                    for (cur = mid; cur > 0 && idx < s.Length; cur--) scolls[cur] += s[idx++];
            }

            return scolls.Aggregate(string.Empty, (current, item) => current + item);
        }
    }
}
