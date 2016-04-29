using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReverseVowels:");
            Console.WriteLine($"[ ] --> [{ReverseVowels(" ")}] << [ ]");
            Console.WriteLine($". --> {ReverseVowels(".")} << .");
            Console.WriteLine($"a. --> {ReverseVowels("a.")} << a.");
            Console.WriteLine($"hello --> {ReverseVowels("hello")} << holle");
            Console.WriteLine($"leetcode --> {ReverseVowels("leetcode")} << leotcede");
            Console.ReadLine();
        }

        static string ReverseVowels(string s)
        {
            string vowels = "aeiouAEIOU";
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            int size = s.Length;
            int cur_left = 0;
            int cur_right = size - 1;
            char[] ret = s.ToCharArray();

            while (cur_left <= cur_right)
            {
                if (cur_left >= size || cur_right < 0)
                    break;

                if (vowels.IndexOf(ret[cur_left]) > -1 && vowels.IndexOf(ret[cur_right]) > -1)
                {
                    var t = ret[cur_left];
                    ret[cur_left] = ret[cur_right];
                    ret[cur_right] = t;

                    cur_left++;
                    cur_right--;

                    continue;
                }

                if (vowels.IndexOf(ret[cur_left]) == -1)
                    cur_left++;

                if (vowels.IndexOf(ret[cur_right]) == -1)
                    cur_right--;
            }

            return new string(ret);
        }
    }
}
