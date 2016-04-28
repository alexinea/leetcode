using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"num = 38, AddDigits={AddDigits(38)}"); //=>2
            Console.WriteLine($"num = 123, AddDigits={AddDigits(123)}"); //=>6
            Console.ReadLine();
        }

        static int AddDigits(int num)
        {
            if (num < 0)
                return 0;

            int size = num.ToString().Length;
            while (size > 1)
            {
                List<int> list = new List<int>();

                for (int i = 0; i < size; i++)
                {
                    var mod = num % 10;
                    num = (num - mod) / 10;
                    list.Insert(0, mod);
                }

                num = list.Sum();
                size = num.ToString().Length;
            }

            return num;
        }
    }

}
