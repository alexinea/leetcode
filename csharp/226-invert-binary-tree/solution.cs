using System;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            TreeNode mid = root.left;
            root.left = root.right;
            root.right = mid;

            if (root.left != null)
                root.left = InvertTree(root.left);

            if (root.right != null)
                root.right = InvertTree(root.right);

            return root;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

}
