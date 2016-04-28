using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        static void DeleteNode(ListNode node)
        {
            if (node == null)
                return;

            node.val = node.next.val;
            node.next = node.next.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

}
