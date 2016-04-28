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

        static ListNode ReverseList(ListNode head)
        {
            ListNode ret = null;
            var cur = head;
            while (cur != null)
            {
                if (ret == null)
                {
                    ret = new ListNode(cur.val);
                }
                else
                {
                    var a = ret;
                    ret = new ListNode(cur.val);
                    ret.next = a;
                }

                cur = cur.next;
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
