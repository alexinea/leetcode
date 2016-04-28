using System;
using System.Text;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyAtoi:");
            Console.WriteLine($"123 is {MyAtoi("123")}");         //123
            Console.WriteLine($" 123456999999999r83 is {MyAtoi("123456999999999r83")}"); //maxvalue
            Console.WriteLine($"1r83 is {MyAtoi("1r83")}");       //1
            Console.WriteLine($"1000r83 is {MyAtoi("1000r83")}"); //1000
            Console.WriteLine($"-1000r83 is {MyAtoi("-1000r83")}"); //-1000
            Console.WriteLine($" -123456999999999r83 is {MyAtoi(" -123456999999999r83")}"); //minvalue
            Console.ReadLine();
        }

        static int MyAtoi(string s)
        {
            /*
             * 1. 字串为空或者全是空格，返回0； 
             * 2. 字串的前缀空格需要忽略掉；
             * 3. 忽略掉前缀空格后，遇到的第一个字符，如果是‘+’或‘－’号，继续往后读；如果是数字，则开始处理数字；如果不是前面的2种，返回0；
             * 4. 处理数字的过程中，如果之后的字符非数字，就停止转换，返回当前值；
             * 5. 在上述处理过程中，如果转换出的值超出了int型的范围，就返回int的最大值或最小值。
             * */

            s = s.Trim();
            if (string.IsNullOrWhiteSpace(s))
                return 0;
            string numbers = "0123456789";
            bool isNegative = false;
            if (s[0] == '+')
            {
                s = s.Substring(1);
            }
            else if (s[0] == '-')
            {
                isNegative = true;
                s = s.Substring(1);
            }

            StringBuilder sb = new StringBuilder();
            for (var i = 0; i < s.Length; i++)
            {
                if (numbers.IndexOf(s[i]) >= 0)
                    sb.Append(s[i]);
                else
                    break;
            }
            s = sb.ToString();

            int ret = 0;
            long safeRet = 0;
            bool isOverflow = false;
            for (var i = 0; i < s.Length; i++)
            {
                safeRet = safeRet * 10 + (s[i] - '0');
                if (safeRet > Int32.MaxValue || -safeRet < Int32.MinValue)
                {
                    isOverflow = true;
                    break;
                }
            }

            if (isOverflow)
                return isNegative ? Int32.MinValue : Int32.MaxValue;

            ret = (int)safeRet;
            return isNegative ? -ret : ret;
        }


    }
}
