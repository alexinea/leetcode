using System;
using System.Collections;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        static bool IsSelfCrossing(int[] x)
        {
            Hashtable ht = new Hashtable();
            //North -> xFun is  0 and yFun is  1   cur_ctrl % 4 == 0
            //West --> xFun is -1 and yFun is  0   cur_ctrl % 4 == 1
            //South -> xFun is  0 and yFun is -1   cur_ctrl % 4 == 2
            //East --> xFun is  1 and yFun is  0   cur_ctrl % 4 == 3
            int xFun = 0;
            int yFun = 1;

            //准备
            int cur_x = 0, cur_y = 0;
            ht.Add(string.Format("x{0}y{1}", cur_x, cur_y), 0);

            //开始
            for (int i = 0; i < x.Length; i++)
            {
                // i 就是 cur_ctrl
                switch (i % 4)
                {
                    case 0: xFun = 0; yFun = 1; break;
                    case 1: xFun = -1; yFun = 0; break;
                    case 2: xFun = 0; yFun = -1; break;
                    case 3: xFun = 1; yFun = 0; break;
                }

                var step = x[i];
                for (var j = step; j > 0; j--)
                {
                    cur_x += xFun;
                    cur_y += yFun;
                    var point = string.Format("x{0}y{1}", cur_x, cur_y);
                    if (ht.ContainsKey(point))
                        return true;

                    ht.Add(point, 0);
                }
            }

            return false;
        }
    }
}
