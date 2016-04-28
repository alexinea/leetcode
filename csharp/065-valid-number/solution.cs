using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IsNumber:");
            Console.WriteLine($"[空格] is {IsNumber(" ")}");       //==>false
            Console.WriteLine($". is {IsNumber(".")}");       //==>false
            Console.WriteLine($"0 is {IsNumber("0")}");       //==>true
            Console.WriteLine($".0 is {IsNumber(".0")}");       //==>true
            Console.WriteLine($"1. is {IsNumber("1.")}");       //==>true
            Console.WriteLine($"1.2 is {IsNumber("1.2")}");       //==>true
            Console.WriteLine($"a is {IsNumber("a")}");       //==>false
            Console.WriteLine($"1 a is {IsNumber("1 a")}");       //==>false
            Console.WriteLine($"e is {IsNumber("e")}");       //==>false
            Console.WriteLine($"2e10 is {IsNumber("2e10")}");       //==>true
            Console.WriteLine($"2E10 is {IsNumber("2E10")}");       //==>true
            Console.WriteLine($"2e1.0 is {IsNumber("2e1.0")}");       //==>false
            Console.WriteLine($"2e1E0 is {IsNumber("2e1E0")}");       //==>false
            Console.WriteLine($"+2e10 is {IsNumber("+2e10")}");       //==>true
            Console.WriteLine($"2e-10 is {IsNumber("2e-10")}");       //==>true
            Console.WriteLine($"+2e-10 is {IsNumber("+2e-10")}");       //==>true
            Console.WriteLine($"0e is {IsNumber("0e")}");       //==>false
            Console.WriteLine($"e9 is {IsNumber("e9")}");       //==>false
            Console.WriteLine($"6+1 is {IsNumber("6+1")}");       //==>false
            Console.WriteLine($".e1 is {IsNumber(".e1")}");       //==>false
            Console.WriteLine($"4e+ is {IsNumber("4e+")}");       //==>false
            Console.WriteLine($" -. is {IsNumber(" -.")}");       //==>false
            Console.WriteLine($"46.e3 is {IsNumber("46.e3")}");       //==>true
            Console.WriteLine($".e3 is {IsNumber(".e3")}");       //==>false
            Console.ReadLine();
        }

        static bool IsNumber(string s)
        {
            /*
             * 数字可以有前导空格和后置空格，不过数字中间不允许有空格；
             * 对于'.'，最多只允许出现1次，其前面可以没有数字，但后面一定要有数字；
             * 对于'e'，最多只允许出现1次，其前后都必须有数字，但后面一定是整数，即不能出现'.'；
             * 对于'+'和'-'，'e'的前后都最多只允许出现1次，且一定要在数字最前面出现；
             * 至于其他字符，只允许是数字（0~9）。
             * */

            s = s.Trim();
            if (string.IsNullOrWhiteSpace(s))
                return false;
            if (s.IndexOf(" ", StringComparison.Ordinal) > 0)
                return false;
            if (!(new System.Text.RegularExpressions.Regex(@"\d")).IsMatch(s))
                return false;
            var size = s.Length;
            var chars = "1234567890eE+-.";
            for (var i = 0; i < size; i++)
            {
                if (chars.IndexOf(s[i]) == -1)
                    return false;
            }
            var pointPos = s.IndexOf(".", StringComparison.Ordinal);
            if (pointPos >= 0 && pointPos < s.LastIndexOf(".", StringComparison.Ordinal))
                return false;
            var ePos = s.IndexOf("e", StringComparison.OrdinalIgnoreCase);
            if (ePos > -1 && (ePos == 0 || ePos == size - 1 || ePos < pointPos || (pointPos == 0 && pointPos + 1 == ePos) || ePos < s.LastIndexOf("e", StringComparison.OrdinalIgnoreCase)))
                return false;
            if (size - s.Replace("+", "").Length > 2 || size - s.Replace("-", "").Length > 2)
                return false;
            var opPos = s.IndexOfAny(new[] { '+', '-' });
            var opLastPos = s.LastIndexOfAny(new[] { '+', '-' });
            if ((opPos > 0 && opPos < ePos) || (opPos < opLastPos && (opLastPos != ePos + 1)) || (ePos == -1 && opPos > 0) || opPos + 1 == ePos || opLastPos + 1 == size)
                return false;
            return true;
        }


    }
}
