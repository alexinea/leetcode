using System;
using System.Diagnostics;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine("in: eceba,3");
            Console.WriteLine("hope out: 4");
            Console.WriteLine($"real out:{LengthOfLongestSubstringKDistinct("eceba", 3)}");
            Console.WriteLine("---------------------------------------------------------------");
            watch.Stop();
            Console.WriteLine($"use {watch.ElapsedMilliseconds}ms");
            Console.WriteLine();
            watch.Reset();

            watch.Start();
            Console.WriteLine("in: ElapsedMilliseconds,8");
            Console.WriteLine("hope out: 13");
            Console.WriteLine($"real out:{LengthOfLongestSubstringKDistinct("ElapsedMilliseconds", 8)}");
            Console.WriteLine("---------------------------------------------------------------");
            watch.Stop();
            Console.WriteLine($"use {watch.ElapsedMilliseconds}ms");
            Console.WriteLine();
            watch.Reset();

            watch.Start();
            Console.WriteLine("in: LengthOfLongestSubstringKDistinct,11");
            Console.WriteLine("hope out: 18");
            Console.WriteLine($"real out:{LengthOfLongestSubstringKDistinct("LengthOfLongestSubstringKDistinct", 11)}");
            Console.WriteLine("---------------------------------------------------------------");
            watch.Stop();
            Console.WriteLine($"use {watch.ElapsedMilliseconds}ms");
            Console.WriteLine();
            watch.Reset();

            watch.Start();
            Console.WriteLine("in: aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa,2");
            Console.WriteLine("hope out: 0");
            Console.WriteLine($"real out:{LengthOfLongestSubstringKDistinct("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 2)}");
            Console.WriteLine("---------------------------------------------------------------");
            watch.Stop();
            Console.WriteLine($"use {watch.ElapsedMilliseconds}ms");
            Console.WriteLine();
            watch.Reset();

            watch.Start();
            Console.WriteLine("in: aaaaaaaaaaaaaaaaaabaaaaaaaaaaaaaaaaaaaaaaa,1");
            Console.WriteLine("hope out: 0");
            Console.WriteLine($"real out:{LengthOfLongestSubstringKDistinct("aaaaaaaaaaaaaaaaaabaaaaaaaaaaaaaaaaaaaaaaa", 1)}");
            Console.WriteLine("---------------------------------------------------------------");
            watch.Stop();
            Console.WriteLine($"use {watch.ElapsedMilliseconds}ms");
            Console.WriteLine();
            watch.Reset();

            Console.ReadLine();
        }

        static int LengthOfLongestSubstringKDistinct(string s, int k)
        {
            if (string.IsNullOrEmpty(s) || k == 0 || s.Length < k)
                return 0;

            int maxLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (j + 1 - i < k)
                        continue;

                    var substring = s.Substring(i, j + 1 - i);
                    var chars = substring.ToCharArray().Distinct();
                    var charLength = chars.Count();
                    if (charLength == k)
                    {
                        var subLength = substring.Length;
                        maxLength = maxLength > subLength ? maxLength : subLength;
                    }
                }
            }

            return maxLength;
        }
    }
}
