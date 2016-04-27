using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine(ReverseString("Hello World"));
            Console.ReadLine();
        }

        static string ReverseString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            StringBuilder sb = new StringBuilder();

            for (var i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }
}
