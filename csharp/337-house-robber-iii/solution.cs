using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        static int Rob(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = 0;
            int right = 0;
            int cur = root.val;

            if (root.left != null)
            {
                left = Rob(root.left);
                cur += Rob(root.left.left) + Rob(root.left.right);
            }

            if (root.right != null)
            {
                right = Rob(root.right);
                cur += Rob(root.right.left) + Rob(root.right.right);
            }

            return cur > (left + right) ? cur : (left + right);
        }
    }
}
