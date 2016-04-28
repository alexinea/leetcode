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

        static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;

            ListNode ret = null, cur_ret = null;
            var cur_l1 = l1;
            var cur_l2 = l2;
            int carry = 0;
            while (cur_l1 != null || cur_l2 != null)
            {
                var v1 = cur_l1 == null ? 0 : cur_l1.val;
                var v2 = cur_l2 == null ? 0 : cur_l2.val;
                var a = v1 + v2 + carry;
                var b = a;

                if (a >= 10)
                {
                    b = a % 10;
                    carry = (a - b) / 10;
                }
                else
                {
                    carry = 0;
                }

                if (cur_ret == null)
                {
                    ret = new ListNode(b);
                    cur_ret = ret;
                }
                else
                {
                    cur_ret.next = new ListNode(b);
                    cur_ret = cur_ret.next;
                }

                cur_l1 = cur_l1 == null ? null : cur_l1.next;
                cur_l2 = cur_l2 == null ? null : cur_l2.next;
            }

            if (carry > 0)
            {
                cur_ret.next = new ListNode(carry);
            }

            return ret;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

}
